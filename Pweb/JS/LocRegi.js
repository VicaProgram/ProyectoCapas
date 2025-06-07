var table; // Variable global para almacenar la instancia de DataTable

// Ejecuta la función cuando el documento ha terminado de cargarse
$(document).ready(function () {
    cargarDatos(); // Llama a la función para cargar los datos en la tabla
});

// Función que obtiene los datos y los carga en la tabla
function cargarDatos() {
    // Verifica si la tabla ya ha sido inicializada con DataTable
    if ($.fn.DataTable.isDataTable('#Grid')) {
        $('#Grid').DataTable().destroy(); // Si existe, destruye la instancia para evitar duplicados
    }

    $('#Grid tbody').html(''); // Vacía el contenido del cuerpo de la tabla

    // Realiza una petición AJAX GET para obtener los datos del servidor
    AjaxGet("../PWJLocRegi.aspx/Obtener",
        function (response) { // Función que maneja la respuesta del servidor
            $(".card-body").LoadingOverlay("hide"); // Oculta la animación de carga

            if (response.estado) { // Si la respuesta indica éxito
                $.each(response.objeto, function (i, row) { // Itera sobre cada registro recibido
                    // Crea una nueva fila con datos y botones de acción
                    $("<tr>").append(
                        $("<td>").text(i + 1), // Número de fila
                        $("<td>").text(row.Nombre), // Nombre del registro
                        $("<td>").append(
                            $("<button>")
                                .addClass("btn btn-sm btn-primary mr-1") // Estilo del botón Editar
                                .text("Editar") // Texto del botón
                                .data("ELocReg", row), // Guarda los datos del registro
                            $("<button>")
                                .addClass("btn btn-sm btn-danger") // Estilo del botón Eliminar
                                .text("Eliminar") // Texto del botón
                                .data("ELocReg", row.IdReg) // Guarda el ID del registro
                        )
                    ).appendTo("#Grid tbody"); // Agrega la fila al cuerpo de la tabla
                });
            }

            // Inicializa DataTable con la opción de ser responsive
            table = $('#Grid').DataTable({ responsive: true });
        },
        function () { // Maneja errores si la consulta falla
            $(".card-body").LoadingOverlay("hide"); // Oculta animación de carga
        },
        function () { // Mientras se espera la respuesta, muestra la animación de carga
            $(".card-body").LoadingOverlay("show");
        }
    );
}

// Evento para convertir el texto ingresado a formato Title Case mientras se escribe
$('#TextIngMod').on('input', function () {
    var text = $(this).val(); // Obtiene el texto del campo
    var titleCasedText = text.replace(/\w\S*/g, function (txt) { // Aplica Title Case
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase(); // Convierte la primera letra a mayúscula y el resto a minúscula
    });

    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor
    $(this).val(titleCasedText); // Reemplaza el texto con el formato
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Evento para evitar que se ingresen números en el campo de texto
$('#TextIngMod').on('keypress', function (event) {
    if (event.key >= '0' && event.key <= '9') { // Si la tecla presionada es un número
        event.preventDefault(); // Bloquea la entrada
        alert('Solo se permiten letras.'); // Muestra un mensaje de alerta
    }
});

$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-primary mr-1"]', function () {
    var model = $(this).data("ELocReg");
    if (model) {
        $("#textId").val(model.IdReg);
        $("#TextIngMod").val(model.Nombre);
        // Cualquier carga adicional (si hubiere)
        $('#sidePanel').addClass('active');  // Muestra el panel lateral para editar
    } else {
        console.error("El registro no está definido.");
    }
});

$('#btnNuevo').on('click', function () {
    $("#textId").val(0);       // Indica un nuevo registro
    $("#TextIngMod").val("");  // Limpia el campo de nombre
    // Aquí, si hubiese dropdowns adicionales, podrías cargarlos
    $('#sidePanel').addClass('active');  // Muestra el panel lateral
});

$('#btnCloseSidePanel').on('click', function () {
    $('#sidePanel').removeClass('active');  // Oculta el panel lateral
});

// Evento al hacer clic en "Guardar Cambios" dentro del modal
$('#btnGuardarCambios').on('click', function () {
    var camposvacios = false; // Variable para verificar si hay campos vacíos
    var fields = $(".model").serializeArray(); // Obtiene todos los campos del formulario

    $.each(fields, function (i, field) { // Recorre los campos del formulario
        if (!field.value) { // Si algún campo está vacío
            camposvacios = true;
            return false; // Sale del bucle
        }
    });

    if (!camposvacios) { // Si todos los campos están llenos
        var request = { // Crea el objeto con los datos
            obj: {
                IdReg: parseInt($("#textId").val()), // ID del registro
                Nombre: $("#TextIngMod").val(), // Nombre ingresado
            }
        };

        if (parseInt($("#textId").val()) == 0) { // Si el ID es 0, se inserta un nuevo registro
            AjaxPost("../PWJLocRegi.aspx/Ingresar", JSON.stringify(request), // Realiza la petición AJAX
                function (response) { // Maneja la respuesta exitosa
                    $(".modal-body").LoadingOverlay("hide");
                    if (response.estado) {
                        cargarDatos(); // Recarga la tabla
                        $('#sidePanel').removeClass('active');
                        swal("Ingreso realizado correctamente"); //Muestra mensaje
                    } else {
                        swal("oops!", "Seleccione un registro válido", "warning");//Muestra mensaje
                    }
                },
                function () { $(".modal-body").LoadingOverlay("hide"); }, //Oculta mensaje
                function () { $(".modal-body").LoadingOverlay("show"); } //Muestra mensaje
            );
        } else { // Si el ID es distinto de 0, se actualiza el registro existente
            AjaxPost("../PWJLocRegi.aspx/Actualizar", JSON.stringify(request),// Realiza la petición AJAX
                function (response) {
                    $(".modal-body").LoadingOverlay("hide");//Oculta mensaje
                    if (response.estado) {
                        cargarDatos();
                        $('#sidePanel').removeClass('active');
                        swal("Actualización realizada correctamente");//Muestra mensaje
                    } else {
                        swal("oops!", "Seleccione un registro válido", "warning");//Muestra mensaje
                    }
                },
                function () { $(".modal-body").LoadingOverlay("hide"); },//Oculta mensaje
                function () { $(".modal-body").LoadingOverlay("show"); }//Muestra mensaje
            );
        }
    } else {
        swal("Mensaje", "Es necesario completar todos los campos", "warning");//Muestra mensaje
    }
});

// Evento al hacer clic en el botón "Eliminar"
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-danger"]', function () {
    var request = { IdReg: String($(this).data("ELocReg")) }; // Obtiene el ID del registro
    swal({ // Muestra una confirmación para eliminar
        title: "Mensaje",//Muestra mensaje
        text: "¿Está seguro de realizar la eliminación?",//Muestra mensaje
        type: "warning",//Muestra mensaje
        showCancelButton: true, //muestra boton
        confirmButtonColor: '#DD6B55', //define el color
        cancelButtonColor: '#d33', //define el color
        confirmButtonText: "Sí", //define el texto del boton
        cancelButtonText: "No",//define el texto del boton
        closeOnConfirm: false, //Cierra el mensaje
    }, function () {
        AjaxPost("../PWJLocRegi.aspx/Eliminar", JSON.stringify(request),// Realiza la petición AJAX
            function (response) {
                if (response.estado) {
                    cargarDatos(); // Refresca la tabla después de eliminar
                    swal.close();//Cierra el mensaje
                } else {
                    swal("Mensaje", "No se pudo eliminar el registro", "warning");//Muestra mensaje
                }
            },
            function (error) { console.log("Error: ", error); }, // Maneja errores
            function () { console.log("Complete"); }// Maneja errores
        );
    });
});

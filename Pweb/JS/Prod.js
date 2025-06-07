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
    AjaxGet("../PWJProd.aspx/Obtener",
        function (response) { // Función que maneja la respuesta del servidor
            $(".card-body").LoadingOverlay("hide"); // Oculta la animación de carga

            if (response.estado) { // Si la respuesta indica éxito
                $.each(response.objeto, function (i, row) { // Itera sobre cada registro recibido
                    // Crea una nueva fila con datos y botones de acción
                    $("<tr>").append(
                        $("<td>").text(i + 1), // Número de fila
                        $("<td>").text(row.Nombre), // Carga Fields
                        $("<td>").text(row.FInc), // Carga Fields
                        $("<td>").text(row.CInc), // Carga Fields
                        $("<td>").text(row.CAct), // Carga Fields
                        $("<td>").text(row.CArr),// Carga Fields
                        $("<td>").text(row.TAct), // Carga Fields
                        $("<td>").text(row.VArr), // Carga Fields
                        $("<td>").append(
                            $("<button>") //Crea boton
                                .addClass("btn btn-sm btn-primary mr-1")
                                .text("Editar")
                                .attr("data-eprod", JSON.stringify(row)),
                            $("<button>")//Crea boton
                                .addClass("btn btn-sm btn-danger")
                                .text("Eliminar")
                                .attr("data-eprod", JSON.stringify(row)),
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
$('#TextNom').on('input', function () {
    var text = $(this).val(); // Obtiene el texto del campo
    var titleCasedText = text.replace(/\w\S*/g, function (txt) { // Aplica Title Case
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase(); // Convierte la primera letra a mayúscula y el resto a minúscula
    });

    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor
    $(this).val(titleCasedText); // Reemplaza el texto con el formato
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Evento para evitar que se ingresen números en el campo de texto
$('#TextNom').on('keypress', function (event) {
    if (event.key >= '0' && event.key <= '9') { // Si la tecla presionada es un número
        event.preventDefault(); // Bloquea la entrada
        alert('Solo se permiten letras.'); // Muestra un mensaje de alerta
    }
});

// Escucha el evento "keypress" en el input con id "TextFInc"
$('#TextFInc').on('keypress', function (e) {

    // Permite teclas de control (ej. backspace) sin hacer validación
    if (e.which < 32) return;

    // Obtiene el valor actual del input y el carácter que se intenta ingresar
    var currentVal = this.value,
        char = String.fromCharCode(e.which);

    // Si ya se han ingresado 10 caracteres (formato completo), muestra alerta y detiene la entrada
    if (currentVal.length >= 10) {
        alert("El formato ya está completo: dd-mm-yyyy");
        e.preventDefault();
        return;
    }

    // Comprueba que el carácter ingresado sea un dígito; si no, muestra alerta y detiene la entrada
    if (!/\d/.test(char)) {
        alert("Solo se permiten números en el formato dd-mm-yyyy.");
        e.preventDefault();
        return;
    }

    // Si el input tiene 2 o 5 caracteres, se asume que es momento de insertar el guion
    if (currentVal.length === 2 || currentVal.length === 5) {
        this.value = currentVal + '-' + char; // Agrega el guion seguido del número
        e.preventDefault(); // Evita que el carácter se agregue de nuevo
    }
});


// Permite exclusivamente la entrada de números en el input
$('#TextCInc').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});
// Permite exclusivamente la entrada de números en el input
$('#TextCAct').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});
// Permite exclusivamente la entrada de números en el input
$('#TextCArr').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});

// Permite exclusivamente la entrada de números en el input
$('#TextTAct').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});

// Permite exclusivamente la entrada de números en el input
$('#TextVArr').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});


$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-primary mr-1"]', function () {
    var model = $(this).data("eprod");
    console.log(model); // Muestra el objeto en la consola para depuración
    $("#textId").val(model.IdProd);// Carga Fields
    $("#TextNom").val(model.Nombre);// Carga Fields
    $("#TextFInc").val(model.FInc);// Carga Fields
    $("#TextCInc").val(model.CInc);// Carga Fields
    $("#TextCAct").val(model.CAct);// Carga Fields
    $("#TextCArr").val(model.CArr);// Carga Fields
    $("#TextTAct").val(model.TAct);// Carga Fields
    $("#TextVArr").val(model.VArr);// Carga Fields
    $('#sidePanel').addClass('active');        // Muestra el sidepanel
});

// Evento: Al hacer click en el botón de cerrar (la "X") del panel lateral
$('#btnCloseSidePanel').on('click', function () {
    // Remueve la clase "active" para ocultar el panel lateral
    $('#sidePanel').removeClass('active');
});

$('#btnNuevo').on('click', function () {
    $("#textId").val(0);       // Indica un nuevo registro
    $("#TextNom").val("");  // Limpia el campo 
    $("#TextFInc").val("");// Limpia el campo 
    $("#TextCInc").val("");// Limpia el campo 
    $("#TextCAct").val("");// Limpia el campo 
    $("#TextCArr").val("");// Limpia el campo 
    $("#TextTAct").val("");// Limpia el campo 
    $("#TextVArr").val("");// Limpia el campo 
    $('#sidePanel').addClass('active');        // Muestra el sidepanel
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
                IdProd: parseInt($("#textId").val()), // ID del registro
                Nombre: $("#TextNom").val(), // Nombre ingresado
                FInc: $("#TextFInc").val(), // Fecha de inicio
                CInc: $("#TextCInc").val(), // Cantidad inicial
                CAct: $("#TextCAct").val(), // Cantidad actual
                CArr: $("#TextCArr").val(), // Cantidad a recibir
                TAct: $("#TextTAct").val(), // Total a recibir
                VArr: $("#TextVArr").val(), // Valor a recibir
            }
        };

        if (parseInt($("#textId").val()) == 0) { // Si el ID es 0, se inserta un nuevo registro
            AjaxPost("../PWJProd.aspx/Ingresar", JSON.stringify(request), // Realiza la petición AJAX
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
            AjaxPost("../PWJProd.aspx/Actualizar", JSON.stringify(request),// Realiza la petición AJAX
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
    var model = $(this).data("eprod");
    var request = { IdProd: model.IdProd.toString() }; // Prepara la solicitud con el ID del registro a eliminar
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
        AjaxPost("../PWJProd.aspx/Eliminar", JSON.stringify(request),// Realiza la petición AJAX
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

// Variable global para almacenar la DataTable de la tabla de provincias
var table;

// Cuando el documento esté listo
$(document).ready(function () {
    cargarDatos(); // Se carga la tabla con las provincias
});

// Función para cargar las regiones en el dropdown usando el WebMethod de PWJLocRegi
function cargarRegiones(callback) {
    // Llama al método Obtener de PWJLocRegi.aspx
    AjaxGet("../PWJLocRegi.aspx/Obtener",
        function (response) { // Callback de éxito al obtener las regiones
            if (response.estado) {
                var select = $("#ddlRegiones"); // Selecciona el elemento dropdown
                select.empty(); // Limpia las opciones actuales
                // Agrega una opción por defecto
                select.append($("<option>").val(0).text("Seleccione..."));
                // Por cada región recibida, agrega una opción al dropdown
                $.each(response.objeto, function (i, region) {
                    select.append($("<option>").val(region.IdReg).text(region.Nombre));
                });
                // Si se definió un callback, se ejecuta (útil para asignar el valor en edición)
                if (callback) callback();
            } else {
                console.error("No se pudieron cargar las regiones");
            }
        },
        function () { // Callback en caso de error en la llamada Ajax
            console.error("Error en la llamada Ajax para regiones");
        },
        function () {
            // Opcional: aquí podrías mostrar un spinner u overlay durante la carga
        }
    );
}

// Función para cargar las provincias en la tabla
function cargarDatos() {
    // Si la DataTable ya está inicializada, la destruye para evitar duplicados
    if ($.fn.DataTable.isDataTable('#Grid')) {
        $('#Grid').DataTable().destroy();
    }
    // Limpia el contenido del cuerpo de la tabla
    $('#Grid tbody').html('');
    // Llama al WebMethod Obtener de PWJLocProv.aspx para obtener las provincias
    AjaxGet("../PWJLocProv.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay de carga
            if (response.estado) {
                // Para cada provincia recibida...
                $.each(response.objeto, function (i, row) {
                    // Crea una fila (tr) con 4 celdas:
                    // 1. Índice (número de la fila)
                    // 2. Nombre de la provincia
                    // 3. Nombre de la región asociada (proveniente del objeto Reg)
                    // 4. Botones de acción (Editar y Eliminar)
                    $("<tr>").append(
                        $("<td>").text(i + 1),
                        $("<td>").text(row.Nombre),
                        $("<td>").text(row.Reg.Nombre),
                        $("<td>").append(
                            // Botón Editar: Guarda todo el objeto 'row' en los datos
                            $("<button>")
                                .addClass("btn btn-sm btn-primary mr-1")
                                .text("Editar")
                                .data("ELocPro", row),
                            // Botón Eliminar: Guarda el ID de la provincia en los datos
                            $("<button>")
                                .addClass("btn btn-sm btn-danger")
                                .text("Eliminar")
                                .data("ELocPro", row.IdPro)
                        )
                    ).appendTo("#Grid tbody"); // Agrega la fila al tbody de la tabla
                });
            } else {
                alert("No se pudieron cargar los datos de las provincias.");
            }
            // Inicializa la DataTable con opción responsive
            table = $('#Grid').DataTable({ responsive: true });
        },
        function () { // Callback de error en la llamada Ajax
            $(".card-body").LoadingOverlay("hide");
        },
        function () { // Callback mientras se espera la respuesta
            $(".card-body").LoadingOverlay("show");
        }
    );
}

// Transforma el texto del input a Title Case mientras se escribe
$('#TextIngMod').on('input', function () {
    var text = $(this).val(); // Obtiene el valor actual
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Pone la primera letra en mayúscula y las siguientes en minúscula
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });
    var cursorPosition = this.selectionStart; // Guarda la posición del cursor
    $(this).val(titleCasedText); // Actualiza el input con el texto transformado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Evita que se ingresen números en el campo del nombre
$('#TextIngMod').on('keypress', function (event) {
    if (event.key >= '0' && event.key <= '9') { // Si la tecla es un número...
        event.preventDefault(); // Evita que se ingrese
        alert('Solo se permiten letras.'); // Muestra una alerta
    }
});

// Evento: Al hacer click en el botón "Editar" de una fila en la tabla
$('#Grid tbody').on('click', 'button.btn-primary', function () {
    // Obtiene el objeto de la Provincia almacenado en el atributo data("ELocPro") del botón
    var model = $(this).data("ELocPro");
    // Si el objeto existe, se procede a cargar sus datos en el formulario del panel lateral
    if (model) {
        // Establece el valor del campo oculto (ID) con el ID de la Provincia a editar
        $("#textId").val(model.IdPro);
        // Asigna el nombre de la Provincia al input correspondiente
        $("#TextIngMod").val(model.Nombre);
        // Llama a la función que carga y popula el dropdown de Regiones;
        // una vez cargado, se selecciona la región correspondiente del modelo
        cargarRegiones(function () {
            $("#ddlRegiones").val(model.IdReg);
        });
        // Muestra el panel lateral para editar agregando la clase "active"
        $('#sidePanel').addClass('active');
    } else {
        // En caso de que no exista el objeto, se registra un error en la consola
        console.error("El registro no está definido.");
    }
});

// Evento: Al hacer click en el botón "Nuevo"
$('#btnNuevo').on('click', function () {
    // Reinicia el campo oculto a 0 para indicar que se crea un nuevo registro
    $("#textId").val(0);
    // Limpia el campo del nombre
    $("#TextIngMod").val("");
    // Carga el dropdown de Regiones y, una vez cargado, selecciona la opción predeterminada (valor 0)
    cargarRegiones(function () {
        $("#ddlRegiones").val(0);
    });
    // Muestra el panel lateral para ingresar un nuevo registro añadiendo la clase "active"
    $('#sidePanel').addClass('active');
});

// Evento: Al hacer click en el botón de cerrar (la "X") del panel lateral
$('#btnCloseSidePanel').on('click', function () {
    // Remueve la clase "active" para ocultar el panel lateral
    $('#sidePanel').removeClass('active');
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
                IdPro: parseInt($("#textId").val()), // ID del registro
                Nombre: $("#TextIngMod").val(), // Nombre ingresado
                IdReg: parseInt($("#ddlRegiones").val()) // ID de la región seleccionada
            }
        };

        if (parseInt($("#textId").val()) == 0) { // Si el ID es 0, se inserta un nuevo registro
            AjaxPost("../PWJLocProv.aspx/Ingresar", JSON.stringify(request), // Realiza la petición AJAX
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
            AjaxPost("../PWJLocPrvo.aspx/Actualizar", JSON.stringify(request),// Realiza la petición AJAX
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

// Evento delegado para el botón "Eliminar" en cada fila de la tabla
$('#Grid tbody').on('click', 'button.btn-danger', function () {
    // Recupera el ID de la provincia almacenado en el atributo data("ELocReg") del botón
    var id = $(this).data("ELocPro");

    // Prepara un objeto de solicitud que contiene el ID de la provincia, convertido a cadena
    var request = { IdPro: String(id) };

    // Muestra un mensaje de confirmación utilizando la librería swal (SweetAlert)
    swal({
        title: "Mensaje",                     // Título del mensaje
        text: "¿Está seguro de realizar la eliminación?", // Mensaje de confirmación
        type: "warning",                      // Tipo de mensaje (advertencia)
        showCancelButton: true,               // Muestra un botón para cancelar
        confirmButtonColor: '#DD6B55',         // Color del botón de confirmar
        cancelButtonColor: '#d33',             // Color del botón de cancelar
        confirmButtonText: "Sí",              // Texto del botón de confirmar
        cancelButtonText: "No",               // Texto del botón de cancelar
        closeOnConfirm: false,                // No cierra el alert automáticamente al confirmar
    }, function () {
        // Función callback que se ejecuta cuando el usuario confirma la eliminación

        // Llama a la función AjaxPost para enviar la solicitud de eliminación al servidor
        AjaxPost("../PWJLocProv.aspx/Eliminar", JSON.stringify(request),
            function (response) { // Callback que maneja la respuesta exitosa
                if (response.estado) {
                    cargarDatos(); // Recarga la tabla para reflejar la eliminación
                    swal.close();   // Cierra el alerta de confirmación
                } else {
                    // Si la eliminación falla, muestra un mensaje de advertencia
                    swal("Mensaje", "No se pudo eliminar el registro", "warning");
                }
            },
            function (error) { console.log("Error:", error); },  // Callback para manejar errores en la petición
            function () { console.log("Complete"); }            // Callback que se ejecuta al finalizar la petición
        );
    });
});


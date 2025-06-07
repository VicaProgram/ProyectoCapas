var table; // Variable global que almacenará la instancia de DataTable

$(document).ready(function () {
    // Al cargar el DOM, se invocan las siguientes funciones para inicializar la página:
    cargarDatos();     // Carga datos de clientes en la tabla
    ObtenerRegi();     // Carga y popula el dropdown de Regiones
    ObtenerProv();     // Carga y popula el dropdown de Provincias
    ObtenerComu();     // Carga y popula el dropdown de Comunas
    Filtrar();         // Configura eventos de filtrado entre dropdowns
});

function Filtrar() {
    // Cuando cambia el dropdown de Región:
    $("#ComboIngModReg").change(function () {
        var idReg = $(this).val(); // Captura el ID de la región seleccionada
        FiltrarReg(idReg);         // Llama a la función para filtrar las provincias por región
    });
    // Cuando cambia el dropdown de Provincia:
    $("#ComboIngModPro").change(function () {
        var idPro = $(this).val(); // Captura el ID de la provincia seleccionada
        FiltrarPro(idPro);         // Llama a la función para filtrar las comunas por provincia
    });
}

function cargarDatos() {
    // Si la tabla ya se inicializó con DataTable, se destruye para reinicializarla
    if ($.fn.DataTable.isDataTable('#Grid')) {
        $('#Grid').DataTable().destroy();
    }
    // Limpia el contenido del cuerpo de la tabla
    $('#Grid tbody').html('');

    // Realiza una llamada AJAX para obtener los datos de clientes
    AjaxGet("../PWJCliente.aspx/Obtener",
        function (response) { // Callback de éxito
            console.log(response); // Muestra la respuesta en la consola (debug)
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay de carga
            if (response.estado) { // Si la respuesta es exitosa:
                $.each(response.objeto, function (i, row) {
                    // Crea una nueva fila y la agrega al tbody de la tabla
                    $("<tr>").append(
                        $("<td>").text(i + 1),               // Número de registro
                        $("<td>").text(row.Nombre),            // Nombre del cliente
                        $("<td>").text(row.Rut),               // RUT del cliente
                        $("<td>").text(row.Com.Nombre),        // Nombre de la comuna
                        $("<td>").text(row.Pro.Nombre),        // Nombre de la provincia
                        $("<td>").text(row.Reg.Nombre),        // Nombre de la región
                        $("<td>").text(row.Direccion),         // Dirección
                        $("<td>").text(row.Tel),               // Teléfono
                        $("<td>").text(row.Email),             // Email
                        $("<td>").text(row.Giro),              // Giro o actividad
                        $("<td>").append(
                            $("<button>")
                                .addClass("btn btn-sm btn-primary mr-1")
                                .text("Editar")
                                .attr("data-ecliente", JSON.stringify(row)),
                            $("<button>")
                                .addClass("btn btn-sm btn-danger")
                                .text("Eliminar")
                                .attr("data-ecliente", JSON.stringify(row)),
                        )
                    ).appendTo("#Grid tbody");
                });
            }
            // Inicializa el DataTable con opción responsive para la tabla
            table = $('#Grid').DataTable({
                responsive: true
            });
        },
        function () { // Callback de error
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay de carga en caso de error
        },
        function () { // Callback antes del envío (beforeSend)
            $(".card-body").LoadingOverlay("show"); // Muestra el overlay de carga mientras se realiza la llamada AJAX
        }
    );
}

function ObtenerRegi() {
    $("#ComboIngModReg").html(""); // Limpia las opciones del dropdown de Regiones

    // Llama vía AJAX para obtener las Regiones
    AjaxGet("../PWJLocRegi.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega opción por defecto para seleccionar una región
            $("<option>").attr({ "value": "0" }).text("Seleccione Región").appendTo("#ComboIngModReg");
            if (response.estado) { // Si la respuesta es exitosa:
                $.each(response.objeto, function (i, row) {
                    // Agrega cada región como opción en el dropdown
                    $("<option>").attr({ "value": row.IdReg }).text(row.Nombre).appendTo("#ComboIngModReg");
                });
            }
        },
        function () { // Callback de error
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay en caso de error
        },
        function () { // Callback beforeSend
            $(".card-body").LoadingOverlay("show"); // Muestra overlay antes de la llamada
        }
    );
}

function ObtenerProv() {
    $("#ComboIngModPro").html(""); // Limpia las opciones del dropdown de Provincias

    // Llama vía AJAX para obtener las Provincias
    AjaxGet("../PWJLocProv.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega opción por defecto para seleccionar una provincia
            $("<option>").attr({ "value": "0" }).text("Seleccione Provincia").appendTo("#ComboIngModPro");
            if (response.estado) { // Si la respuesta es exitosa:
                $.each(response.objeto, function (i, row) {
                    // Agrega cada provincia como opción en el dropdown
                    $("<option>").attr({ "value": row.IdPro }).text(row.Nombre).appendTo("#ComboIngModPro");
                });
            }
        },
        function () { // Callback de error
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay en caso de error
        },
        function () { // Callback beforeSend
            $(".card-body").LoadingOverlay("show"); // Muestra overlay antes de la llamada AJAX
        }
    );
}

function ObtenerComu() {
    $("#ComboIngModCom").html(""); // Limpia las opciones del dropdown de Comunas

    // Llama vía AJAX para obtener las Comunas
    AjaxGet("../PWJLocComu.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega opción por defecto para seleccionar una comuna
            $("<option>").attr({ "value": "0" }).text("Seleccione Comuna").appendTo("#ComboIngModCom");
            if (response.estado) { // Si la respuesta es exitosa:
                $.each(response.objeto, function (i, row) {
                    // Agrega cada comuna como opción en el dropdown
                    $("<option>").attr({ "value": row.IdCom }).text(row.Nombre).appendTo("#ComboIngModCom");
                });
            }
        },
        function () { // Callback de error
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay en error
        },
        function () { // Callback beforeSend
            $(".card-body").LoadingOverlay("show"); // Muestra overlay mientras se realiza la llamada
        }
    );
}

function FiltrarReg(idReg) {
    // Realiza una llamada AJAX POST para filtrar provincias según la región seleccionada
    $.ajax({
        type: "POST", // Tipo de método
        url: "PWJProv.aspx/FiltrarReg", // URL del servicio para filtrar por región
        data: JSON.stringify({ IdReg: idReg }), // Envía el ID de la región en formato JSON
        contentType: "application/json; charset=utf-8", // Define el tipo de contenido
        dataType: "json", // Se espera una respuesta en JSON
        success: function (response) { // Callback de éxito
            var Provincias = response.d; // Obtiene la lista de provincias del objeto de respuesta
            var comboIngModPro = $("#ComboIngModPro");
            comboIngModPro.empty(); // Limpia las opciones actuales del dropdown de provincias
            $.each(Provincias, function (i, Provincia) {
                // Agrega cada provincia filtrada al dropdown
                $("<option>").val(Provincia.IdPro).text(Provincia.Nombre).appendTo(comboIngModPro);
            });
        },
        error: function (error) { // Callback de error
            console.error("Error al obtener provincias:", error); // Muestra error en consola
        }
    });
}

function FiltrarPro(idPro) {
    // Realiza una llamada AJAX POST para filtrar comunas según la provincia seleccionada
    $.ajax({
        type: "POST", // Método POST
        url: "PWJProv.aspx/FiltrarPro", // URL del servicio para filtrar por provincia
        data: JSON.stringify({ IdPro: idPro }), // Envía el ID de la provincia en JSON
        contentType: "application/json; charset=utf-8", // Define el tipo de contenido
        dataType: "json", // Especifica que la respuesta es JSON
        success: function (response) { // Callback de éxito
            var Comunas = response.d; // Obtiene la lista de comunas del objeto respuesta
            var comboIngModCom = $("#ComboIngModCom");
            comboIngModCom.empty(); // Limpia las opciones actuales del dropdown de comunas
            $.each(Comunas, function (i, Comuna) {
                // Agrega cada comuna filtrada al dropdown
                $("<option>").val(Comuna.IdCom).text(Comuna.Nombre).appendTo(comboIngModCom);
            });
        },
        error: function (error) { // Callback de error
            console.error("Error al obtener Comunas:", error); // Muestra error en consola
        }
    });
}

// Evento: Al ingresar texto en el input con id "TextNom"
$('#TextNom').on('input', function () {
    var text = $(this).val();  // Obtiene el valor actual del input
    // Convierte cada palabra a "Title Case": primera letra mayúscula y el resto en minúscula
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });

    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor

    $(this).val(titleCasedText); // Actualiza el input con el texto en formato "Title Case"

    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Evento: Al presionar una tecla en el input "TextNom"
$('#TextNom').on('keypress', function (event) {
    // Si la tecla es un dígito numérico, se evita su ingreso
    if (event.key >= '0' && event.key <= '9') {
        event.preventDefault(); // Cancela la acción predeterminada (ingresar el número)
        alert('Solo se permiten letras.'); // Notifica al usuario que solo se permiten letras
    }
});

// Convierte a Title Case el valor del input de dirección y conserva la posición del cursor
$('#TextDire').on('input', function () {
    var text = $(this).val(); // Obtiene el valor actual del input
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Convierte cada palabra: primera letra en mayúscula y el resto en minúscula
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });
    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor
    $(this).val(titleCasedText); // Actualiza el input con el texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Aplica la misma conversión a Title Case para el input de giro
$('#TextGir').on('input', function () {
    var text = $(this).val(); // Obtiene el texto actual del input de giro
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Formatea a Title Case cada palabra
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });
    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor
    $(this).val(titleCasedText); // Actualiza el input con el texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Permite solo números en el input de teléfono, exceptuando teclas de retroceso y otros especiales
$('#TextTel').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Verifica si el código de la tecla no está entre 48 y 57 (números)
        if (event.which !== 8 && event.which !== 0) { // Permite la tecla de retroceso (8) y otras autorizadas (0)
            event.preventDefault(); // Impide el ingreso del caracter no numérico
            alert('Solo se permiten números.'); // Muestra alerta informativa
        }
    }
});

// Aplica el formato Title Case al input de descripción, manteniendo la posición del cursor
$('#TextDes').on('input', function () {
    var text = $(this).val(); // Obtiene el valor actual del input de descripción
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Cambia cada palabra a Title Case
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });
    var cursorPosition = this.selectionStart; // Almacena la posición actual del cursor
    $(this).val(titleCasedText); // Actualiza el input con el nuevo texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Al hacer clic en el botón de edición dentro de la grilla, se carga la información del registro al sidepanel
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-primary mr-1"]', function () {
    var model = $(this).data("ecliente"); // Recupera el objeto (registro) asociado al botón
    $("#textId").val(model.IdP_Cli);      // Asigna el ID del cliente al input correspondiente
    $("#TextNom").val(model.Nombre);       // Asigna el nombre del cliente
    $("#TextRut").val(model.Rut);          // Asigna el RUT del cliente
    $("#ComboIngModReg").val(model.IdReg); // Selecciona la región asociada al cliente
    $("#ComboIngModPro").val(model.IdPro); // Selecciona la provincia asociada
    $("#ComboIngModCom").val(model.IdCom); // Selecciona la comuna asociada
    $("#TextDire").val(model.Direccion);   // Coloca la dirección en el input
    $("#TextTel").val(model.Tel);          // Coloca el teléfono en el input
    $("#TextEma").val(model.Email);        // Coloca el email en el input
    $("#TextGir").val(model.Giro);         // Coloca el giro en el input
    $('#sidePanel').addClass('active');        // Muestra el sidepanel
});

// Al hacer clic en "Nuevo", se limpia el formulario y se muestra el sidepanel para ingresar un registro nuevo
$('#btnNuevo').on('click', function () {
    console.log("click")
    $("#textId").val(0);                              // Establece el ID a 0 para señalizar un nuevo registro
    $("#TextNom").val("");                            // Limpia el campo de nombre
    $("#TextRut").val("");                            // Limpia el campo de RUT
    $("#ComboIngModReg").prop('selectedIndex', 0);    // Resetea el dropdown de región
    $("#ComboIngModPro").prop('selectedIndex', 0);    // Resetea el dropdown de provincia
    $("#ComboIngModCom").prop('selectedIndex', 0);    // Resetea el dropdown de comuna
    $("#TextDire").val("");                           // Limpia el campo de dirección
    $("#TextTel").val("");                            // Limpia el campo de teléfono
    $("#TextEma").val("");                            // Limpia el campo de email
    $("#TextGir").val("");                            // Limpia el campo de giro
    $('#sidePanel').addClass('active');               // Muestra el sidepanel
});

// Evento: Al hacer click en el botón de cerrar (la "X") del panel lateral
$('#btnCloseSidePanel').on('click', function () {
    // Remueve la clase "active" para ocultar el panel lateral
    $('#sidePanel').removeClass('active');
});
// Al hacer clic en "Guardar Cambios", se valida que todos los campos estén completos y se decide si se ingresa o se actualiza el registro
$('#btnGuardarCambios').on('click', function () {
    var camposvacios = false;                       // Flag para detectar campos vacíos
    var fields = $(".model").serializeArray();      // Serializa los campos del formulario con clase "model"
    $.each(fields, function (i, field) {
        if (!field.value) {                         // Si algún campo está vacío
            camposvacios = true;                    // Marca la variable
            return false;                           // Rompe el bucle
        }
    });
    if (!camposvacios) {                            // Si todos los campos están completados
        // Construye el objeto de solicitud con los datos del formulario
        var request = {
            obj: {
                IdP_Cli: parseInt($("#textId").val()),   // ID del cliente (convertido a entero)
                Nombre: $("#TextNom").val(),               // Nombre
                Rut: $("#TextRut").val(),                  // RUT
                IdCom: $("#ComboIngModCom").val(),         // ID de la comuna
                Direccion: $("#TextDire").val(),           // Dirección
                Tel: $("#TextTel").val(),                  // Teléfono
                Email: $("#TextEma").val(),                // Email
                Giro: $("#TextGir").val(),                 // Giro
                IdReg: $("#ComboIngModReg").val(),         // ID de la región
                IdPro: $("#ComboIngModPro").val(),         // ID de la provincia
            }
        }
        // Si el ID es 0, se considera un registro nuevo
        if (parseInt($("#textId").val()) == 0) {
            // Actualiza dropdowns y filtros antes de ingresar
            ObtenerRegi();
            ObtenerProv();
            ObtenerComu();
            Filtrar();
            // Envía el request mediante AJAX para ingresar el registro nuevo
            AjaxPost("../PWJCliente.aspx/Ingresar", JSON.stringify(request),
                function (response) { // Callback de éxito
                    $(".modal-body").LoadingOverlay("hide"); // Oculta el overlay de carga del modal
                    if (response.estado) { // Si la operación tuvo éxito:
                        cargarDatos();                     // Recarga la grilla de datos
                        $('#sidePanel').removeClass('active'); // Oculta el sidepanel
                        swal("Ingreso fue realizado correctamente"); // Muestra mensaje de éxito
                    } else {
                        swal("oops!", "Seleccione un registro valido", "warning"); // Muestra advertencia en caso de error
                    }
                },
                function () { // Callback de error
                    $(".modal-body").LoadingOverlay("hide"); // Oculta el overlay ante error
                },
                function () { // Callback beforeSend
                    $(".modal-body").LoadingOverlay("show"); // Muestra el overlay de carga
                }
            );
        } else { // Si el registro ya existe (ID distinto de 0), se actualiza
            AjaxPost("../PWJCliente.aspx/Actualizar", JSON.stringify(request),
                function (response) { // Callback de éxito
                    $(".modal-body").LoadingOverlay("hide"); // Oculta overlay de carga
                    if (response.estado) { // Si la actualización es exitosa:
                        cargarDatos();                     // Recarga la grilla de datos
                        $('#sidePanel').removeClass('active'); // Oculta el sidepanel
                        swal("Actualización fue realizado correctamente"); // Muestra mensaje de éxito
                    } else {
                        swal("oops!", "Seleccione un registro valido", "warning"); // Muestra advertencia en caso de error
                    }
                },
                function () { // Callback de error
                    $(".modal-body").LoadingOverlay("hide"); // Oculta overlay ante error
                },
                function () { // Callback beforeSend
                    $(".modal-body").LoadingOverlay("show"); // Muestra el overlay de carga
                }
            );
        }
    } else {
        // Si faltan campos por completar, se muestra una alerta
        swal("Mensaje", "Es necesario completar todos los campos", "warning");
    }
});

// Al hacer clic en el botón de eliminación (dentro de la grilla), se solicita confirmación y se procede a eliminar el registro
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-danger"]', function () {
    var model = $(this).data("ecliente");
    var request = { IdP_Cli: model.IdP_Cli.toString() }; // Obtiene el identificador del registro a eliminar usando el atributo "ECliente"
    console.log("Request data: ", request); // Muestra en consola la información enviada
    // Muestra un mensaje de confirmación con swal antes de eliminar
    swal({
        title: "Mensaje",
        text: "¿Está seguro realizar la eliminación?",
        type: "warning",
        showCancelButton: true,     // Permite cancelar la acción
        confirmButtonColor: '#DD6B55',
        cancelButtonColor: '#d33',
        confirmButtonText: "Sí",    // Texto del botón confirmar
        cancelButtonText: "No",     // Texto del botón cancelar
        closeOnConfirm: false,
    }, function () { // Función callback al confirmar la eliminación
        AjaxPost("../PWJCliente.aspx/Eliminar", JSON.stringify(request),
            function (response) { // Callback de éxito
                console.log("Response received: ", response); // Log de la respuesta recibida
                if (response.estado) { // Si la eliminación es exitosa:
                    cargarDatos(); // Recarga la grilla de datos
                    swal.close();  // Cierra la alerta swal
                } else {
                    swal("Mensaje", "No se pudo eliminar el registro", "warning"); // Muestra advertencia si falla la eliminación
                }
            },
            function (error) { // Callback de error
                console.log("Error: ", error); // Log de error en consola
            },
            function () { // Callback de finalización
                console.log("Complete"); // Log para marcar la conclusión del proceso
            }
        );
    });
});

var table; // Variable global que almacenará la instancia de DataTable

// Se ejecuta al cargar el DOM
$(document).ready(function () {
    cargarDatos();    // Carga y muestra los datos en la grilla
    ObtenerRegi();    // Recupera y llena el dropdown de Regiones
    ObtenerProv();    // Recupera y llena el dropdown de Provincias
    ObtenerComu();    // Recupera y llena el dropdown de Comunas
    Filtrar();        // Configura los eventos de filtrado entre Región y Provincia
});

// Configura los eventos 'change' de los dropdowns de filtros
function Filtrar() {
    // Al cambiar la selección de la Región
    $("#ComboIngModReg").change(function () {
        var idReg = $(this).val(); // Obtiene el ID de la región seleccionada
        FiltrarReg(idReg);         // Llama a la función para filtrar provincias según la región
    });
    // Al cambiar la selección de la Provincia
    $("#ComboIngModPro").change(function () {
        var idPro = $(this).val(); // Obtiene el ID de la provincia seleccionada
        FiltrarPro(idPro);         // Llama a la función para filtrar comunas según la provincia
    });
}

// Carga los datos a la grilla
function cargarDatos() {
    // Si ya existe una instancia de DataTable en '#Grid', se destruye para reinicializarla
    if ($.fn.DataTable.isDataTable('#Grid')) {
        $('#Grid').DataTable().destroy();
    }
    // Limpia el contenido del cuerpo de la tabla
    $('#Grid tbody').html('');

    // Llama al método Ajax para obtener los datos (en este caso a PWJProv.aspx/Obtener)
    AjaxGet("../PWJProv.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay de carga
            // Si la respuesta es exitosa
            if (response.estado) {
                // Itera cada objeto obtenido para crear una fila en la tabla
                $.each(response.objeto, function (i, row) {
                    $("<tr>").append(
                        $("<td>").text(i + 1),                // Número de registro
                        $("<td>").text(row.Nombre),             // Nombre
                        $("<td>").text(row.Rut),                // RUT
                        $("<td>").text(row.Com.Nombre),         // Comuna
                        $("<td>").text(row.Pro.Nombre),         // Provincia
                        $("<td>").text(row.Reg.Nombre),         // Región
                        $("<td>").text(row.Direccion),          // Dirección
                        $("<td>").text(row.Tel),                // Teléfono
                        $("<td>").text(row.Email),              // Email
                        $("<td>").text(row.Giro),               // Giro
                        $("<td>").text(row.Descr),              // Descripción
                        $("<td>").append(                       // Acciones:
                            $("<button>")
                                .addClass("btn btn-sm btn-primary mr-1")
                                .text("Editar")
                                .attr("data-eprov", JSON.stringify(row)),
                            $("<button>")
                                .addClass("btn btn-sm btn-danger")
                                .text("Eliminar")
                                .attr("data-eprov", JSON.stringify(row)),
                        )
                    ).appendTo("#Grid tbody"); // Inserta la fila en el cuerpo de la tabla
                });
            }
            // Inicializa el DataTable con la opción responsive
            table = $('#Grid').DataTable({
                responsive: true
            });
        },
        function () {
            $(".card-body").LoadingOverlay("hide"); // Callback de error: oculta overlay en caso de fallo
        },
        function () {
            $(".card-body").LoadingOverlay("show"); // Callback beforeSend: muestra overlay mientras se carga la data
        }
    );
}

// Recupera y llena el dropdown de Regiones
function ObtenerRegi() {
    $("#ComboIngModReg").html(""); // Limpia las opciones existentes
    AjaxGet("../PWJLocRegi.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega la opción por defecto
            $("<option>").attr({ "value": "0" }).text("Seleccione Región").appendTo("#ComboIngModReg")
            if (response.estado) {
                // Llena el dropdown con cada región
                $.each(response.objeto, function (i, row) {
                    $("<option>").attr({ "value": row.IdReg })
                        .text(row.Nombre)
                        .appendTo("#ComboIngModReg");
                });
            }
        },
        function () {
            $(".card-body").LoadingOverlay("hide"); // Callback de error
        },
        function () {
            $(".card-body").LoadingOverlay("show"); // Callback beforeSend
        }
    );
}

// Recupera y llena el dropdown de Provincias
function ObtenerProv() {
    $("#ComboIngModPro").html(""); // Limpia las opciones existentes
    AjaxGet("../PWJLocProv.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega la opción por defecto para provincias
            $("<option>").attr({ "value": "0" }).text("Seleccione Provincia").appendTo("#ComboIngModPro")
            if (response.estado) {
                // Itera la lista obtenida y llena el dropdown
                $.each(response.objeto, function (i, row) {
                    $("<option>").attr({ "value": row.IdPro })
                        .text(row.Nombre)
                        .appendTo("#ComboIngModPro");
                });
            }
        },
        function () {
            $(".card-body").LoadingOverlay("hide"); // Callback de error
        },
        function () {
            $(".card-body").LoadingOverlay("show"); // Callback beforeSend
        }
    );
}

// Recupera y llena el dropdown de Comunas
function ObtenerComu() {
    $("#ComboIngModCom").html(""); // Limpia las opciones existentes en el dropdown de comunas
    AjaxGet("../PWJLocComu.aspx/Obtener",
        function (response) { // Callback de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay de carga
            // Agrega la opción predeterminada
            $("<option>").attr({ "value": "0" }).text("Seleccione Comuna").appendTo("#ComboIngModCom")
            if (response.estado) {
                // Itera y agrega cada comuna como opción
                $.each(response.objeto, function (i, row) {
                    $("<option>").attr({ "value": row.IdCom })
                        .text(row.Nombre)
                        .appendTo("#ComboIngModCom");
                });
            }
        },
        function () {
            $(".card-body").LoadingOverlay("hide"); // Callback de error
        },
        function () {
            $(".card-body").LoadingOverlay("show"); // Callback beforeSend
        }
    );
}

// Filtra provincias según el ID de la región seleccionado
function FiltrarReg(idReg) {
    $.ajax({
        type: "POST", // Método HTTP POST
        url: "PWJProv.aspx/FiltrarReg", // URL del WebMethod que filtra provincias por región
        data: JSON.stringify({ IdReg: idReg }), // Convierte el parámetro en JSON
        contentType: "application/json; charset=utf-8", // Especifica el tipo de contenido
        dataType: "json", // Se espera respuesta en JSON
        success: function (response) {
            var Provincias = response.d; // Obtiene la lista filtrada de provincias
            var comboIngModPro = $("#ComboIngModPro");
            comboIngModPro.empty(); // Limpia las opciones actuales del dropdown
            // Agrega cada provincia filtrada al dropdown
            $.each(Provincias, function (i, Provincia) {
                $("<option>").val(Provincia.IdPro)
                    .text(Provincia.Nombre)
                    .appendTo(comboIngModPro);
            });
        },
        error: function (error) {
            console.error("Error al obtener provincias:", error); // Registra errores en la consola
        }
    });
}

// Filtra comunas según el ID de la provincia seleccionado
function FiltrarPro(idPro) {
    $.ajax({
        type: "POST", // Método HTTP POST
        url: "PWJProv.aspx/FiltrarPro", // URL del WebMethod que filtra comunas por provincia
        data: JSON.stringify({ IdPro: idPro }), // Convierte el parámetro en JSON
        contentType: "application/json; charset=utf-8", // Especifica el tipo de contenido
        dataType: "json", // Se espera respuesta en JSON
        success: function (response) {
            var Comunas = response.d; // Obtiene la lista filtrada de comunas
            var comboIngModCom = $("#ComboIngModCom");
            comboIngModCom.empty(); // Limpia las opciones existentes del dropdown
            // Agrega cada comuna filtrada al dropdown
            $.each(Comunas, function (i, Comuna) {
                $("<option>").val(Comuna.IdCom)
                    .text(Comuna.Nombre)
                    .appendTo(comboIngModCom);
            });
        },
        error: function (error) {
            console.error("Error al obtener Comunas:", error); // Muestra el error en consola
        }
    });
}
// Aplica formateo a "Title Case" al texto ingresado en el input de "Nombre"
// y preserva la posición del cursor
$('#TextNom').on('input', function () {
    var text = $(this).val(); // Obtiene el texto actual
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Convierte cada palabra: primera letra en mayúscula, resto en minúscula
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });

    var cursorPosition = this.selectionStart; // Guarda posición actual del cursor
    $(this).val(titleCasedText);              // Actualiza el input formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición original
});

// Controla que sólo se permitan letras en el input "Nombre"
// Previene la entrada de dígitos y alerta al usuario
$('#TextNom').on('keypress', function (event) {
    if (event.key >= '0' && event.key <= '9') {
        event.preventDefault(); // Evita la acción de ingreso del dígito
        alert('Solo se permiten letras.');
    }
});

// Aplica formateo a "Title Case" al texto del input "Dirección"
$('#TextDire').on('input', function () {
    var text = $(this).val();
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });

    var cursorPosition = this.selectionStart; // Guarda la posición del cursor
    $(this).val(titleCasedText);              // Actualiza el input con el texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Aplica formateo a "Title Case" al texto del input "Giro"
$('#TextGir').on('input', function () {
    var text = $(this).val();
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });

    var cursorPosition = this.selectionStart; // Guarda posición del cursor
    $(this).val(titleCasedText);              // Actualiza el input con el nuevo formato
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Permite exclusivamente la entrada de números en el input "Teléfono"
// Permite teclas de retroceso u otras especiales (código 8 y 0)
$('#TextTel').on('keypress', function (event) {
    if (event.which < 48 || event.which > 57) { // Si no es un dígito (0-9)
        if (event.which !== 8 && event.which !== 0) { // Permite backspace u otras autorizadas
            event.preventDefault(); // Evita la entrada del caracter
            alert('Solo se permiten números.');
        }
    }
});

// Aplica formateo a "Title Case" al texto del input "Descripción"
$('#TextDes').on('input', function () {
    var text = $(this).val();
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });

    var cursorPosition = this.selectionStart; // Guarda posición del cursor
    $(this).val(titleCasedText);              // Actualiza el input con el texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición
});

// Cuando se hace clic en el botón "Editar" (dentro de la grilla)
// se recupera el objeto "EProv" asociado y se cargan los datos en el formulario del modal
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-primary mr-1"]', function () {
    var model = $(this).data("eprov"); // Recupera los datos del registro (objeto EProv)
    $("#textId").val(model.IdProv);    // Asigna el ID de la provincia
    $("#TextNom").val(model.Nombre);   // Asigna el nombre
    $("#TextRut").val(model.Rut);      // Asigna el RUT
    $("#ComboIngModReg").val(model.IdReg); // Selecciona la región asociada
    $("#ComboIngModPro").val(model.IdPro); // Selecciona la provincia asociada
    $("#ComboIngModCom").val(model.IdCom); // Selecciona la comuna asociada
    $("#TextDire").val(model.Direccion);   // Ingresa la dirección
    $("#TextTel").val(model.Tel);          // Ingresa el teléfono
    $("#TextEma").val(model.Email);        // Ingresa el email
    $("#TextGir").val(model.Giro);         // Ingresa el giro
    $("#TextDes").val(model.Descr);        // Ingresa la descripción
    $('#sidePanel').addClass('active');        // Muestra el sidepanel
});


// Al hacer clic en el botón "Nuevo", limpia el formulario y muestra el modal
$('#btnNuevo').on('click', function () {
    $("#textId").val(0);                            // Establece ID en 0 (nuevo registro)
    $("#TextNom").val("");                          // Limpia el nombre
    $("#TextRut").val("");                          // Limpia el RUT
    $("#ComboIngModReg").prop('selectedIndex', 0);  // Resetea el dropdown de región
    $("#ComboIngModPro").prop('selectedIndex', 0);  // Resetea el dropdown de provincia
    $("#ComboIngModCom").prop('selectedIndex', 0);  // Resetea el dropdown de comuna
    $("#TextDire").val("");                         // Limpia la dirección
    $("#TextTel").val("");                          // Limpia el teléfono
    $("#TextEma").val("");                          // Limpia el email
    $("#TextGir").val("");                          // Limpia el giro
    $("#TextDes").val("");                          // Limpia la descripción
    $('#sidePanel').addClass('active');        // Muestra el sidepanel
});

// Evento: Al hacer click en el botón de cerrar (la "X") del panel lateral
$('#btnCloseSidePanel').on('click', function () {
    // Remueve la clase "active" para ocultar el panel lateral
    $('#sidePanel').removeClass('active');
});
// Al hacer clic en el botón "Guardar Cambios"
// se valida que todos los campos estén completos y se configura el objeto request
// para insertar o actualizar según corresponda
$('#btnGuardarCambios').on('click', function () {
    var camposvacios = false;
    var fields = $(".model").serializeArray(); // Serializa los campos del formulario con clase "model"

    // Verifica que no haya ningún campo vacío
    $.each(fields, function (i, field) {
        if (!field.value) { // Si un campo está vacío
            camposvacios = true;
            return false; // Rompe el ciclo
        }
    });

    if (!camposvacios) {
        // Construye el objeto request con los datos ingresados en el formulario
        var request = {
            obj: {
                IdProv: parseInt($("#textId").val()),  // Convierte a entero el ID de la provincia
                Nombre: $("#TextNom").val(),
                Rut: $("#TextRut").val(),
                IdCom: $("#ComboIngModCom").val(),
                Direccion: $("#TextDire").val(),
                Tel: $("#TextTel").val(),
                Email: $("#TextEma").val(),
                Giro: $("#TextGir").val(),
                Descr: $("#TextDes").val(),
                IdReg: $("#ComboIngModReg").val(),
                IdPro: $("#ComboIngModPro").val(),
            }
        };

        // Si el ID es 0, se considera un registro nuevo
        if (parseInt($("#textId").val()) == 0) {
            // Actualiza los dropdowns y filtros antes de ingresar
            ObtenerRegi();
            ObtenerProv();
            ObtenerComu();
            Filtrar();

            // Envía la solicitud para ingresar el registro
            AjaxPost("../PWJProv.aspx/Ingresar", JSON.stringify(request),
                function (response) {
                    $(".modal-body").LoadingOverlay("hide");
                    if (response.estado) {
                        cargarDatos();                // Recarga la grilla con los nuevos datos
                        $('#sidePanel').removeClass('active'); // Oculta el sidepanel
                        swal("Ingreso fue realizado correctamente");
                    } else {
                        swal("oops!", "Seleccione un registro valido", "warning");
                    }
                },
                function () {
                    $(".modal-body").LoadingOverlay("hide");
                },
                function () {
                    $(".modal-body").LoadingOverlay("show");
                }
            );
        } else { // Si el registro ya existe, actualiza el registro
            AjaxPost("../PWJProv.aspx/Actualizar", JSON.stringify(request),
                function (response) {
                    $(".modal-body").LoadingOverlay("hide");
                    if (response.estado) {
                        cargarDatos();                // Recarga la grilla con la actualización
                        $('#sidePanel').removeClass('active'); // Oculta el sidepanel
                        swal("Actualización fue realizado correctamente");
                    } else {
                        swal("oops!", "Seleccione un registro valido", "warning");
                    }
                },
                function () {
                    $(".modal-body").LoadingOverlay("hide");
                },
                function () {
                    $(".modal-body").LoadingOverlay("show");
                }
            );
        }
    } else {
        // Si algún campo está vacío, muestra un mensaje de advertencia
        swal("Mensaje", "Es necesario completar todos los campos", "warning");
    }
});

// Al hacer clic en el botón "Eliminar" de un registro en la grilla,
// se solicita confirmación y, en caso afirmativo,
// se envía la solicitud para eliminar el registro correspondiente.
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-danger"]', function () {
    var model = $(this).data("eprov");
    var request = { IdProv: model.IdProv.toString() }; // Prepara la solicitud con el ID del registro a eliminar
    console.log("Request data: ", request);

    // Muestra un cuadro de diálogo de confirmación usando swal
    swal({
        title: "Mensaje",
        text: "¿Está seguro realizar la eliminación?",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: '#DD6B55',
        cancelButtonColor: '#d33',
        confirmButtonText: "Sí",
        cancelButtonText: "No",
        closeOnConfirm: false,
    }, function () {
        console.log("Confirm clicked");
        // Envía la solicitud de eliminación vía Ajax
        AjaxPost("../PWJProv.aspx/Eliminar", JSON.stringify(request),
            function (response) {
                console.log("Response received: ", response);
                if (response.estado) {
                    cargarDatos(); // Recarga la grilla si la eliminación es exitosa
                    swal.close();  // Cierra la alerta de swal
                } else {
                    swal("Mensaje", "No se pudo eliminar el registro", "warning");
                }
            },
            function (error) {
                console.log("Error: ", error);
            },
            function () {
                console.log("Complete");
            }
        );
    });
});


var table; // Variable global para almacenar la instancia de DataTable

// Al cargar el DOM se ejecutan las siguientes funciones:
$(document).ready(function () {
    cargarDatos();    // Carga los datos y los muestra en la grilla (#Grid)
    ObtenerRegi();    // Carga el dropdown de Regiones
    ObtenerProv();    // Carga el dropdown de Provincias
    // Cuando cambia el valor del dropdown de Región:
    $("#ComboIngModReg").change(function () {
        var idReg = $(this).val(); // Obtiene el ID de la región seleccionada
        Filtrar(idReg);            // Llama a la función de filtrado pasando el ID
    });
});

// Función para cargar los datos de comunas en la tabla
function cargarDatos() {

    // Verifica si ya se ha inicializado DataTable en "#Grid"
    if ($.fn.DataTable.isDataTable('#Grid')) {
        $('#Grid').DataTable().destroy(); // Si existe, destruye la instancia para reinicializarla
    }
    $('#Grid tbody').html(''); // Limpia el contenido del cuerpo de la tabla

    // Realiza una solicitud Ajax GET al WebMethod "Obtener" en PWJLocComu.aspx
    AjaxGet("../PWJLocComu.aspx/Obtener",
        function (response) { // Callback en caso de éxito
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay de carga
            if (response.estado) {
                // Itera cada registro obtenido y lo muestra en una nueva fila
                $.each(response.objeto, function (i, row) {
                    $("<tr>").append(
                        $("<td>").text(i + 1),                // Número de registro (índice + 1)
                        $("<td>").text(row.Nombre),             // Nombre de la comuna
                        $("<td>").text(row.Pro.Nombre),         // Nombre de la provincia asociada
                        $("<td>").text(row.Reg.Nombre),         // Nombre de la región asociada
                        $("<td>").append(                       // Crea el contenedor para los botones de acción:
                            $("<button>")
                                .addClass("btn btn-sm btn-primary mr-1")
                                .text("Editar")
                                .data("ELocCom", row),        // Asocia los datos completos del registro
                            $("<button>")
                                .addClass("btn btn-sm btn-danger")
                                .text("Eliminar")
                                .data("ELocCom", row.IdCom)     // Asocia únicamente el ID de la comuna
                        )
                    ).appendTo("#Grid tbody"); // Inserta la fila en el cuerpo de la tabla
                });
            }
            // Inicializa DataTable para la tabla con opciones responsive
            table = $('#Grid').DataTable({
                responsive: true
            });
        },
        function () { // Callback de error de Ajax
            $(".card-body").LoadingOverlay("hide"); // Oculta overlay en caso de error
        },
        function () { // Callback beforeSend
            $(".card-body").LoadingOverlay("show"); // Muestra el overlay de carga mientras se procesa la solicitud
        }
    );
}

// Función para llenar el dropdown de Regiones
function ObtenerRegi() {
    $("#ComboIngModReg").html(""); // Limpia las opciones existentes
    // Solicita a PWJLocRegi.aspx/Obtener la lista de regiones
    AjaxGet("../PWJLocRegi.aspx/Obtener",
        function (response) {
            $(".card-body").LoadingOverlay("hide"); // Oculta el overlay
            // Agrega la opción predeterminada
            $("<option>").attr({ "value": "0" }).text("Seleccione Región").appendTo("#ComboIngModReg")
            if (response.estado) {
                // Itera cada región y la añade al dropdown
                $.each(response.objeto, function (i, row) {
                    $("<option>")
                        .attr({ "value": row.IdReg })
                        .text(row.Nombre)
                        .appendTo("#ComboIngModReg");
                });
            }
        },
        function () { // Callback de error
            $(".card-body").LoadingOverlay("hide");
        },
        function () { // Callback beforeSend
            $(".card-body").LoadingOverlay("show");
        }
    );
}

// Función para llenar el dropdown de Provincias
function ObtenerProv() {
    $("#ComboIngModPro").html(""); // Limpia las opciones existentes
    // Solicita a PWJLocProv.aspx/Obtener la lista de provincias
    AjaxGet("../PWJLocProv.aspx/Obtener",
        function (response) {
            $(".card-body").LoadingOverlay("hide");
            // Agrega la opción predeterminada
            $("<option>").attr({ "value": "0" }).text("Seleccione Provincia").appendTo("#ComboIngModPro")
            if (response.estado) {
                // Itera cada provincia y la añade al dropdown
                $.each(response.objeto, function (i, row) {
                    $("<option>")
                        .attr({ "value": row.IdPro })
                        .text(row.Nombre)
                        .appendTo("#ComboIngModPro");
                });
            }
        },
        function () {
            $(".card-body").LoadingOverlay("hide");
        },
        function () {
            $(".card-body").LoadingOverlay("show");
        }
    );
}

// Función para filtrar las provincias según el ID de la región seleccionado
function Filtrar(idReg) {
    $.ajax({
        type: "POST", // Método POST
        url: "PWJLocComu.aspx/Filtrar", // URL del WebMethod que realiza el filtrado
        data: JSON.stringify({ IdReg: idReg }), // Envía el ID de la región en formato JSON
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var provincias = response.d; // Obtiene la lista de provincias filtradas
            var comboIngModPro = $("#ComboIngModPro");
            comboIngModPro.empty(); // Limpia las opciones actuales del dropdown de provincias
            // Añade cada opción de provincia al dropdown
            $.each(provincias, function (i, provincia) {
                $("<option>")
                    .val(provincia.IdPro)
                    .text(provincia.Nombre)
                    .appendTo(comboIngModPro);
            });
        },
        error: function (error) {
            console.error("Error al obtener provincias:", error); // Muestra error en la consola
        }
    });
}

// Evento: Convierte el texto ingresado en "TextIngMod" a Title Case, preservando la posición del cursor
$('#TextIngMod').on('input', function () {
    var text = $(this).val(); // Obtiene el valor actual
    var titleCasedText = text.replace(/\w\S*/g, function (txt) {
        // Cambia cada palabra: primera letra en mayúscula, resto en minúscula
        return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
    });
    var cursorPosition = this.selectionStart; // Guarda la posición actual del cursor
    $(this).val(titleCasedText); // Actualiza el input con el texto formateado
    this.setSelectionRange(cursorPosition, cursorPosition); // Restaura la posición del cursor
});

// Evento: Evita que se ingresen dígitos en el input "TextIngMod"
$('#TextIngMod').on('keypress', function (event) {
    if (event.key >= '0' && event.key <= '9') { // Si se presiona un dígito
        event.preventDefault(); // Evita la entrada del dígito
        alert('Solo se permiten letras.'); // Muestra alerta
    }
});

// Al hacer clic en el botón "Editar" en una fila de la grilla:
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-primary mr-1"]', function () {
    var model = $(this).data("ELocCom"); // Recupera el objeto asociado al registro
    $("#textId").val(model.IdCom);       // Asigna el ID de la comuna al campo oculto
    $("#TextIngMod").val(model.Nombre);    // Asigna el nombre de la comuna
    $("#ComboIngModReg").val(model.IdReg);   // Selecciona la región correspondiente
    $("#ComboIngModPro").val(model.IdPro);   // Selecciona la provincia correspondiente
    $('#sidePanel').addClass('active');      // Muestra el panel lateral (agregar/editar)
});

// Al hacer clic en el botón "Nuevo":
$('#btnNuevo').on('click', function () {
    $("#textId").val(0);                         // Establece el ID en 0 (nuevo registro)
    $("#TextIngMod").val("");                    // Limpia el campo del nombre
    $("select#ComboIngModPro").prop('selectedIndex', 0); // Resetea el dropdown de provincias
    $("select#ComboIngModReg").prop('selectedIndex', 0); // Resetea el dropdown de regiones
    $('#sidePanel').addClass('active');          // Muestra el panel lateral
});

// Evento: Cierra el panel lateral al hacer clic en la "X"
$('#btnCloseSidePanel').on('click', function () {
    $('#sidePanel').removeClass('active'); // Oculta el panel lateral removiendo la clase "active"
});

// Evento: Al hacer clic en "Guardar Cambios" en el panel lateral
$('#btnGuardarCambios').on('click', function () {
    var camposvacios = false;
    // Serializa los campos del formulario con la clase "model"
    var fields = $(".model").serializeArray();
    $.each(fields, function (i, field) {
        if (!field.value) { // Si algún campo está vacío, marca la variable
            camposvacios = true;
            return false; // Rompe la iteración
        }
    });
    if (!camposvacios) {
        // Construye el objeto request con los datos del formulario
        var request = {
            obj: {
                IdCom: parseInt($("#textId").val()),          // ID de la comuna (entero)
                Nombre: $("#TextIngMod").val(),               // Nombre de la comuna
                IdPro: $("#ComboIngModPro").val(),            // Provincia seleccionada
                IdReg: $("#ComboIngModReg").val()             // Región seleccionada
            }
        }
        // Si el ID es 0, es un nuevo registro
        if (parseInt($("#textId").val()) == 0) {
            AjaxPost("../PWJLocComu.aspx/Ingresar", JSON.stringify(request),
                function (response) {
                    $(".modal-body").LoadingOverlay("hide");
                    if (response.estado) {
                        cargarDatos();               // Recarga la grilla
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
        } else { // Si no es nuevo, se actualiza el registro existente
            AjaxPost("../PWJLocComu.aspx/Actualizar", JSON.stringify(request),
                function (response) {
                    $(".modal-body").LoadingOverlay("hide");
                    if (response.estado) {
                        cargarDatos();               // Recarga la grilla con la actualización
                        $('#sidePanel').removeClass('active'); // Oculta el sidepanel
                        swal("Actualización fue realizado correctamente");
                        // Se llama a Filtrar(idReg) para actualizar el dropdown, aunque 
                        // "idReg" no esté definido en este ámbito (posible error)
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
        swal("Mensaje", "Es necesario completar todos los campos", "warning");
    }
});

// Evento: Al hacer clic en el botón "Eliminar" de una fila en la grilla
$('#Grid tbody').on('click', 'button[class="btn btn-sm btn-danger"]', function () {
    // Prepara el objeto para la eliminación, obteniendo el ID de la comuna
    var request = { IdCom: String($(this).data("ELocCom")) };
    console.log("Request data: ", request);
    // Muestra un cuadro de diálogo de confirmación con swal
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
        // Envía la solicitud para eliminar la comuna
        AjaxPost("../PWJLocComu.aspx/Eliminar", JSON.stringify(request),
            function (response) {
                console.log("Response received: ", response);
                if (response.estado) {
                    cargarDatos(); // Recarga la grilla tras la eliminación
                    swal.close();  // Cierra la alerta swal
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

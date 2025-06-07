$('#btnIniciarSesion').click(function () { // Al hacer click en el botón de iniciar sesión
    var nombre = $("#username").val(); // Se obtiene el usuario
    var pass = $("#password").val(); // Se obtiene la contraseña

    $.ajax({ // Se envían los datos al servidor via AJAX
        type: "POST", // Usamos el método POST
        url: "../WPLogin.aspx/Verificar", // A dónde mandar la info para verificar el usuario
        data: JSON.stringify({ Nombre: nombre, Pass: pass }), // Se empaquetan los datos en JSON
        contentType: "application/json; charset=utf-8", // Especificamos el tipo de contenido
        dataType: "json", // Se espera una respuesta JSON
        beforeSend: function () {
            $.LoadingOverlay("show"); // Se muestra un indicador de carga
        },
        success: function (response) {
            $.LoadingOverlay("hide"); // Se oculta el indicador al recibir respuesta
            if (response.d.estado) {
                window.location.href = 'WPInicio.aspx'; // Si el usuario es válido, se redirige
            } else {
                swal("oops!", "No se encontró el usuario", "warning"); // Si no, se muestra aviso
            }
        },
        error: function () {
            $.LoadingOverlay("hide"); // Se oculta la carga en caso de error
            swal("Error", "Hubo un problema con la solicitud", "error"); // Se muestra un error
        }
    });

    return false; // Evita que la página se recargue
});

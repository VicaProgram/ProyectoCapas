function AjaxPost(url, data, funcionexito, funcionerror, funcionmientras) // Función para hacer una solicitud POST vía AJAX
{
    jQuery.ajax({
        async: true, // Se ejecuta de forma asíncrona
        url: url, // URL a la que se envían los datos
        type: "POST", // Método POST para enviar datos
        dataType: "json", // Se espera recibir JSON
        data: data, // Los datos que se envían
        contentType: "application/json; charset=utf-8", // Especifica que se envía JSON en UTF-8
        success: function (data) {
            funcionexito(data.d); // Si todo sale bien, se llama a la función de éxito con data.d
        },
        error: function (er) {
            funcionerror(); // Si hay error, se ejecuta la función de error
        },
        beforeSend: function () {
            funcionmientras(); // Antes de enviar, se llama a la función "mientras" (para mostrar algo, por ejemplo)
        },
    });
}
function AjaxGet(url, funcionexito, funcionerror, funcionmientras)// Función para hacer una solicitud GET vía AJAX
{
    jQuery.ajax({
        async: true, // Se ejecuta de forma asíncrona
        url: url, // URL de la petición
        type: "GET", // Método GET para obtener datos
        dataType: "json", // Se espera un JSON como respuesta
        contentType: "application/json; charset=utf-8", // Se especifica el tipo de contenido
        success: function (data) {
            funcionexito(data.d); // Llama a la función de éxito con data.d si todo va bien
        },
        error: function (er) {
            funcionerror(); // Llama a la función de error si hay algún fallo
        },
        beforeSend: function () {
            funcionmientras(); // Antes de enviar, se ejecuta la función "mientras"
        },
    });
}
function ObtenerFecha()// Función para obtener la fecha actual formateada como "dd-mm-yyyy"
{
    var d = new Date(); // Crea una nueva fecha con el momento actual
    var month = d.getMonth() + 1; // Los meses empiezan en 0, se suma 1 para el formato correcto
    var day = d.getDate(); // Obtiene el día del mes
    var output = (('' + day).length < 2 ? '0' : '') + day + '-' + (('' + month).length < 2 ? '0' : '') + month + '-' + d.getFullYear();// Formatea el día y el mes agregando cero al inicio si es necesario y une todo en el formato dd-mm-yyyy
    return output; // Devuelve la fecha formateada
}
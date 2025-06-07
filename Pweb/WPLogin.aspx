<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WPLogin.aspx.cs" Inherits="Pweb.WPLogin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Hoja de estilos de Bootstrap -->
    <link href="Assets/Plugins/bootstrap.4.5.2/bootstrap.min.css" rel="stylesheet" />
    <!-- Estilos personalizados para el login -->
    <link href="css/IniciarSesion/Styles.css" rel="stylesheet" />
    <!-- Librerías de íconos -->
    <link href="Assets/Plugins/Simple_Line_Icons/simple-line-icons.min.css" rel="stylesheet" />
    <link href="Assets/Plugins/bootstrap-icons-1.2.2/font/bootstrap-icons.css" rel="stylesheet" />
    <link href="css/IniciarSesion/Nav.css" rel="stylesheet"/>
    <!-- jQuery y JS de Bootstrap -->
    <script src="Assets/Plugins/jquery/jquery.3.5.1.min.js"></script>
    <script src="Assets/Plugins/bootstrap.4.5.2/bootstrap.min.js"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <!-- Contenedor del formulario de login -->
    <div class="registration-form">
        <form>
            <!-- Ícono del formulario -->
            <div class="form-icon">
                <span><i class="bi bi-person-fill"></i></span>
            </div>
            <!-- Campo para el usuario -->
            <div class="form-group">
                <input type="text" class="form-control item" id="username" placeholder="Usuario"/>
            </div>
            <!-- Campo para la contraseña -->
            <div class="form-group">
                <input type="password" class="form-control item" id="password" placeholder="Contraseña"/>
            </div>
            <!-- Botón para iniciar sesión -->
            <div class="form-group">
                <button id="btnIniciarSesion" type="button" class="btn btn-block create-account">Iniciar Sesión</button>
            </div>
        </form>
    </div>

    <!-- Scripts personalizados para login y utilidades -->
    <script src="JS/Login.js"></script>
    <script src="JS/Utilidades.js"></script>
    <!-- Plugin para mostrar un overlay de carga -->
    <script src="Assets/Plugins/loadingoverlay/loadingoverlay.js"></script>
    <!-- SweetAlert para alertas bonitas -->
    <link href="Assets/Plugins/sweetalert2/sweetalert.css" rel="stylesheet" />
    <script src="Assets/Plugins/sweetalert2/sweetalert.js"></script>
</body>
</html>

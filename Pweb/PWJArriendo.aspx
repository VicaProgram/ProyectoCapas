<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJArriendo.aspx.cs" Inherits="Pweb.PWJArriendo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Bloque de contenido que se inyectará en el ContentPlaceHolder 'head' definido en la MasterPage.
         Normalmente se usan para insertar estilos, scripts u otros elementos para el <head> del HTML. -->

    <link href="/css/IniciarSesion/Inicio.css" rel="stylesheet" />
    <!-- Enlace a la hoja de estilos 'Inicio.css' que se encuentra en la ruta '/css/IniciarSesion/'.
         Esto permite aplicar estilos específicos a esta página. -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Bloque de contenido que se inyectará en el ContentPlaceHolder llamado 'ContentPlaceHolder1'
         definido en la MasterPage. Aquí se coloca el contenido principal de la página.
         Actualmente, este bloque está vacío, lo que significa que no se muestra contenido adicional en la sección principal. -->
</asp:Content>
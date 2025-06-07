<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WPInicio.aspx.cs" Inherits="Pweb.WPInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <!-- Bloque de contenido que se insertará en la sección "head" de la MasterPage -->
    <link href="/css/IniciarSesion/Inicio.css" rel="stylesheet" />
    <!-- Enlace a la hoja de estilos "Inicio.css" que contiene estilos para esta página -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!-- Bloque principal de contenido que se insertará en el ContentPlaceHolder1 definido en la MasterPage -->

  <!-- HERO BANNER -->
  <section class="hero-banner">
    <!-- Sección que actúa como banner principal del sitio -->
    <div class="container">
      <!-- Contenedor central para restringir el ancho y alinear el contenido -->
      <div class="content">
        <!-- Contenedor específico para el contenido del banner -->
        <h1>Arriendos Express</h1>
        <!-- Título principal del banner -->
        <p>Encuentra y arrienda lo que necesitas, de forma rápida y segura.</p>
        <!-- Párrafo descriptivo del banner -->
      </div>
    </div>
  </section>

  <!-- BENEFITS SECTION -->
  <section class="benefits">
    <!-- Sección que muestra los beneficios o características del servicio -->
    <div class="container">
      <!-- Contenedor central para el contenido de los beneficios -->
      <div class="row text-center">
        <!-- Fila de Bootstrap con alineación de texto centrado -->
        <div class="col-md-4">
          <!-- Columna que ocupa un tercio del ancho en dispositivos medianos (Bootstrap: 4 de 12 columnas) -->
          <div class="benefit-icon">&#128176;</div>
          <!-- Ícono de beneficio (usando un carácter Unicode, en este caso el símbolo de dinero) -->
          <h4>Precios Competitivos</h4>
          <!-- Título del beneficio -->
          <p>Tarifas accesibles para todos nuestros productos.</p>
          <!-- Descripción del beneficio -->
        </div>
        <div class="col-md-4">
          <!-- Segunda columna de beneficios -->
          <div class="benefit-icon">&#9200;</div>
          <!-- Ícono de beneficio (carácter Unicode para reloj) -->
          <h4>Entrega Rápida</h4>
          <!-- Título del beneficio -->
          <p>Recibe lo que necesitas en el menor tiempo posible.</p>
          <!-- Descripción del beneficio -->
        </div>
        <div class="col-md-4">
          <!-- Tercera columna de beneficios -->
          <div class="benefit-icon">&#128222;</div>
          <!-- Ícono de beneficio (carácter Unicode para teléfono móvil) -->
          <h4>Soporte 24/7</h4>
          <!-- Título del beneficio -->
          <p>Asistencia y ayuda en cualquier momento, para que nunca te quedes sin servicio.</p>
          <!-- Descripción del beneficio -->
        </div>
      </div>
    </div>
  </section>

  <!-- FOOTER -->
  <footer class="text-center">
    <!-- Pie de página con texto centrado -->
    <div class="container">
      <!-- Contenedor central para el footer -->
      <p>&copy; 2025 Arriendos Express. Todos los derechos reservados.</p>
      <!-- Texto de copyright -->
      <p>Contacto: contacto@arriendosexpress.com | Tel: 1234-5678</p>
      <!-- Información de contacto -->
    </div>
  </footer>
<!-- Fin del bloque de contenido principal -->
</asp:Content>


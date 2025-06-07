<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJLocProv.aspx.cs" Inherits="Pweb.PWJLocProv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <!-- Bloque de contenido para la sección "head". Aquí se pueden incluir estilos o scripts adicionales -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!-- Contenido principal de la página -->

  <!-- Inicio del Card que muestra la información sobre Provincias -->
  <div class="row">
    <div class="col-sm-12">
      <div class="card" style="border: none; box-shadow: 0px 4px 12px rgba(0,0,0,0.1);">
        <!-- Encabezado del Card con fondo blanco, texto oscuro y borde izquierdo verde -->
        <div class="card-header" style="background-color: #ffffff; color: #2c4838; border-left: 5px solid #4CAF50; border-top-left-radius: 10px; border-top-right-radius: 10px;">
          Información sobre Provincias
        </div>
        <!-- Cuerpo del Card -->
        <div class="card-body">
          <div class="row">
            <div class="col-sm-2">
              <!-- Botón "Nuevo": con fondo blanco, borde y texto verde, redondeado -->
              <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                Nuevo
              </button>
            </div>
          </div>
          <hr /> <!-- Separador horizontal -->
          <div class="row mt-3"> <!-- Fila con margen superior para la tabla -->
            <div class="col-sm-12">
              <!-- Tabla para listar las Provincias -->
              <table id="Grid" class="table table-striped table-bordered nowrap" style="width: 100%">
                <!-- Encabezado de la tabla con fondo oscuro y letras blancas -->
                <thead style="background-color: #2c4838; color: #FFFFFF;">
                  <tr>
                    <th>#</th>         <!-- Columna índice -->
                    <th>Provincia</th>   <!-- Columna para nombre de la provincia -->
                    <th>Región</th>      <!-- Columna para nombre de la región asociada -->
                    <th>Acciones</th>    <!-- Columna para botones de acción (Editar, Eliminar) -->
                  </tr>
                </thead>
                <tbody>
                  <!-- Las filas se inyectarán dinámicamente mediante JavaScript -->
                </tbody>
              </table>
            </div>
          </div>
        </div>
        <!-- Pie del Card con fondo claro y bordes redondeados -->
        <div class="card-footer" style="background-color: #f8f9fa; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
        </div>
      </div>
    </div>
  </div>
  <!-- Fin del Card principal -->

  <!-- Side Panel para Agregar/Editar Provincias -->
  <div id="sidePanel" class="side-panel">
    <!-- Panel lateral oculto inicialmente; se mostrará agregando la clase "active" -->
    <div class="side-panel-content">
      <!-- Botón de cerrar ("X") en la esquina superior derecha del panel -->
      <button id="btnCloseSidePanel" class="close-btn">X</button>
        <h5 class="modal-title" id="exampleModalLabel">Provincia</h5>
      <form>
        <!-- Campo oculto para almacenar el ID de la Provincia (0 para nuevos registros) -->
        <input id="textId" class="model" name="IdPro" value="0" type="hidden" />
        <div class="form-group">
          <!-- Etiqueta y campo de texto para el nombre de la Provincia -->
          <label for="TextIngMod" class="col-form-label">Nombre:</label>
          <input type="text" class="form-control form-control-sm model" id="TextIngMod" name="Nombre">
        </div>
        <div class="form-group">
          <!-- Etiqueta y dropdown para seleccionar la Región a la que pertenece la Provincia -->
          <label for="ddlRegiones" class="col-form-label">Región:</label>
          <select id="ddlRegiones" class="form-control form-control-sm model" name="IdReg">
            <option value="0">Seleccione...</option> <!-- Opción predeterminada -->
          </select>
        </div>
        <!-- Botón para guardar los cambios: insertado o actualizado -->
        <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary" style="background-color: #4CAF50; border-color: #4CAF50; border-radius: 20px;">
          Guardar Cambios
        </button>
      </form>
    </div>
  </div>
  <!-- Fin del Side Panel -->

  <!-- Inclusión del archivo JavaScript que contiene la lógica para las Provincias -->
  <script src="JS/LocProv.js"></script>
</asp:Content>

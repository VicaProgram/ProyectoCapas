<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJLocRegi.aspx.cs" Inherits="Pweb.PWJLocRegi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Inicio del bloque de contenido para el head -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Inicio del bloque de contenido principal -->
    <!-- Card principal para la información sobre Regiones -->
    <div class="row">
        <!-- Inicio de una fila Bootstrap -->
        <div class="col-sm-12">
            <!-- Columna que ocupa todo el ancho en pantallas pequeñas y superiores -->
            <div class="card" style="border: none; box-shadow: 0px 4px 12px rgba(0,0,0,0.1); border-radius: 10px;">
                <!-- Card sin borde, con sombra y bordes redondeados -->
                <!-- Encabezado del Card -->
                <div class="card-header" style="background-color: #ffffff; color: #2c4838; border-left: 5px solid #4CAF50; border-top-left-radius: 10px; border-top-right-radius: 10px;">
                    Información sobre Regiones 
                    <!-- Título del Card -->
                </div>
                <!-- Cuerpo del Card -->
                <div class="card-body">
                    <div class="row">
                        <!-- Fila para el botón "Nuevo" -->
                        <div class="col-sm-2">
                            <!-- Columna para el botón "Nuevo" -->
                            <!-- Botón "Nuevo" para abrir el panel lateral -->
                            <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                                Nuevo 
                                <!-- Texto del botón -->
                            </button>
                        </div>
                    </div>
                    <hr />
                    <!-- Separador horizontal -->
                    <div class="row mt-3">
                        <!-- Fila para la tabla con margen superior -->
                        <div class="col-sm-12">
                            <!-- Columna completa para la tabla -->
                            <!-- Tabla para listar las Regiones -->
                            <table id="Grid" class="table table-striped table-bordered nowrap" style="width: 100%">
                                <thead style="background-color: #2c4838; color: #FFFFFF;">
                                    <!-- Encabezado de la tabla con fondo oscuro y texto blanco -->
                                    <tr>
                                        <th>#</th>
                                        <!-- Columna de índice -->
                                        <th>Región</th>
                                        <!-- Columna con el nombre de la Región -->
                                        <th>Acciones</th>
                                        <!-- Columna para acciones (botones) -->
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- Se inyectarán las filas dinámicamente mediante JavaScript -->
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Pie del Card -->
                <div class="card-footer" style="background-color: #f8f9fa; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
                    <!-- Pie del Card con fondo claro y bordes redondeados -->
                </div>
            </div>
        </div>
    </div>

    <!-- Side Panel para Agregar/Editar Regiones -->
    <div id="sidePanel" class="side-panel">
        <!-- Panel lateral oculto inicialmente -->
        <div class="side-panel-content">
            <!-- Contenedor interno del panel lateral -->
            <!-- Botón de cerrar ("X") posicionado en la esquina superior derecha -->
            <button id="btnCloseSidePanel" class="close-btn">X</button>
            <!-- Botón para cerrar el panel lateral -->
            <h5 class="modal-title" id="exampleModalLabel">Region</h5>
            <form>
                <!-- Inicio del formulario para agregar/editar una Región -->
                <!-- Campo oculto para almacenar el ID de la Región (0 para nuevo) -->
                <input id="textId" class="model" name="IdReg" value="0" type="hidden" />
                <div class="form-group">
                    <!-- Grupo de formulario para el campo Nombre -->
                    <label for="TextIngMod" class="col-form-label">Nombre:</label>
                    <!-- Etiqueta del campo -->
                    <input type="text" class="form-control form-control-sm model" id="TextIngMod" name="Nombre">
                    <!-- Campo de texto para el nombre -->
                </div>
                <!-- Botón para guardar los cambios en el panel lateral -->
                <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary" style="background-color: #4CAF50; border-color: #4CAF50; border-radius: 20px;">
                    Guardar Cambios 
                    <!-- Texto del botón -->
                </button>
            </form>
            <!-- Fin del formulario -->
        </div>
    </div>
    <script src="JS/LocRegi.js"></script>
    <!-- Inclusión del archivo JavaScript con la lógica de la página -->
    <!-- Fin del bloque de contenido principal -->
</asp:Content>

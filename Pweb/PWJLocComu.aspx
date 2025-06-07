<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJLocComu.aspx.cs" Inherits="Pweb.PWJLocComu" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <!-- Contenido para la sección <head> del MasterPage (actualmente vacío) -->
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenido principal de la página -->
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <!-- Encabezado de la tarjeta -->
                <div class="card-header">
                    Información sobre Comunas
                </div>
                <!-- Cuerpo de la tarjeta -->
                <div class="card-body">
                    <div class="row">
                        <div class="col-sm-2">
                            <!-- Botón "Nuevo" para agregar una nueva comuna -->
                            <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                                Nuevo
                            </button>
                        </div>
                    </div>
                    <hr />
                    <div class="row mt-3">
                        <div class="col-sm-12">
                            <!-- Tabla para listar las comunas; se cargarán dinámicamente las filas en el <tbody> -->
                            <table id="Grid" class="table table-striped table-bordered nowrap" style="width: 100%">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Comuna</th>
                                        <th>Provincia</th>
                                        <th>Región</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- Aquí se insertarán las filas con los datos de cada comuna -->
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Pie de la tarjeta, con estilo para un fondo claro y bordes redondeados en la parte inferior -->
                <div class="card-footer" style="background-color: #f8f9fa; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
                </div>
            </div>
        </div>
    </div>
    
    <!-- Side Panel para Agregar/Editar (panel lateral oculto inicialmente) -->
    <div id="sidePanel" class="side-panel">
        <!-- Contenedor del panel lateral -->
        <div class="side-panel-content">
            <!-- Botón para cerrar el panel, ubicado en la esquina superior derecha -->
            <button id="btnCloseSidePanel" class="close-btn">X</button>
            <!-- Título del panel -->
            <h5 class="modal-title" id="exampleModalLabel">Comuna</h5>
            <form>
                <div class="form-group">
                    <!-- Dropdown para seleccionar la Región a la que pertenece la comuna -->
                    <label for="ComboIngModReg" class="col-form-label">Región:</label>
                    <select id="ComboIngModReg" class="form-control form-control-sm model" name="IdReg">
                        <option value="0">Seleccione...</option>
                        <!-- Las demás opciones se cargarán dinámicamente -->
                    </select>
                </div>
                <div class="form-group">
                    <!-- Dropdown para seleccionar la Provincia asociada a la comuna -->
                    <label for="ComboIngModPro" class="col-form-label">Provincia:</label>
                    <select id="ComboIngModPro" class="form-control form-control-sm model" name="IdPro">
                        <option value="0">Seleccione...</option>
                        <!-- Las opciones se cargarán dinámicamente -->
                    </select>
                </div>
                <!-- Campo oculto para almacenar el ID de la Comuna -->
                <input id="textId" class="model" name="IdCom" value="0" type="hidden" />
                <div class="form-group">
                    <!-- Campo para ingresar o mostrar el Nombre de la Comuna -->
                    <label for="TextIngMod" class="col-form-label">Nombre:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextIngMod" name="Nombre">
                </div>
            </form>
        </div>
        <!-- Pie del Side Panel con botón para guardar cambios -->
        <div class="modal-footer">
            <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary" style="background-color: #4CAF50; border-color: #4CAF50; border-radius: 20px;">
                Guardar Cambios
            </button>
        </div>
    </div>
    
    <!-- Inclusión del archivo JavaScript que maneja la interacción (carga de datos, validaciones, eventos, etc.) para Comunas -->
    <script src="JS/LocComu.js"></script>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJCliente.aspx.cs" Inherits="Pweb.PWJCliente" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <!-- Contenido para el placeholder "head" del MasterPage. (Vacío en este caso) -->
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenido principal de la página -->
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <!-- Encabezado del card -->
                <div class="card-header">
                    Información sobre Clientes
                </div>
                <!-- Cuerpo del card -->
                <div class="card-body">
                    <div class="row">
                        <!-- Botón para agregar un nuevo cliente -->
                        <div class="col-sm-2">
                            <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                                Nuevo
                            </button>
                        </div>
                    </div>
                    <hr />
                    <div class="row mt-3">
                        <div class="col-sm-12">
                            <!-- Tabla que mostrará la lista de clientes (los registros se insertarán dinámicamente en el tbody) -->
                            <table id="Grid" class="table table-striped table-bordered nowrap" style="width: 100%">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Nombre</th>
                                        <th>Rut</th>
                                        <th>Comuna</th>
                                        <th>Provincia</th>
                                        <th>Región</th>
                                        <th>Direccion</th>
                                        <th>Telefono</th>
                                        <th>Email</th>
                                        <th>Giro</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- Filas que se cargarán mediante llamada AJAX -->
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Pie del card (actualmente vacío, se puede utilizar para mensajes o paginación) -->
                <div class="card-footer" style="background-color: #f8f9fa; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
                </div>
            </div>
        </div>
    </div>

    <!-- Side Panel para Agregar/Editar -->
    <div id="sidePanel" class="side-panel">
        <!-- Panel lateral oculto inicialmente; se mostrará agregando la clase "active" -->
        <div class="side-panel-content">
            <!-- Botón de cerrar ("X") en la esquina superior derecha del panel -->
            <button id="btnCloseSidePanel" class="close-btn">X</button>
            <h5 class="modal-title" id="exampleModalLabel">Cliente</h5>
            <form>
                <!-- Campo oculto para el ID del cliente -->
                <input id="textId" class="model" name="IdP_Cli" value="0" type="hidden" />

                <!-- Campo para el Nombre -->
                <div class="form-group">
                    <label for="TextNom" class="col-form-label">Nombre:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextNom" name="Nombre">
                </div>

                <!-- Campo oculto para almacenar temporalmente el Rut -->
                <input id="TRut" class="model" name="Rut" value="0" type="hidden" />
                <!-- Campo para el Rut -->
                <div class="form-group">
                    <label for="TextRut" class="col-form-label">Rut:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextRut" name="Rut">
                </div>

                <div class="form-group">
                    <!-- Etiqueta y dropdown para seleccionar la Región a la que pertenece la Region -->
                    <label for="ComboIngModReg" class="col-form-label">Región:</label>
                    <select id="ComboIngModReg" class="form-control form-control-sm model" name="IdReg">
                        <option value="0">Seleccione...</option>
                        <!-- Opción predeterminada -->
                    </select>
                </div>
                <div class="form-group">
                    <!-- Etiqueta y dropdown para seleccionar la Región a la que pertenece la Provincia -->
                    <label for="ComboIngModPro" class="col-form-label">Provincia:</label>
                    <select id="ComboIngModPro" class="form-control form-control-sm model" name="IdPro">
                        <option value="0">Seleccione...</option>
                        <!-- Opción predeterminada -->
                    </select>
                </div>
                <div class="form-group">
                    <!-- Etiqueta y dropdown para seleccionar la Región a la que pertenece la Comuna -->
                    <label for="ComboIngModCom" class="col-form-label">Comuna:</label>
                    <select id="ComboIngModCom" class="form-control form-control-sm model" name="IdCom">
                        <option value="0">Seleccione...</option>
                        <!-- Opción predeterminada -->
                    </select>
                </div>
                <!-- Campo oculto para Direccion (valor original) -->
                <input id="TDire" class="model" name="Direccion" value="0" type="hidden" />
                <!-- Campo para escribir la Dirección -->
                <div class="form-group">
                    <label for="TextDire" class="col-form-label">Direccion:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextDire" name="Direccion">
                </div>
                <!-- Campo oculto para Teléfono (valor original) -->
                <input id="TTel" class="model" name="Tel" value="0" type="hidden" />
                <!-- Campo para escribir el Teléfono -->
                <div class="form-group">
                    <label for="TextTel" class="col-form-label">Telefono:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextTel" name="Telefono">
                </div>

                <!-- Campo oculto para Email (valor original) -->
                <input id="TEmail" class="model" name="Email" value="0" type="hidden" />
                <!-- Campo para escribir el Email -->
                <div class="form-group">
                    <label for="TextEma" class="col-form-label">Email:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextEma" name="Email">
                </div>
                <!-- Campo oculto para Giro (valor original) -->
                <input id="TGiro" class="model" name="Giro" value="0" type="hidden" />
                <!-- Campo para escribir el Giro -->
                <div class="form-group">
                    <label for="TextGir" class="col-form-label">Giro:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextGir" name="Giro">
                </div>

                <!-- Campo oculto adicional (puede servir para Descripción u otro dato) -->
                <input id="TDesp" class="model" name="Giro" value="0" type="hidden" />
            </form>
        </div>
        <!-- Pie del modal con botones para cerrar o guardar los cambios -->
        <div class="modal-footer">
            <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary">Guardar Cambios</button>
        </div>
    </div>
    <!-- Se enlaza el archivo JavaScript que contiene la lógica (AJAX, eventos, etc.) -->
    <script src="JS/Cliente.js"></script>
</asp:Content>

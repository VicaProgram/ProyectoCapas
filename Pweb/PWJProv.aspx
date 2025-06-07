<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJProv.aspx.cs" Inherits="Pweb.PWJProv" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <!-- Contenido para la sección head del MasterPage (actualmente vacío) -->
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenido principal de la página -->
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <!-- Encabezado del card -->
                <div class="card-header">
                    Información sobre Proveedores
                </div>
                <!-- Cuerpo del card -->
                <div class="card-body">
                    <div class="row">
                        <!-- Botón para crear un nuevo proveedor -->
                        <div class="col-sm-2">
                            <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                                Nuevo
                            </button>
                        </div>
                    </div>
                    <hr />
                    <div class="row mt-3">
                        <div class="col-sm-12">
                            <!-- Tabla para listar los proveedores. Las filas se cargarán dinámicamente -->
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
                                        <th>Descripción</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- Aquí se insertarán las filas mediante JavaScript -->
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Pie del card; actualmente vacío, se puede usar para notificaciones o paginación -->
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
            <h5 class="modal-title" id="exampleModalLabel">Proveedor</h5>
            <form>
                <!-- Campo oculto para el ID del proveedor -->
                <input id="textId" class="model" name="IdProv" value="0" type="hidden" />

                <!-- Campo para el Nombre -->
                <div class="form-group">
                    <label for="TextNom" class="col-form-label">Nombre:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextNom" name="Nombre">
                </div>

                <!-- Campo oculto para el Rut (valor original) -->
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

                <!-- Campo oculto para la Dirección (valor original) -->
                <input id="TDire" class="model" name="Direccion" value="0" type="hidden" />
                <!-- Campo para ingresar la Dirección -->
                <div class="form-group">
                    <label for="TextDire" class="col-form-label">Direccion:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextDire" name="Direccion">
                </div>

                <!-- Campo oculto para Teléfono (valor original) -->
                <input id="TTel" class="model" name="Tel" value="0" type="hidden" />
                <!-- Campo para ingresar el Teléfono -->
                <div class="form-group">
                    <label for="TextTel" class="col-form-label">Telefono:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextTel" name="Telefono">
                </div>

                <!-- Campo oculto para Email (valor original) -->
                <input id="TEmail" class="model" name="Email" value="0" type="hidden" />
                <!-- Campo para ingresar Email -->
                <div class="form-group">
                    <label for="TextEma" class="col-form-label">Email:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextEma" name="Email">
                </div>

                <!-- Campo oculto para Giro (valor original) -->
                <input id="TGiro" class="model" name="Giro" value="0" type="hidden" />
                <!-- Campo para ingresar el Giro -->
                <div class="form-group">
                    <label for="TextGir" class="col-form-label">Giro:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextGir" name="Giro">
                </div>

                <!-- Campo oculto para otro valor (posible respaldo o valor original) -->
                <input id="TDesp" class="model" name="Giro" value="0" type="hidden" />
                <!-- Campo para ingresar la Descripción -->
                <div class="form-group">
                    <label for="TextDes" class="col-form-label">Descripción:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextDes" name="Descripción">
                </div>
            </form>
        </div>

        <!-- Pie del modal: botones para cerrar o guardar cambios -->
        <div class="modal-footer">
            <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary">Guardar Cambios</button>
        </div>
    </div>
    <!-- Se vincula el archivo JavaScript que contiene la lógica (AJAX, eventos, etc.) para proveedores -->
    <script src="JS/Prov.js"></script>
</asp:Content>

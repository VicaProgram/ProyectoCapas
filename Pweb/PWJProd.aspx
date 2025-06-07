<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PWJProd.aspx.cs" Inherits="Pweb.PWJProd" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <!-- Zona destinada a recursos o información adicional en el 'head' -->
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenedor principal de la interfaz de productos -->
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <div class="card-header">
                    Información sobre Productos
                </div>
                <div class="card-body">
                    <!-- Sección con el botón para agregar un nuevo producto -->
                    <div class="row">
                        <div class="col-sm-2">
                            <button id="btnNuevo" type="button" class="btn btn-sm" style="background-color: #ffffff; border: 1px solid #4CAF50; color: #4CAF50; border-radius: 20px;">
                                Nuevo
                            </button>
                        </div>
                    </div>
                    <hr />
                    <!-- Tabla que muestra los productos -->
                    <div class="row mt-3">
                        <div class="col-sm-12">
                            <table id="Grid" class="table table-striped table-bordered nowrap" style="width: 100%">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Nombre</th>
                                        <th>Fecha Incorporación</th>
                                        <th>Cantidad Inicial</th>
                                        <th>Cantidad Actual</th>
                                        <th>Cantidad Arrendada</th>
                                        <th>Total Actual</th>
                                        <th>Valor del Arriendo</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- Pie de tarjeta para información extra o controles adicionales -->
                <div class="card-footer" style="background-color: #f8f9fa; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
                </div>
            </div>
        </div>
    </div>
    <!-- Panel lateral para agregar o editar productos -->
    <div id="sidePanel" class="side-panel">
        <!-- Panel oculto, se mostrará al activar la clase "active" -->
        <div class="side-panel-content">
            <!-- Botón para cerrar el panel lateral -->
            <button id="btnCloseSidePanel" class="close-btn">X</button>
            <h5 class="modal-title" id="exampleModalLabel">Productos</h5>
            <form>
                <input id="textId" class="model" name="IdProd" value="0" type="hidden" />
                <!-- Campo para el Nombre del producto -->
                <div class="form-group">
                    <label for="TextNom" class="col-form-label">Nombre:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextNom" name="Nombre">
                </div>
                <input id="TFInc" class="model" name="FInc" value="0" type="hidden" />
                <!-- Campo para la Fecha de Incorporación -->
                <div class="form-group">
                    <label for="TextFInc" class="col-form-label">Fecha Incorporacion:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextFInc" name="FInc">
                </div>
                <input id="TCInc" class="model" name="CInc" value="0" type="hidden" />
                <!-- Campo para la Cantidad Inicial -->
                <div class="form-group">
                    <label for="TextCInc" class="col-form-label">Cantidad Inicial:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextCInc" name="CInc">
                </div>
                <input id="TCAct" class="model" name="CAct" value="0" type="hidden" />
                <!-- Campo para la Cantidad Actual -->
                <div class="form-group">
                    <label for="TextCAct" class="col-form-label">Cantidad Actual:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextCAct" name="CAct">
                </div>
                <input id="TCArr" class="model" name="CArr" value="0" type="hidden" />
                <!-- Campo para la Cantidad Arrendada -->
                <div class="form-group">
                    <label for="TextCArr" class="col-form-label">Cantidad Arrendada:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextCArr" name="CArr">
                </div>
                <input id="TTAct" class="model" name="TAct" value="0" type="hidden" />
                <!-- Campo para el Total Actual -->
                <div class="form-group">
                    <label for="TextTAct" class="col-form-label">Total Actual:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextTAct" name="TAct">
                </div>
                <input id="TVArr" class="model" name="VArr" value="0" type="hidden" />
                <!-- Campo para el Valor del Arriendo -->
                <div class="form-group">
                    <label for="TextVArr" class="col-form-label">Valor del Arriendo:</label>
                    <input type="text" class="form-control form-control-sm model" id="TextVArr" name="VArr">
                </div>
            </form>
        </div>
        <!-- Zona para confirmar la acción en el panel lateral -->
        <div class="modal-footer">
            <button id="btnGuardarCambios" type="button" class="btn btn-sm btn-primary">Guardar Cambios</button>
        </div>
    </div>
    <!-- Inclusión del script que maneja la lógica de productos -->
    <script src="JS/Prod.js"></script>
</asp:Content>

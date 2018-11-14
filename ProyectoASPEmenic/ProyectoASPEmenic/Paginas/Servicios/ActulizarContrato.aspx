<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActulizarContrato.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ActulizarContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbContratos" Text="Actualizar Contratos" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <asp:HiddenField ID="hfIdPlaca" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="card border-primary mb-3">
        <div class="card-header">
            <h4>Actualizar Registro Contrato</h4>
        </div>
        <div class="card-body text-primary">
            <hr />
            <div class="form-row">
                <div class="form-group col-md-4">
                    <asp:Label runat="server" ID="lbIDtransporte" Text="Transporte\Placa:" Style="color: black"></asp:Label>
                    <ajaxToolkit:ComboBox ID="ddlIDtransporte" runat="server" AutoCompleteMode="SuggestAppend" CssClass="dropdown" DropDownStyle="DropDownList" ListItemHoverCssClass="form-control" BorderStyle="Double" Width="300px">
                    </ajaxToolkit:ComboBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RFV_transporte" Display="Dynamic" SetFocusOnError="True"
                        CssClass="alert-text" runat="server" ControlToValidate="ddlIDtransporte" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                </div>
               <%-- <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbIDservicio" Text="Servicio:" Style="color: black"></asp:Label>
                    <ajaxToolkit:ComboBox ID="ddlIDservicio" runat="server" AutoCompleteMode="SuggestAppend" CssClass="dropdown" DropDownStyle="DropDownList" ListItemHoverCssClass="form-control" BorderStyle="Double" Width="200px">
                    </ajaxToolkit:ComboBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RFV_servicio" Display="Dynamic" SetFocusOnError="True"
                        CssClass="alert-text" runat="server" ControlToValidate="ddlIDservicio" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                </div>--%>
                <div class="form-group col-md-4">
                    <asp:Label runat="server" ID="lblcantidadmeses" Text="Cantidad de meses:" Style="color: black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtcantidadmeses" CssClass="form-control" TextMode="Number" Text="1"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RFV_cantidadmeses" Display="Dynamic" SetFocusOnError="True"
                        CssClass="alert-text" runat="server" ControlToValidate="txtcantidadmeses" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Meses" runat="server" CssClass="alert-text"
                        ErrorMessage="* Solo numeros" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtcantidadmeses" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </div>

                <div class="form-group col-md-4">
                    <asp:Label runat="server" ID="lbfechaemision" Text="Fecha de emision:" Style="color: black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtfechaemision" CssClass="form-control"  /><br />
                    <asp:RequiredFieldValidator ID="RFV_fechaemision" Display="Dynamic" SetFocusOnError="True"
                        CssClass="alert-text" runat="server" ControlToValidate="txtcantidadmeses" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="REV_Fecha" runat="server" CssClass="alert-text"
                        ErrorMessage="* Fecha invalida" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtfechaemision" ValidationExpression="^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$"></asp:RegularExpressionValidator>
                </div>
            </div>
        </div>
        <br />  
        <div style="align-content: center">
        <div class="form-row">
            <div class="form-group col-md-6">  
                <center><asp:Button runat="server" ID="btnActualizarContrato" Text="Actualizar" CssClass="btn btn-info btn-block" Style="color: white; background-color: red; border-color: red; width: auto" OnClick="btnActualizarContrato_Click"></asp:Button></center>
            </div>
            <div class="form-group col-md-6">   
                <center><asp:Button runat="server" ID="btnRegresar" Text="Regresar" CssClass="btn btn-info btn-block" Style="color: white; background-color: red; border-color: red; width: auto" OnClick="btnRegresar_Click"></asp:Button></center>
            </div>
        </div>
        <br />
        <script src="../../vendor/jquery/jquery.min.js"></script>
        <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
        <!-- Core plugin JavaScript-->
        <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

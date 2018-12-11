<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Usuarios.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h3>
        Usuarios
        <small class="text-muted">Agregar Credenciales</small>
    </h3></center>
    <asp:HiddenField runat="server" ID="hfIdPersona" /><!-- Variable para almacenar idpersona-->
    <div class="card border-primary mb-3">
        <div class="card-header"><h3>Datos personales</h3></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="lblNombre"><b>Nombre</b></label>
                    <asp:Label ID="lblNombre" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                <div class="form-group col-md-6">
                    <label for="lblEmail"><b>Correo electrónico</b></label>
                    <asp:Label ID="lblEmail" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
            </div>
        </div>
    <div class="card border-primary mb-3">
        <div class="card-header"><h3>Credenciales de Usuario</h3></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label ID="lblUsuario" Text="Ingrese su Usuario" runat="server" style="color:black"></asp:Label>
                    <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Ingrese un Usuario" ControlToValidate="txtUsuario" ForeColor="MediumVioletRed"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="* Username invalido" ForeColor="MediumVioletRed" ControlToValidate="txtUsuario" ValidationExpression="[A-Za-z][A-Za-z0-9._]{5,25}"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label ID="lblContra" Text="Ingrese su Contraseña" runat="server" style="color:black"></asp:Label>
                    <asp:TextBox ID="txtContra" CssClass="form-control" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Ingrese contraseña" ControlToValidate="txtContra" ForeColor="MediumVioletRed"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Contraseña invalida" ForeColor="MediumVioletRed" ControlToValidate="txtContra" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,15})"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label ID="lblConfCon" Text="Confirme su Contraseña" runat="server" style="color:black"></asp:Label>
                    <asp:TextBox ID="txtConfirmContra" CssClass="form-control" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Confirme contraseña" ControlToValidate="txtConfirmContra" ForeColor="MediumVioletRed"></asp:RequiredFieldValidator>
                </div>
                </div>
            </div>
        </div>
    <center><asp:Label runat="server" id="lblNotificacion" CssClass="alert alert-danger"  Visible="false"></asp:Label></center><br />
    <center><asp:Button runat="server" ID="btnGuardarUsuario" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGuardarUsuario_Click"></asp:Button></center>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

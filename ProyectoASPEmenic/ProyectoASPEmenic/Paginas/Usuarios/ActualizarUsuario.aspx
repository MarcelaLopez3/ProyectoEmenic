<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActualizarUsuario.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Usuarios.ActualizarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h3>
        Usuarios
        <small class="text-muted">Actualizar Contraseña</small>
    </h3></center>
    <asp:HiddenField runat="server" ID="hfIdPersona" /><!-- Variable para almacenar idpersona-->
    <asp:HiddenField runat="server" ID="hfIdEstado" />
    <div class="card border-primary mb-3">
        <div class="card-header"><h3>Datos personales</h3></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="lblNombre"><b>Nombre</b></label>
                    <asp:Label ID="lblNombre" runat="server" CssClass="form-control"></asp:Label>
                    </div>
                <div class="form-group col-md-3">
                    <label for="lblEmail"><b>Correo electrónico</b></label>
                    <asp:Label ID="lblEmail" runat="server" CssClass="form-control"></asp:Label>
                </div>
                <div class="form-group col-md-3">
                    <label for="lblUsuario"><b>Username</b></label>
                    <asp:Label ID="lblUsuario" runat="server" CssClass="form-control"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <label for="lblEstado"><b>Estado</b></label>
                    <asp:Label ID="lblEstado" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
            </div>
        </div>
    <div class="card border-primary mb-3">
        <div class="card-header"><h3>Actualizar Contraseña</h3></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label ID="lblContra" Text="Ingrese Nueva Contraseña" runat="server" style="color:black"></asp:Label>
                    <asp:TextBox ID="txtContra" CssClass="form-control" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Ingrese contraseña" ControlToValidate="txtContra" ForeColor="MediumVioletRed"></asp:RequiredFieldValidator><br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Contraseña invalida" ForeColor="MediumVioletRed" ControlToValidate="txtContra" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[\W]).{8,15})"></asp:RegularExpressionValidator>
                 </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="Label1" Text="Confirme Contraseña" runat="server" style="color:black"></asp:Label>                    
                    <asp:TextBox ID="txtConfirmCon" CssClass="form-control" runat="server" MaxLength="20" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Ingrese contraseña" ControlToValidate="txtConfirmCon" ForeColor="MediumVioletRed"></asp:RequiredFieldValidator>
                 </div>
                </div>
            </div>
        </div>
            <center><asp:Label runat="server" id="lblNotificacion" CssClass="alert alert-danger"  Visible="false"></asp:Label></center><br />      
    <div style="align-content:center">
          
        <div class="form-row">
            <div class="form-group col-md-6">   
    <center><asp:Button runat="server" ID="btnGuardarUsuario" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGuardarUsuario_Click" ></asp:Button></center>
        </div>
            <center>
                <div class="form-group col-md-6">  
        <asp:Button runat="server" ID="btnAltaUsuario" Text="Dar de baja" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnAltaUsuario_Click" OnClientClick="return confirm('¿Está seguro de realizar acción?');"  ></asp:Button>
                    </div>
                </div>
        </div>
    </center>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

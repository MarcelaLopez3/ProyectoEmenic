<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoASPEmenic.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <title>EMENIC-Inicio</title>
    <!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet"/>
</head>
<body class="bg-dark">
    <form id="form1" runat="server"  >
      <div class="container">
      <div class="card card-login mx-auto mt-5">
        <center><div class="card-header">EMENIC - Login</div></center>
        <div class="card-body">
            <div class="form-group">
              <center><div><img src="Imagenes/Logo_emenic.png" alt="IMG"/></div></center>
              <br />
              <div class="form-label-group">
                  <asp:TextBox runat="server" CssClass="form-control" ID="txtUsuario" placeholder="Usuario"/>
                  <label for="txtUsuario">Usuario</label>
              </div>
              <br />
              <div class="form-label-group">
                  <asp:TextBox runat="server" CssClass="form-control" ID="txtContrasena" placeholder="Contraseña" TextMode="password" />
                  <label for="txtContrasena">Contraseña</label>
              </div>
            </div>
            <div class="form-label-group">
                  <asp:Button runat="server" CssClass="form-control" Text="Ingresar" BackColor="Red" ForeColor="White" Font-Bold="true"/>
            </div>
        </div>
      </div>
    </div>             

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    </form>
</body>
</html>


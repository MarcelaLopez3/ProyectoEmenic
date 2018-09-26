﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoASPEmenic.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" /></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"/></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" /></script>

</head>
<body>
    <form id="form1" runat="server"  >
    <center>
    <br />
    <br />
    <div class="card-body text-primary" style="background-color:lightgrey; border-color:lightgray">
        <div>
                <img src="Imagenes/Logo_emenic.png" alt="IMG"/>
	    </div>   
        <br />           
		    <div class="form-group col-md-1">
                <asp:Label runat="server" ID="lblLogin" Text="Login" Font-Bold="true" ForeColor="Red" Font-Size="X-Large" ></asp:Label>    
		    </div>
        <br />
            <div class="form-group col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtUsuario" placeholder="Usuario"/>
            </div>        
            <div class="form-group col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtContrasena" placeholder="Contraseña" TextMode="password"/>
            </div>
        <br />					
		    <div class="form-group col-md-3">
			    <asp:Button runat="server" CssClass="form-control" Text="Ingresar" BackColor="Black" ForeColor="White" Font-Bold="true"/>
		    </div>  
    </div>
    </center>
    </form>
</body>
</html>


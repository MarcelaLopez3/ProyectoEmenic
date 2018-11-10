<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroContrato.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.RegistroContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbContratos" Text="Contratos" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
        <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos</h4></div>
         <div class="card-body text-primary">
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbIDtransporte" Text="Transporte:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlIDtransporte" runat="server" CssClass="form-control" class="form-control">
                    <asp:ListItem Text="Datos desde la base" Value="ddl1"></asp:ListItem>
                </asp:DropDownList> 
            </div>
               <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbIDservicio" Text="Servicio:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlIDservicio" runat="server" CssClass="form-control" class="form-control">
                    <asp:ListItem Text="Datos desde la base" Value="ddl1"></asp:ListItem>
                </asp:DropDownList> 
            </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblcantidadmeses" Text="Cantidad de meses:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtcantidadmeses" CssClass="form-control"></asp:TextBox>    
                </div>
               
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbfechaemision" Text="Fecha de emision:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtfechaemision" CssClass="form-control"></asp:TextBox>    
                </div>

               </div>
        </div>
             <div>          
        <center><asp:Button runat="server" ID="btnGuardarContrato" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGuardarContrato_Click" ></asp:Button></center>             
   </div>
   <br />

    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>  
</asp:Content>

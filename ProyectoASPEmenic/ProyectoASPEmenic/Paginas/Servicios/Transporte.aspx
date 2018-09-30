<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Transporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.Transporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbTransporte" Text="Transportes" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
        <div class="card border-primary mb-3">
        <div class="card-header"><h4>Vehículos</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkCabezal" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbCabezal" Text="Cabezal" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkFurgon" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbFurgon" Text="Furgon" style="color:black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblplaca" Text="Placa del vehículo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPlaca" CssClass="form-control"></asp:TextBox>    
                </div>
               
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbvehiculoequipo" Text="Equipo del vehículo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtvehiculoequipo" CssClass="form-control"></asp:TextBox>    
                </div>
                
                
               </div>
            <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lbvehiculoDescrip" Text="Descripcion del vehículo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" Height="208px" TextMode="MultiLine" Width="491px" /> 
               </div>

        </div>
            </div>
    <div>          
        <center><asp:Button runat="server" ID="btnGuardarTransporte" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" ></asp:Button></center>             
   </div>
   <br />

    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>  
</asp:Content>

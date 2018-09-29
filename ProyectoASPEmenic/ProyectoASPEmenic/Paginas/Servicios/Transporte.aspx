<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Transporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.Transporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="card border-primary mb-3">
        <div class="card-header"><h4>Vehículos</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkCabezal" />
                    <asp:Label runat="server" ID="lbCabezal" Text="Cabezal" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkFurgon" />
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
</asp:Content>

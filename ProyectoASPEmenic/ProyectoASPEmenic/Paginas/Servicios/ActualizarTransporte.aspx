<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActualizarTransporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ActualizarTransporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbTransporte" Text="Actualizar Transportes" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header">
            <h4>Vehículo</h4>
        </div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkCabezal" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbCabezal" Text="Cabezal" Style="color: black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkFurgon" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbFurgon" Text="Furgon" Style="color: black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblplaca" Text="Placa del vehículo:" Style="color: black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPlaca" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbvehiculoequipo" Text="Tipo de equipo:" Style="color: black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtvehiculoequipo" CssClass="form-control"></asp:TextBox>
                </div>


            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbvehiculoDescrip" Text="Descripcion del vehículo:" Style="color: black"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" Height="208px" TextMode="MultiLine" Width="491px" />
            </div>

        </div>
    </div>
    <div style="align-content: center">
        <div class="form-row">
            <div class="form-group col-md-12">
                <center><asp:Button runat="server" ID="btnActualizarTransporte" Text="Actualizar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnActualizarTransporte_Click"></asp:Button></center>
            </div>
        </div>
    </div>
    <div>
    </div>
</asp:Content>

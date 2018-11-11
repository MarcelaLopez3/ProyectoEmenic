<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoTransporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ListadoTransporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1><asp:Label runat="server" ID="lbltransporte" Text="Listado Transporte" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <div class="form-row">
            <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label2" Text="Para agregar un nuevo registro:" style="color:black"></asp:Label> 
                </div>
            <div class="form-group col-md-2">               
                    <asp:Button ID="btnAgregarTransporte" runat="server" CssClass="form-control" class="form-control" Text="Agregar Nuevo" BackColor="Red" ForeColor="White" OnClick="btnAgregarRegistro_Click" Width="151px"></asp:Button> 
                </div>
       </div>
    <br />
    <center>
        <asp:HiddenField runat="server" ID="HFIdTransporte"/>
        

        <asp:GridView ID="GridListadoTransporte" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridListadoTransporte_SelectedIndexChanged" OnRowDeleting="GridListadoTransporte_Eliminar">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField ControlStyle-BackColor="Red" ShowSelectButton="True" SelectText="Editar" ShowDeleteButton="true" DeleteText="Eliminar" ButtonType="Button" ControlStyle-CssClass="btn btn-info" />
            </Columns>
        </asp:GridView>
    </center>

</asp:Content>

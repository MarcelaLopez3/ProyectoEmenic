<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoClientes.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.ListadoClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Listado Clientes" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
        <asp:HiddenField runat="server" ID="HFIdPersona"/>
        
        <div class="form-row">
        <div class="form-group col-md-2">
                <asp:Label runat="server" ID="Label2" Text="Tipo Persona:" style="color:black"></asp:Label>                
        </div>
        <div class="form-group col-md-3">
            <asp:DropDownList ID="ddltipopersona" runat="server" CssClass="form-control" class="form-control" AutoPostBack="true">
                    <asp:ListItem Text="Persona Natural" Value="PersonaNatural"></asp:ListItem>
                    <asp:ListItem Text="Persona Juridica" Value="PersonaJuridica"></asp:ListItem>
            </asp:DropDownList> 
        </div>
       </div>
        <br />
        <asp:GridView ID="GridListadoClientes" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridListadoClientes_SelectedIndexChanged" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="Nuevo" ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>

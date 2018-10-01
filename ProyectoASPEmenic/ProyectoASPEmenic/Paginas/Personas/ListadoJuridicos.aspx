<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoJuridicos.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Personas.ListadoJuridicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1><asp:Label runat="server" ID="lblpersonajuridica" Text="Listado Personas Juridicas" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
        <asp:HiddenField runat="server" ID="HFIdPersona"/>
        

        <asp:GridView ID="GridListadoJuridicas" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridListadoJuridicas_SelectedIndexChanged" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="Actualizar" ShowSelectButton="True" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </center>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoNaturales.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Personas.ListadoNaturales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Listado Personas Naturales" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
        <asp:HiddenField runat="server" ID="HFIdPersona"/>
        
        <div class="form-row">
            <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label2" Text="Para agregar un nuevo registro:" style="color:black"></asp:Label>                
            </div>
            <div class="form-group col-md-2">
                <asp:Button ID="btnAgregarRegistro" runat="server" CssClass="form-control" class="form-control" Text="Agregar Nuevo" BackColor="Red" ForeColor="White" OnClick="btnAgregarRegistro_Click"></asp:Button> 
            </div>
       </div>

        <asp:GridView ID="GridListadoNaturales" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridListadoNaturales_RowEditing" OnRowDeleting="GridListadoNaturales_RowDeleting" OnSelectedIndexChanged="GridListadoNaturales_SelectedIndexChanged" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="" ButtonType="Button" ControlStyle-CssClass="btn btn-info" CausesValidation="False" InsertVisible="False" ShowCancelButton="False" ShowDeleteButton="False" ShowEditButton="True" >
                 <ControlStyle CssClass="btn btn-info" BackColor="Red"></ControlStyle>
                 </asp:CommandField>                
            </Columns>
        </asp:GridView>
    </center>

    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script> 
</asp:Content>

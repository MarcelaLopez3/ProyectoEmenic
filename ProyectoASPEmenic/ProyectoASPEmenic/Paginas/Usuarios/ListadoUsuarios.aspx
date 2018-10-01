<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Usuarios.ListadoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hfIdPersona" runat="server" />
    <center><h3>
        Usuarios
        <small class="text-muted">Listado de Usuarios</small>
    </h3></center>
    <div class="table-responsive">
    <asp:GridView ID="dataTable" runat="server" CssClass="table table-bordered" OnSelectedIndexChanged="dataTable_SelectedIndexChanged" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="Actualizar" ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-info"/>
            </Columns>
        </asp:GridView>
    </center>
        </div>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>   
</asp:Content>

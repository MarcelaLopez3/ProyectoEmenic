<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoJuridicos.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Personas.ListadoJuridicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1><asp:Label runat="server" ID="lblpersonajuridica" Text="Listado Personas Juridicas" style="color:black; font-family:Verdana"></asp:Label></h1></center>
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


        <asp:GridView ID="GridListadoJuridicas" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridListadoJuridicas_SelectedIndexChanged" OnRowEditing="GridListadoJuridicas_RowEditing" AutoGenerateColumns="false" OnRowCommand="GridListadoJuridicas_RowCommand">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                <asp:BoundField DataField="IdPersona" DataFormatString="{0}" HeaderText="Id">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreLegal" DataFormatString="{0}" HeaderText="Nombre Legal">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Tamano" DataFormatString="{0}" HeaderText="Tamaño Empresa">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Ubicacion" DataFormatString="{0}" HeaderText="Ubicacion">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Pais" DataFormatString="{0}" HeaderText="Pais">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Giro" DataFormatString="{0}" HeaderText="Giro">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreContacto" DataFormatString="{0}" HeaderText="Nombre Contacto">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:CheckBoxField>
                <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                       <ItemTemplate>
                            <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Actualizar" CssClass="btn btn-success" CommandName="Actualizar" CommandArgument='<%# Eval("IdPersona")%>'><i class="fa fa-edit" aria-hidden="true"></i></i></asp:LinkButton>
                       </ItemTemplate>
                 </asp:TemplateField> 
            </Columns>
        </asp:GridView>
    </center>
<script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

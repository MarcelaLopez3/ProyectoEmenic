<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Usuarios.ListadoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbltitulo" Text="Listado Usuarios" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="table-responsive">
    <center>
    <asp:GridView ID="dataTable" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="dataTable_SelectedIndexChanged" AutoGenerateColumns="False" OnRowCommand="dataTable_RowCommand" DataKeyNames="Id" >
     <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
     <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
     <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
     <SortedAscendingCellStyle BackColor="#F7F7F7" />
     <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
     <SortedDescendingCellStyle BackColor="#E5E5E5" />
     <SortedDescendingHeaderStyle BackColor="#242121" />
               <Columns>
                <asp:BoundField DataField="Id" DataFormatString="{0}" HeaderText="Id">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Nombres" DataFormatString="{0}" HeaderText="Nombres">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:BoundField DataField="Apellidos" DataFormatString="{0}" HeaderText="Apellidos">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:BoundField DataField="Usuario" DataFormatString="{0}" HeaderText="Usuario">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:CheckBoxField DataField="Estado"  HeaderText="Estado">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:CheckBoxField>
                  <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkBOpcionActualizar"  CommandArgument='<%# Eval("Id")%>' runat="server" ToolTip="Actualizar" CssClass="btn btn-success" CommandName="Actualizar"><i class="fa fa-edit" aria-hidden="true" ></i></asp:LinkButton>
                                            </ItemTemplate>
                      </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />              
        </asp:GridView>
    
    </center>
        </div>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script> 
</asp:Content>

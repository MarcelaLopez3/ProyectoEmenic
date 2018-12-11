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
        <asp:GridView ID="GridListadoClientesNatural" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowCommand="GridListadoClientesNatural_RowCommand" >
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
                <asp:BoundField DataField="PrimerNombre" DataFormatString="{0}" HeaderText="Primer Nombre">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="SegundoNombre" DataFormatString="{0}" HeaderText="Segundo Nombre">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="PrimerApellido" DataFormatString="{0}" HeaderText="Primer Apellido">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="SegundoApellido" DataFormatString="{0}" HeaderText="Segundo Apellido">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="DUI" DataFormatString="{0}" HeaderText="DUI">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="NIT" DataFormatString="{0}" HeaderText="NIT">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:CheckBoxField>
                <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                       <ItemTemplate>
                            <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Servicios" CssClass="btn btn-success" CommandName="Servicios" CommandArgument='<%# Eval("IdPersona")%>'><i class="fa fa-truck-loading" aria-hidden="true"></i></i></asp:LinkButton>
                            <asp:LinkButton ID="lkbOpcionEliminar" runat="server" ToolTip="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("IdPersona")%>' OnClientClick="return confirm('¿Está seguro de eliminar cliente?');"><i class="fa fa-trash-alt" aria-hidden="true"></i></i></asp:LinkButton>
                       </ItemTemplate>
                 </asp:TemplateField> 
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridListadoClientesJuridico" runat="server" BackColor="White" Visible="false" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="false" OnRowCommand="GridListadoClientesJuridico_RowCommand" >
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
                <asp:BoundField DataField="Tamano" DataFormatString="{0}" HeaderText="Tamaño">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Ubicacion" DataFormatString="{0}" HeaderText="Ubicación">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Pais" DataFormatString="{0}" HeaderText="País">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Giro" DataFormatString="{0}" HeaderText="Giro">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreContacto" DataFormatString="{0}" HeaderText="Contacto">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:CheckBoxField>
             <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Servicios" CssClass="btn btn-success" CommandName="Servicios" CommandArgument='<%# Eval("IdPersona")%>'><i class="fa fa-truck-loading" aria-hidden="true"></i></i></asp:LinkButton>
                                            <asp:LinkButton ID="lkbOpcionEliminar" runat="server" ToolTip="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("IdPersona")%>' OnClientClick="return confirm('¿Está seguro de eliminar cliente?');"><i class="fa fa-trash-alt" aria-hidden="true"></i></i></asp:LinkButton>
                                         </ItemTemplate>
                    </asp:TemplateField> 
            </Columns>
        </asp:GridView>
    </center>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

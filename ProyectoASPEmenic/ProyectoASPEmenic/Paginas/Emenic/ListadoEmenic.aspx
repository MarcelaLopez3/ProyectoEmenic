<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoEmenic.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Emenic.ListadoEmenic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Nosotros" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
         <div class="form-row">
            <div class="form-group col-md-3">  
                 <asp:Button ID="btnDashboard" runat="server" CssClass="form-control" class="form-control" Text="Ir a Dashboard" BackColor="Red" ForeColor="White" OnClick="btnDashboard_Click" ></asp:Button>                
            </div>
        </div>
        <br />
        <center><h2><asp:Label runat="server" ID="Label1" Text="Información de EMENIC" style="color:black; font-family:Verdana"></asp:Label></h2></center>
        <asp:GridView ID="GridListadoEmenic1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridListadoEmenic1_RowEditing" AutoGenerateColumns="false" OnRowCommand="GridListadoEmenic1_RowCommand" >
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
                <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                     <ItemTemplate>
                          <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Actualizar" CssClass="btn btn-success" CommandName="Actualizar" CommandArgument='<%# Eval("IdPersona")%>'><i class="fa fa-edit" aria-hidden="true"></i></i></asp:LinkButton>
                     </ItemTemplate>
                </asp:TemplateField> 
            </Columns>
        </asp:GridView>
        <br />
        <hr />
        <center><h2><asp:Label runat="server" ID="Label2" Text="Información Organizacional de EMENIC" style="color:black; font-family:Verdana"></asp:Label></h2></center>
        <asp:GridView ID="GridListadoEmenic2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridListadoEmenic2_RowEditing" AutoGenerateColumns="false" OnRowCommand="GridListadoEmenic2_RowCommand">
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
                <asp:BoundField DataField="Mision" DataFormatString="{0}" HeaderText="Mision">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Vision" DataFormatString="{0}" HeaderText="Vision">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Valores" DataFormatString="{0}" HeaderText="Valores">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Servicios" DataFormatString="{0}" HeaderText="Servicios">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" DataFormatString="{0}" HeaderText="Descripcion">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                      <ItemTemplate>
                             <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Actualizar" CssClass="btn btn-success" CommandName="Actualizar" CommandArgument='<%# Eval("Id")%>'><i class="fa fa-edit" aria-hidden="true"></i></i></asp:LinkButton>
                      </ItemTemplate>
                </asp:TemplateField> 
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>

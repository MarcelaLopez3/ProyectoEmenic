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
        

        <asp:GridView ID="GridListadoTransporte" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridListadoTransporte_SelectedIndexChanged" OnRowDeleting="GridListadoTransporte_Eliminar" AutoGenerateColumns = "false">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:BoundField DataField="IdTransporte" DataFormatString="{0}" HeaderText="Id">
                                        <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Placa" DataFormatString="{0}" HeaderText="Placa">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:BoundField DataField="Descripcion" DataFormatString="{0}" HeaderText="Descripcion">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:BoundField DataField="Equipo" DataFormatString="{0}" HeaderText="Equipo">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                <asp:CheckBoxField DataField="Furgon" HeaderText="Furgon">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:CheckBoxField>
                <asp:CheckBoxField DataField="Cabezal"  HeaderText="Cabezal">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:CheckBoxField>
                  <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkBOpcionActualizar"  CommandArgument='<%# Eval("IdTransporte")%>' runat="server" ToolTip="Actualizar" CssClass="btn btn-success" CommandName="Actualizar"><i class="fa fa-edit" aria-hidden="true" ></i></asp:LinkButton>
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

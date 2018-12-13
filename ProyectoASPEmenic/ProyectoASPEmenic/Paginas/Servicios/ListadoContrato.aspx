<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoContrato.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ListadoContrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Listado Contrato" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
        <div class="form-row">
            <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label2" Text="Para agregar un nuevo registro:" style="color:black"></asp:Label>                
            </div>
            <div class="form-group col-md-2">
                <asp:Button ID="btnAgregarRegistro" runat="server" CssClass="form-control" class="form-control" Text="Agregar Nuevo" BackColor="Red" ForeColor="White" OnClick="btnAgregarRegistro_Click"></asp:Button> 
            </div>
        </div>

        <asp:GridView ID="GridListadoContrato" runat="server"  BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="false" OnRowCommand="GridListadoContrato_RowCommand">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                        <Columns>
                        <asp:BoundField DataField="IdContrato" DataFormatString="{0}" HeaderText="ID">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Placa" DataFormatString="{0}" HeaderText="Placa">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Servicio" DataFormatString="{0}" HeaderText="Servicio">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaEmision" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Fecha de Emision">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CantidadMeses" DataFormatString="{0}" HeaderText="Cantidad de meses">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                               <ItemTemplate>
                                      <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Editar" CssClass="btn btn-success" CommandName="Editar" CommandArgument='<%# Eval("IdContrato")%>'><i class="fa fa-edit" aria-hidden="true"></i></i></asp:LinkButton>
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

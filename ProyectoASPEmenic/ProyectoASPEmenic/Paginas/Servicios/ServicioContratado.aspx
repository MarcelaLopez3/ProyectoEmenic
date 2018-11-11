<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ServicioContratado.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ServicioContratado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbltitulo" Text="Servicios" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <asp:HiddenField ID="hfIdDestinatario" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:HiddenField runat="server" ID="HFUpdateId"/>
    <asp:MultiView runat="server" ID="MVServicios">        
        <asp:View ID="VNuevoServicio" runat="server">
            <div class="card border-primary mb-3">
                <div class="card-header">
                    <h4>Información Servicio</h4>
                </div>
                <div class="card-body text-primary">
                    <div class="form-row">
                        <div class="form-group col-md-2">
                            <asp:CheckBox ID="checkTransporte" runat="server" AutoPostBack="true" />
                            <asp:Label ID="lbcheckTransporte" runat="server" style="color:black" Text="Transporte"></asp:Label>
                        </div>
                        <div class="form-group col-md-2">
                            <asp:Button ID="btnCartaPorte" runat="server" CssClass="btn btn-info btn-block" OnClick="btnCartaPorte_Click" style="color:white; background-color:red; border-color:red; width:auto" Text="Carta Porte" Visible="false" />
                        </div>
                        <div class="form-group col-md-2">
                            <asp:CheckBox ID="checkAlquiler" runat="server" AutoPostBack="true" />
                            <asp:Label ID="lbcheckAlquiler" runat="server" style="color:black" Text="Alquiler"></asp:Label>
                        </div>
                        <div class="form-group col-md-2">
                            <asp:Button ID="btnContrato" runat="server" CssClass="btn btn-info btn-block" OnClick="btnContrato_Click" style="color:white; background-color:red; border-color:red; width:auto" Text="Contrato" Visible="false" />
                        </div>
                        <div class="form-group col-md-2">
                            <asp:CheckBox ID="checkRetorno" runat="server"  />
                            <asp:Label ID="lblRetorno" runat="server" style="color:black" Text="Retorno"></asp:Label>                            
                        </div>
                    </div>
                    <hr />
                    <div class="form-row">
                        <div class="form-group col-md-6">
                            <asp:Label ID="lbDestino" runat="server" style="color:black" Text="Destino/Consignatario:"></asp:Label>
                            <ajaxToolkit:ComboBox ID="ddlDestinoConsignatario" runat="server" AutoCompleteMode="SuggestAppend" CssClass="dropdown" DropDownStyle="DropDownList" ListItemHoverCssClass="form-control" BorderStyle="Double" Width="470px">
                            </ajaxToolkit:ComboBox>
                        </div>                        
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbPeriodoCobro" runat="server" style="color:black" Text="Periodo de cobro:"></asp:Label>
                            <asp:TextBox ID="txtperiodocobro" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbgalones" runat="server" style="color:black" Text="Galones:"></asp:Label>
                            <asp:TextBox ID="txtgalones" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-6">
                            <asp:Label ID="lbDescripcion" runat="server" style="color:black" Text="Descripcion:"></asp:Label>
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbfechaAdquisicion" runat="server" style="color:black" Text="Fecha de adquisición:"></asp:Label>
                            <asp:TextBox ID="txtfechaAdquisicion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbfechaVencimiento" runat="server" style="color:black" Text="Fecha de vencimiento:"></asp:Label>
                            <asp:TextBox ID="txtfechaVencimiento" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-3">
                            <asp:Label ID="lblpagoempresa" runat="server" style="color:black" Text="Pago empresa:"></asp:Label>
                            <asp:TextBox ID="txtpagoempresa" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbpagoestadia" runat="server" style="color:black" Text="Pago de estadia:"></asp:Label>
                            <asp:TextBox ID="txtpagoestadia" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbpagoguardia" runat="server" style="color:black" Text="Pago de guardia:"></asp:Label>
                            <asp:TextBox ID="txtpagoguardia" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-3">
                            <asp:Label ID="lbviaticos" runat="server" style="color:black" Text="Viaticos de motorista:"></asp:Label>
                            <asp:TextBox ID="txtviaticos" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div>
                    <center>
                        <asp:Button ID="btnAgregarServicioContra" runat="server" CssClass="btn btn-info btn-block" OnClick="btnAgregarServicioContra_Click" style="color:white; background-color:red; border-color:red; width:auto" Text="Agregar" />
                    </center>
                </div>
                <hr />
            </div>
            <center>
                <h2>
                    <asp:Label ID="lbllistadoservicio" runat="server" style="color:black; font-family:Verdana" Text="Listado Servicios"></asp:Label>
                </h2>
            </center>
            <br />
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:Label ID="Label2" runat="server" style="color:black" Text="Tipo Servicio:"></asp:Label>
                </div>
                <div class="form-group col-md-3">
                    <asp:DropDownList ID="ddltiposervicio" runat="server" AutoPostBack="true" class="form-control" CssClass="form-control">
                        <asp:ListItem Text="Alquiler" Value="Alquiler"></asp:ListItem>
                        <asp:ListItem Text="Transporte" Value="Transporte"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <center>
                <div>
                    <asp:GridView ID="GridListadoServicio" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="false" OnRowCommand="GridListadoServicio_RowCommand">
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
                        <asp:BoundField DataField="PagoEmpresa" DataFormatString="{0}" HeaderText="Pago Empresa">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaAdquisicion" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Fecha Adquisicion">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaVencimiento" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Fecha Vencimiento">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Descripcion" DataFormatString="{0}" HeaderText="Descripcion">
                                                <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Opciones" ItemStyle-Width="150px">
                               <ItemTemplate>
                                      <asp:LinkButton ID="lkBOpcionActualizar" runat="server" ToolTip="Editar" CssClass="btn btn-success" CommandName="Editar" CommandArgument='<%# Eval("Id")%>'><i class="fa fa-edit" aria-hidden="true"></i></i></asp:LinkButton>
                               </ItemTemplate>
                        </asp:TemplateField> 
                    </Columns>
                </asp:GridView>
                </div>
            </center>
        </asp:View>

    </asp:MultiView>        
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>  
</asp:Content>


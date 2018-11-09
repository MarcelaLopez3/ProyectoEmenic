<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ServicioContratado.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ServicioContratado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbltitulo" Text="Servicios" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <asp:MultiView runat="server" ID="MVServicios">
        <asp:View runat="server" ID="VNuevoServicio">
            <div class="card border-primary mb-3">
                <div class="card-header"><h4>Información Servicio</h4></div>
                <div class="card-body text-primary">
                <div class="form-row">
                    <div class="form-group col-md-2">
                        <asp:CheckBox runat="server" ID="checkTransporte" AutoPostBack="true" />
                        <asp:Label runat="server" ID="lbcheckTransporte" Text="Transporte" style="color:black"></asp:Label>                  
                    </div>
                    <div class="form-group col-md-2">
                        <asp:Button runat="server" ID="btnCartaPorte" Text="Carta Porte" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" Visible ="false" OnClick="btnCartaPorte_Click"></asp:Button>
                    </div>
                    <div class="form-group col-md-2">
                        <asp:CheckBox runat="server" ID="checkAlquiler" AutoPostBack="true" />
                        <asp:Label runat="server" ID="lbcheckAlquiler" Text="Alquiler" style="color:black"></asp:Label>
                    </div>
                    <div class="form-group col-md-2">
                        <asp:Button runat="server" ID="btnContrato" Text="Contrato" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" Visible ="false" OnClick="btnContrato_Click"></asp:Button>
                    </div>
                </div>
                <hr />
                <div class="form-row">
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbDestino" Text="Destino/Consignatario:" style="color:black"></asp:Label>
                        <asp:DropDownList runat="server" ID="ddlDestinoConsignatario" CssClass="form-control" >
                            </asp:DropDownList>
                    </div>   
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lblRetorno" Text="Retorno:" style="color:black"></asp:Label>
                        <asp:DropDownList runat="server" ID="ddlretorno" CssClass="form-control">
                            <asp:ListItem Text="Si" Value="1"></asp:ListItem>
                            <asp:ListItem Text="No" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>                                     
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbPeriodoCobro" Text="Periodo de cobro:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtperiodocobro" CssClass="form-control"></asp:TextBox>    
                    </div> 
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbgalones" Text="Galones:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtgalones" CssClass="form-control"></asp:TextBox>
                    </div>                    
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">    
                        <asp:Label runat="server" ID="lbDescripcion" Text="Descripcion:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" /> 
                   </div> 
                   <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbfechaAdquisicion" Text="Fecha de adquisición:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtfechaAdquisicion" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbfechaVencimiento" Text="Fecha de vencimiento:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtfechaVencimiento" CssClass="form-control"></asp:TextBox>
                    </div>          
                </div>
                    <div class="form-row">
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lblpagoempresa" Text="Pago empresa:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtpagoempresa" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbpagoestadia" Text="Pago de estadia:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtpagoestadia" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbpagoguardia" Text="Pago de guardia:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtpagoguardia" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-3">
                        <asp:Label runat="server" ID="lbviaticos" Text="Viaticos de motorista:" style="color:black"></asp:Label>
                        <asp:TextBox runat="server" ID="txtviaticos" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>          
            <center><asp:Button runat="server" ID="btnAgregarServicioContra" Text="Agregar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnAgregarServicioContra_Click" ></asp:Button></center>             
            </div>
            <hr />
            </div>
            <center><h2><asp:Label runat="server" ID="lbllistadoservicio" Text="Listado Servicios" style="color:black; font-family:Verdana"></asp:Label></h2></center>
            <br />            
                <div class="form-row">
                    <div class="form-group col-md-2">
                            <asp:Label runat="server" ID="Label2" Text="Tipo Servicio:" style="color:black"></asp:Label>                
                    </div>
                    <div class="form-group col-md-3">
                        <asp:DropDownList ID="ddltiposervicio" runat="server" CssClass="form-control" class="form-control" AutoPostBack="true">
                                <asp:ListItem Text="Alquiler" Value="Alquiler"></asp:ListItem>
                                <asp:ListItem Text="Transporte" Value="Transporte"></asp:ListItem>
                        </asp:DropDownList> 
                    </div>
               </div>
            <center>
            <div>
               <asp:GridView ID="GridListadoServicio" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" >
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                    <Columns>
                         <asp:CommandField SelectText="Editar" ButtonType="Button" ControlStyle-CssClass="btn btn-info" CausesValidation="False" InsertVisible="False" ShowCancelButton="False" ShowEditButton="False" ShowSelectButton="True" >
                         <ControlStyle CssClass="btn btn-info" BackColor="Red"></ControlStyle>
                         </asp:CommandField>
                    </Columns>
                </asp:GridView>
            </div>
            </center>
        </asp:View>

        <asp:View runat="server" ID="V">
            
           
        </asp:View>
    </asp:MultiView>    
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>  
</asp:Content>

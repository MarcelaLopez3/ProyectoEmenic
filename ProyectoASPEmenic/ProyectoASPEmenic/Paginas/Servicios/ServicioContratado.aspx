<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ServicioContratado.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ServicioContratado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Contratos de servicios" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos del servicio</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkTransporte" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbcheckTransporte" Text="Transporte" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkAlquiler" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbcheckAlquiler" Text="Alquiler" style="color:black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblCliente" Text="Cliente:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCliente" CssClass="form-control"></asp:TextBox>    
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lbDescripcion" Text="Descripcion:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" /> 
               </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbPeriodoCobro" Text="Periodo de cobro:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtperiodocobro" CssClass="form-control"></asp:TextBox>    
                </div>
                
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lbSalida" Text="Salida:"  style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSalida" CssClass="form-control" /> 
               </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbretorno" Text="Retorno:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtretorno" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbDestino" Text="Lugar de destino:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtDestino" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbfechaAdquisicion" Text="Fecha de adquisición:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtfechaAdquisicion" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbfechaVencimiento" Text="Fecha de vencimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtfechaVencimiento" CssClass="form-control"></asp:TextBox>
            </div>
           
        </div>
        </div>
    </div>

    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Pagos del servicio</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbpagoempresa" Text="Pago empresa:" style="color:black"></asp:Label>
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
                
            </div>
            <div class="form-row">           
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbviaticos" Text="Viaticos de motorista:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtviaticos" CssClass="form-control"></asp:TextBox>
                </div>     
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lbgalones" Text="Galones:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtgalones" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
       </div>
    </div>
    
    <div>          
        <center><asp:Button runat="server" ID="btnGuardarServicioContra" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" ></asp:Button></center>             
   </div>
   <br />

    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>  
</asp:Content>

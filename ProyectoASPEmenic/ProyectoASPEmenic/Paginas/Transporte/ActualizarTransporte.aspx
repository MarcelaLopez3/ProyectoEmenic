<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActualizarTransporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.ActualizarTransporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbTransporte" Text="Actualizar Transportes" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header">
            <h4>Vehículo</h4>
        </div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkCabezal" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbCabezal" Text="Cabezal" Style="color: black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkFurgon" ValidationGroup="1" />
                    <asp:Label runat="server" ID="lbFurgon" Text="Furgon" Style="color: black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="lblplaca" Text="Placa del vehículo:" Style="color: black"></asp:Label>
                    <asp:RequiredFieldValidator ID="RFVPlaca" runat="server" ControlToValidate="txtPlaca" Text="Campo requerido" ErrorMessage="Este campo es requerido"></asp:RequiredFieldValidator><br />
                    <asp:TextBox runat="server" ID="txtPlaca" CssClass="form-control" MaxLength="7"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="REVPlaca" runat="server" ControlToValidate="txtPlaca" Text="Solo se admiten Letras y Numeros con una longitud de 7 caracteres" ErrorMessage="No coincide con el formato" Display="Dynamic" ValidationExpression="[a-zA-Z0-9]+"></asp:RegularExpressionValidator>
                </div>

                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="lbvehiculoequipo" Text="Tipo de equipo:" Style="color: black"></asp:Label>
                    <asp:RequiredFieldValidator ID="RFVEquipo" runat="server" ControlToValidate="txtvehiculoequipo" Text="Campo requerido" ErrorMessage="Este campo es requerido"></asp:RequiredFieldValidator><br />
                    <asp:TextBox runat="server" ID="txtvehiculoequipo" CssClass="form-control" MaxLength="30"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="REVEquipo" runat="server" ControlToValidate="txtvehiculoequipo" Text="Solo se admiten Letras" ErrorMessage="No coincide con el formato" Display="Dynamic" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]+"></asp:RegularExpressionValidator>
                </div>


            </div>
            <div class="form-group col-md-12">
                <asp:Label runat="server" ID="lbvehiculoDescrip" Text="Descripcion del vehículo:" Style="color: black"></asp:Label>
                <asp:RequiredFieldValidator ID="RFVDescripcion" runat="server" ControlToValidate="txtDescripcion" Text="Campo requerido" ErrorMessage="Este campo es requerido"></asp:RequiredFieldValidator><br />
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" Height="150px" MaxLength="100" />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Introduzca 100 caracteres como maximo" ControlToValidate="txtDescripcion" ClientValidationFunction="VerificarCantidad"></asp:CustomValidator>
            </div>

        </div>
    </div>
    <div style="align-content: center">
        <div class="form-row">
            <div class="form-group col-md-12">
                <center><asp:Button runat="server" ID="btnActualizarTransporte" Text="Actualizar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnActualizarTransporte_Click"></asp:Button></center>
            </div>
        </div>
    </div>
    <div>
    </div>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
    <script type="text/javascript">
    function VerificarCantidad(sender, args) {
        args.IsValid = (args.Value.length <= 100);
    }
    </script>
</asp:Content>

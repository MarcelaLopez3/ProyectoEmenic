<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroJuridicos.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.RegistroJuridicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text=" Registro Persona Jurídica" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Generales</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkCliente" />
                    <asp:Label runat="server" ID="Label23" Text="Cliente" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkProveedor" />
                    <asp:Label runat="server" ID="Label24" Text="Proveedor" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkSocio" />
                    <asp:Label runat="server" ID="Label25" Text="Socio" style="color:black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblnombrelegal" Text="Nombre Legal:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombrelegal" CssClass="form-control"></asp:TextBox>    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtnombrelegal" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblnombrecomercial" Text="Nombre Comercial:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombrecomercial" CssClass="form-control" /> 
               </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblgiroactividadeconomica" Text="Giro/Actividad Economica:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtgiroactividadeconomica" CssClass="form-control"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtgiroactividadeconomica" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>  
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lbltamanoempresa" Text="Tamaño Empresa:"  style="color:black"></asp:Label>
                    <asp:DropDownList ID="ddltamanoempresa" runat="server" CssClass="form-control" class="form-control">
                    <asp:ListItem Text="Pequeña" Value="Pequeña"></asp:ListItem>
                    <asp:ListItem Text="Mediana" Value="Mediana"></asp:ListItem>
                    <asp:ListItem Text="Grande" Value="Grande"></asp:ListItem>
                </asp:DropDownList> 
               </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbldireccionubicacion" Text="Dirección/Ubicación:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdireccionubicacion" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  Display="Dynamic" SetFocusOnError="True" 
                CssClass="alert-text" runat="server" ControlToValidate="txtdireccionubicacion" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label2" Text="Municipio/Ciudad:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipiociudad" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtmunicipiociudad" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label1" Text="Departamento/Estado:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdepartamentoestado" CssClass="form-control"></asp:TextBox> 
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtdepartamentoestado" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label3" Text="Pais:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtpais" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6"  Display="Dynamic" SetFocusOnError="True" 
                CssClass="alert-text" runat="server" ControlToValidate="txtpais" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtpais" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label12" Text="Telefono 1:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txttelefono1" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4"  Display="Dynamic" SetFocusOnError="True" 
                CssClass="alert-text" runat="server" ControlToValidate="txttelefono1" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label19" Text="Telefono 2:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txttelefono2" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label20" Text="Telefono 3:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txttelefono3" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label13" Text="Fax:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtFax" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" ID="Label14" Text="Correo electronico principal:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtcorreo1" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5"  Display="Dynamic" SetFocusOnError="True" 
                CssClass="alert-text" runat="server" ControlToValidate="txtcorreo1" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" CssClass="alert-text"
                   ErrorMessage="* Email no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtcorreo1" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" ID="Label21" Text="Correo electronico alternativo:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtcorreo2" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" CssClass="alert-text"
                   ErrorMessage="* Email no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtcorreo2" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label4" Text="Codigo Postal:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtcodigopostal" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        </div>
    </div>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Identificación</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label5" Text="NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNIT" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label6" Text="Fecha expedición NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtfechaexpedicionNIT" CssClass="form-control" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" CssClass="alert-text"
                    ErrorMessage="* Fecha invalida" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtfechaexpedicionNIT" ValidationExpression="^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label7" Text="Nombre según NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombreNIT" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label8" Text="NRC:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNRC" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label9" Text="Fecha expedición NRC:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtfechaexpedicionNRC" CssClass="form-control" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" CssClass="alert-text"
                ErrorMessage="* Fecha invalida" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtfechaexpedicionNRC" ValidationExpression="^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label10" Text="Nombre según NRC:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombreNRC" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <br />        
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Persona Contacto</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label16" Text="Nombre Completo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombrecontacto" CssClass="form-control"  ></asp:TextBox>                             <!-- [A-Za-z ]*-->
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" CssClass="alert-text"
                    ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtnombrecontacto" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]"></asp:RegularExpressionValidator>        
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label17" Text="DUI:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDUIcontacto" CssClass="form-control"  ></asp:TextBox>            
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label18" Text="NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNITcontacto" CssClass="form-control" ></asp:TextBox>            
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label15" Text="Correo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtemailcontacto" CssClass="form-control"  ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" CssClass="alert-text"
                    ErrorMessage ="* Email no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtemailcontacto" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>            
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label22" Text="Telefono:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txttelefonocontacto" CssClass="form-control"  ></asp:TextBox>            
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label26" Text="Celular:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtcelularcontacto" CssClass="form-control"  ></asp:TextBox>            
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Otros</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label11" Text="Observaciones:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobservaciones" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>

    <div style="align-content:center">    
        <div class="form-row">
        <div class="form-group col-md-12">          
            <center><asp:Button runat="server" ID="btnGuardarJuridicos" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGuardarJuridicos_Click"></asp:Button></center>             
       </div>
       </div>
    </div>
   <br />
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroNaturales.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.RegistroNaturales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text=" Registro Persona Natural" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Personales</h4></div>
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
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkEmpleado" />
                    <asp:Label runat="server" ID="Label27" Text="Empleado" style="color:black"></asp:Label>
                </div>
                <div class="form-group col-md-2">
                    <asp:CheckBox runat="server" ID="checkUsuario" />
                    <asp:Label runat="server" ID="Label28" Text="Usuario" style="color:black"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblprimernombre" Text="Primer Nombre:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtprimernombre" CssClass="form-control"></asp:TextBox>                   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtprimernombre" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="alert-text"
                    ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtprimernombre" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]+"></asp:RegularExpressionValidator>  
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblsegundonombre" Text="Segundo Nombre:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtsegundonombre" CssClass="form-control" />                                           <!-- [A-Za-z ]*-->
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" CssClass="alert-text"
                    ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtsegundonombre" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]+"></asp:RegularExpressionValidator>
               </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblprimerapellido" Text="Primer Apellido:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtprimerapellido" CssClass="form-control"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtprimerapellido" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" CssClass="alert-text"
                    ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtprimerapellido" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]+"></asp:RegularExpressionValidator>  
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblsegundoapellido" Text="Segundo Apellido:"  style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtsegundoapellido" CssClass="form-control" /> 
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" CssClass="alert-text"
                    ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtsegundoapellido" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\ ]+"></asp:RegularExpressionValidator>
               </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbledad" Text="Edad:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtedad" CssClass="form-control" TextMode="Number" Text="18"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  Display="Dynamic" SetFocusOnError="True" 
                CssClass="alert-text" runat="server" ControlToValidate="txtedad" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo numeros" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtedad" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label1" Text="Genero:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlgenero" runat="server" CssClass="form-control" class="form-control">
                    <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
                    <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                </asp:DropDownList> 
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label2" Text="Estado Civil:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlestadocivil" runat="server" CssClass="form-control" class="form-control">
                    <asp:ListItem Text="Soltero" Value="Soltero"></asp:ListItem>
                    <asp:ListItem Text="Casado" Value="Casado"></asp:ListItem>
                    <asp:ListItem Text="Divorciado" Value="Divorciado"></asp:ListItem>
                    <asp:ListItem Text="Viudo" Value="Viudo"></asp:ListItem>
                </asp:DropDownList> 
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label3" Text="Profesión/Oficio:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtprofesionoficio" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtprofesionoficio" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" ID="Label12" Text="Dirección Residencia:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdireccionresidencia" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label13" Text="Departamento Residencia:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdepartamentoresidencia" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtdepartamentoresidencia" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label14" Text="Municipio Residencia:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipioresidencia" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtmunicipioresidencia" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" ID="Label9" Text="Fecha Nacimiento(yyyy-mm-dd):" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtfechanacimiento" CssClass="form-control" Text="yyyy-mm-dd"/>     
                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" CssClass="alert-text"
                ErrorMessage="* Fecha invalida" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtfechanacimiento" ValidationExpression="^\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])$"></asp:RegularExpressionValidator>          
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label10" Text="Departamento Nacimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdepartamentonacimiento" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtdepartamentonacimiento" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label11" Text="Municipio Nacimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipionacimiento" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" CssClass="alert-text"
                ErrorMessage="* Solo letras" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtmunicipionacimiento" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
            </div>
        </div>
        </div>
    </div>

    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Identificación</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label4" Text="DUI:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDUI" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label5" Text="NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNIT" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label15" Text="No. Licencia:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnumerolicencia" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label6" Text="Pasaporte:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtpasaporte" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">                
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label7" Text="Nombre Otro:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombreotro" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label8" Text="No. Otro:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnumerootro" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
       </div>
    </div>

    <div class="card border-primary mb-3">  
       <div class="card-header"><h4>Datos Contacto</h4></div>  
       <div class="card-body text-primary">
           <div class="form-row">
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label17" Text="Telefono 1:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txttelefono1" CssClass="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4"  Display="Dynamic" SetFocusOnError="True" 
                   CssClass="alert-text" runat="server" ControlToValidate="txttelefono1" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                   <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" CssClass="alert-text"
                   ErrorMessage="* Numero no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txttelefono1" ValidationExpression="^([7|6|2][0-9]{3})+(-){0,1}[0-9]{4}"></asp:RegularExpressionValidator>--%>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label20" Text="Telefono 2:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txttelefono2" CssClass="form-control"></asp:TextBox>
                   <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" CssClass="alert-text"
                   ErrorMessage="* Numero no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txttelefono2" ValidationExpression="^([7|6|2][0-9]{3})+(-){0,1}[0-9]{4}"></asp:RegularExpressionValidator>--%>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label21" Text="Telefono 3:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txttelefono3" CssClass="form-control"></asp:TextBox>
                   <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" CssClass="alert-text"
                   ErrorMessage="* Numero no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txttelefono3" ValidationExpression="^([7|6|2][0-9]{3})+(-){0,1}[0-9]{4}"></asp:RegularExpressionValidator>--%>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label18" Text="Celular:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtcelular" CssClass="form-control"></asp:TextBox>
                   <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" CssClass="alert-text"
                   ErrorMessage="* Numero no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtcelular" ValidationExpression="^([7|6|2][0-9]{3})+(-){0,1}[0-9]{4}"></asp:RegularExpressionValidator>--%>
               </div>
           </div>
           <div class="form-row">
               <div class="form-group col-md-6">
                   <asp:Label runat="server" ID="Label19" Text="Correo Electrónico Principal:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtemail1" CssClass="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5"  Display="Dynamic" SetFocusOnError="True" 
                   CssClass="alert-text" runat="server" ControlToValidate="txtemail1" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" CssClass="alert-text"
                   ErrorMessage="* Email no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtemail1" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group col-md-6">
                   <asp:Label runat="server" ID="Label22" Text="Correo Electrónico Alterno:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtemail2" CssClass="form-control"></asp:TextBox>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" CssClass="alert-text"
                   ErrorMessage="* Email no valido" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtemail2" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"></asp:RegularExpressionValidator>
               </div>
           </div>
       </div>      
    </div>
      
   <div class="card border-primary mb-3">  
       <div class="card-header"><h4>Otros</h4></div>  
       <div class="card-body text-primary">
           <div class="form-row">
               <div class="form-group col-md-12">
                   <asp:Label runat="server" ID="Label16" Text="Observaciones:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtobservaciones" CssClass="form-control"></asp:TextBox>
               </div>
           </div>
       </div>      
    </div> 
    
    <div style="align-content:center">    
        <div class="form-row">
            <div class="form-group col-md-12">      
                <center><asp:Button runat="server" ID="btnGuardarNaturales" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGuardarNaturales_Click"></asp:Button></center>   
            </div>
        </div>
   </div>
   <br />
<script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

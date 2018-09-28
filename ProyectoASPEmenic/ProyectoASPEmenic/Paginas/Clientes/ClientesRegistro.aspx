<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClientesRegistro.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.ClientesRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Persona Natural" style="color:black; font-family:'Times New Roman', Times, serif"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Personales</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblprimernombre" Text="Primer Nombre:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtprimernombre" CssClass="form-control"></asp:TextBox>    
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblsegundonombre" Text="Segundo Nombre:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtsegundonombre" CssClass="form-control" /> 
               </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblprimerapellido" Text="Primer Apellido:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtprimerapellido" CssClass="form-control"></asp:TextBox>    
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblsegundoapellido" Text="Segundo Apellido:"  style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtsegundoapellido" CssClass="form-control" /> 
               </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="lbledad" Text="Edad:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtedad" CssClass="form-control"></asp:TextBox>
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
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label14" Text="Municipio Residencia:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipioresidencia" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" ID="Label9" Text="Fecha Nacimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtfechanacimiento" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label10" Text="Departamento Nacimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdepartamentonacimiento" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label11" Text="Municipio Nacimiento:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipionacimiento" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="txtDUI" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label5" Text="NIT:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNIT" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label15" Text="No. Licencia:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtlicencia" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="txtotro" CssClass="form-control"></asp:TextBox>
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
   
<script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>    
</asp:Content>

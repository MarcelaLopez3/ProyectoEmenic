<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroJuridicos.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.RegistroJuridicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Persona Jurídica" style="color:black; font-family:'Times New Roman', Times, serif"></asp:Label></h1></center>
    <br />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Generales</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblrazonsocial" Text="Razón Social:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtrazonsocial" CssClass="form-control"></asp:TextBox>    
                </div>
                <div class="form-group col-md-3">    
                    <asp:Label runat="server" ID="lblnombrecomercial" Text="Nombre Comercial:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtnombrecomercial" CssClass="form-control" /> 
               </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="lblgiroactividadeconomica" Text="Giro/Actividad Economica:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtgiroactividadeconomica" CssClass="form-control"></asp:TextBox>    
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
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label2" Text="Municipio/Ciudad:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtmunicipiociudad" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label1" Text="Departamento/Estado:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtdepartamentoestado" CssClass="form-control"></asp:TextBox> 
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label3" Text="Pais:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtpais" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label12" Text="Telefono:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txttelefono" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label13" Text="Fax:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtFax" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label14" Text="Correo electronico:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtcorreoelectronico" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server" ID="Label4" Text="Codigo Postal:" style="color:black"></asp:Label>
                <asp:TextBox runat="server" ID="txtcodifopostal" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="txtfechaexpedicionNIT" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="txtfechaexpedicónNRC" CssClass="form-control"></asp:TextBox>
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
        <div class="card-header"><h4>Otros</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label15" Text="Representante Legal:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtrepresentantelegal" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label11" Text="Observaciones:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobservaciones" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

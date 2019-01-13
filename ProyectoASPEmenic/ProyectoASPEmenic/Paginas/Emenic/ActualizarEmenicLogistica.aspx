<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ActualizarEmenicLogistica.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Emenic.ActualizarEmenicLogistica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblemenic" Text=" Actualizar Datos EMENIC" style="color:black; font-family:Verdana"></asp:Label></h1></center>
     </br>
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos EMENIC S.A de C.V</h4></div>        
        <div class="card-body text-primary">
        <hr />
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label1" Text="Objetivo General:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobjetivogeneral" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtobjetivogeneral" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div> 
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label2" Text="Objetivo Especifico 1:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobjetivoespecifico1" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtobjetivoespecifico1" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div> 
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label3" Text="Objetivo Especifico 2:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobjetivoespecifico2" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtobjetivoespecifico2" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div>  
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label4" Text="Objetivo Especifico 3:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtobjetivoespecifico3" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtobjetivoespecifico3" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div> 
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label5" Text="Misión:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtmision" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtmision" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div> 
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label6" Text="Visión:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtvision" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtvision" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label7" Text="Valores:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtvalores" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtvalores" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div>  
            <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label8" Text="Descripción:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtdescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtdescripcion" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div>  
            <div class="form-row">
            <div class="form-group col-md-12">
                    <asp:Label runat="server" ID="Label9" Text="Servicios:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtservicios" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9"  Display="Dynamic" SetFocusOnError="True" 
                    CssClass="alert-text" runat="server" ControlToValidate="txtservicios" ErrorMessage="* Valor Requerido"></asp:RequiredFieldValidator> 
            </div>
        </div>        
    </div>

    <div style="align-content:center">    
        <div class="form-row">
        <div class="form-group col-md-12">          
            <center><asp:Button runat="server" ID="btnActualizarEmenic" Text="Actualizar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnActualizarEmenic_Click"></asp:Button></center>             
       </div>
       </div>
    </div>
   <br />
</asp:Content>

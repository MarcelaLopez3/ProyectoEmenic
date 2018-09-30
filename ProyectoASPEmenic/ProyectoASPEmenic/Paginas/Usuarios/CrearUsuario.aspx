<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Usuarios.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content-wrapper">
        <div class="container-fluid">
            <asp:Label Text="Prueba dropdownlist" runat="server"  ></asp:Label>
            <asp:DropDownList runat="server" ID="ddlUsers" CssClass="form-control" ></asp:DropDownList>
        </div>
    </div>
</asp:Content>

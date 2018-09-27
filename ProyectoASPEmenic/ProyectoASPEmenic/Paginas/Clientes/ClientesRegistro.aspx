<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClientesRegistro.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Clientes.ClientesRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DdlClientes" runat="server" CssClass="form-control" class="form-control">
            <asp:ListItem Text="Registro de Clientes" Value="1"></asp:ListItem>
            <asp:ListItem Text="Listado completo de Clientes" Value="2"></asp:ListItem>
    </asp:DropDownList> 
    <br />
    FORMULARIOS
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListadoEmenic.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Emenic.ListadoEmenic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lblpersonanatural" Text="Nosotros" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <center>
         <div class="form-row">
            <div class="form-group col-md-3">                
            </div>
            <div class="form-group col-md-3">
            </div>
            <div class="form-group col-md-3">                               
            </div>
            <div class="form-group col-md-3">  
                 <asp:Button ID="btnDashboard" runat="server" CssClass="form-control" class="form-control" Text="Ir a Dashboard" BackColor="Red" ForeColor="White" OnClick="btnDashboard_Click" ></asp:Button>                
            </div>
        </div>
        <br />
        <center><h2><asp:Label runat="server" ID="Label1" Text="Información de EMENIC" style="color:black; font-family:Verdana"></asp:Label></h2></center>
        <asp:GridView ID="GridListadoEmenic1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridListadoEmenic1_RowEditing" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="" ButtonType="Button" ControlStyle-CssClass="btn btn-info" CausesValidation="False" InsertVisible="False" ShowCancelButton="False" ShowDeleteButton="False" ShowEditButton="True" EditText="Ver" >
                <ControlStyle CssClass="btn btn-info" BackColor="Red"></ControlStyle>
                 </asp:CommandField>   
            </Columns>
        </asp:GridView>
        <br />
        <hr />
        <center><h2><asp:Label runat="server" ID="Label2" Text="Información Organizacional de EMENIC" style="color:black; font-family:Verdana"></asp:Label></h2></center>
        <asp:GridView ID="GridListadoEmenic2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridListadoEmenic2_RowEditing" >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                 <asp:CommandField SelectText="" ButtonType="Button" ControlStyle-CssClass="btn btn-info" CausesValidation="False" InsertVisible="False" ShowCancelButton="False" ShowDeleteButton="False" ShowEditButton="True" EditText="Ver" >
                <ControlStyle CssClass="btn btn-info" BackColor="Red"></ControlStyle>
                 </asp:CommandField>   
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>

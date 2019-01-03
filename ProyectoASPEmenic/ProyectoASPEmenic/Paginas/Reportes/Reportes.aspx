<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Reportes.Reportes" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <center><h1><asp:Label runat="server" ID="lblReportes" Text="Gestión de Informes" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <div class="form-row">
        <div class="col-md-4">
                <h5>Seleccione el año a mostrar </h5>
            </div>
        <div class="col-md-3">
        <asp:DropDownList runat="server" ID="ddlYear" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
    <br />
    <center>
    <div class="container">
          <div class="form-row">
             <div class="col">
                <asp:Button runat="server" type="button" ID="btnGenerarRegistros" Text="Reporte Registro de Actividades" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" ></asp:Button>
               </div>
              <div class="col">
                 <asp:Button runat="server" type="button" ID="btnGenerarVentas" Text="Reporte Ventas Mensuales" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" OnClick="btnGenerarVentas_Click" ></asp:Button>
               </div>                
              </div>
           </div>
        </center>  
    <br />     
    <asp:MultiView runat="server" ID="mvReport">
        <asp:View runat="server" ID="vRegistro">
            
        </asp:View>
        <asp:View runat="server" ID="vVentas">
            <center>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="705px" style="margin-right: 15px">
            </rsweb:ReportViewer>
                </center>
        </asp:View>
    </asp:MultiView>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../js/sb-admin.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroCartaporte.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Servicios.RegistroCartaporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1><asp:Label runat="server" ID="lbcartaporte" Text="Carta Porte" style="color:black; font-family:Verdana"></asp:Label></h1></center>
    <br />
    <asp:HiddenField ID="hfIdServicio" runat="server" />
    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Datos Generales</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                <asp:Label runat="server" ID="lblConductor" Text="Conductor:" style="color:black"></asp:Label>
                    <ajaxToolkit:ComboBox ID="ddlConductor" runat="server" AutoCompleteMode="SuggestAppend" DropDownStyle="DropDownList"  ListItemHoverCssClass="form-control" BorderStyle="Double" >
                            </ajaxToolkit:ComboBox>                
            </div>
                <div class="form-group col-md-2">
                <asp:Label runat="server" ID="lbIDcabezal" Text="Cabezal:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlIDcabezal" runat="server" CssClass="form-control" class="form-control">   
                </asp:DropDownList> 
            </div>
               <div class="form-group col-md-2">
                <asp:Label runat="server" ID="lbIDfurgon" Text="Furgon:" style="color:black"></asp:Label>
                <asp:DropDownList ID="ddlIDfurgon" runat="server" CssClass="form-control" class="form-control">
                </asp:DropDownList> 
            </div>                
                <div class="form-group col-md-2">
                    <asp:Label runat="server" ID="lbfechacartaporte" Text="Fecha:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtfechacartaporte" CssClass="form-control" TextMode="Date"></asp:TextBox>    
                </div>
        </div>
        </div>
    </div>

    <div class="card border-primary mb-3">
        <div class="card-header"><h4>Especificaciones</h4></div>
        <div class="card-body text-primary">
            <div class="form-row">
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label4" Text="Aduana de ingreso:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtaduanaentrada" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">                    
                    <asp:Label runat="server" ID="Label7" Text="Lugar de embarque:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtlugarembarque" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-">
                    <asp:Label runat="server" ID="Label5" Text="Aduana de salida:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtaduanasalida" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label15" Text="Lugar de destino:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtdestinocartaporte" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">                
                 <div class="form-group col-md-6">
                    <asp:Label runat="server" ID="Label6" Text="Transporte:" style="color:black"></asp:Label>
                    <asp:DropDownList runat="server" ID="ddlTransporte" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="form-group col-md-3">
                    <asp:Label runat="server" ID="Label8" Text="Codigo:" style="color:black"></asp:Label>
                    <asp:TextBox runat="server" ID="txtcodigocartaporte" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
       </div>
    </div>

    <div class="card border-primary mb-3">  
       <div class="card-header"><h4>Detalles</h4></div>  
       <div class="card-body text-primary">
           <div class="form-row">
               <div class="form-group col-md-6">
                   <asp:Label runat="server" ID="Label10" Text="Contenido:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtcontenidocartaporte" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
               </div>
               <div class="form-group col-md-6">
                   <asp:Label runat="server" ID="Label11" Text="Descripción de Contenido:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtdescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label21" Text="Cantidad:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtcantidad" CssClass="form-control" onkeypress="return isNumber(event)"></asp:TextBox>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label18" Text="Peso neto (kg):" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtpesoneto" CssClass="form-control" class='allow_decimal'></asp:TextBox>
               </div>          
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label19" Text="Total de peso bruto (kg):" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txttotalpesobruto" CssClass="form-control" class='allow_decimal'></asp:TextBox>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label22" Text="Total de peso neto (kg):" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txttotalpesoneto" CssClass="form-control" class='allow_decimal'></asp:TextBox>
               </div>
               <div class="form-group col-md-3">
                   <asp:Label runat="server" ID="Label23" Text="Flete:" style="color:black"></asp:Label>
                   <asp:TextBox runat="server" ID="txtflete" CssClass="form-control" class='allow_decimal'></asp:TextBox>
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
                   <asp:TextBox runat="server" ID="txtobservacionescartaporte" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
               </div>
           </div>
       </div>      
    </div> 
    
    <div style="align-content:center">    
        <div class="form-row">
            <div class="form-group col-md-6">      
                <center><asp:Button runat="server" ID="btnGuardarcartaporte" Text="Guardar" CssClass="btn btn-info btn-block" style="color:white; background-color:red; border-color:red; width:auto" ></asp:Button></center>   
            </div>
        </div>
   </div>
   <br />

    <script type="text/javascript">
        function isNumber(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }

        $(".allow_decimal").on("input", function (evt) {
            var self = $(this);
            self.val(self.val().replace(/[^0-9\.]/g, ''));
            if ((evt.which != 46 || self.val().indexOf('.') != -1) && (evt.which < 48 || evt.which > 57)) {
                evt.preventDefault();
            }
        });
    </script>
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</asp:Content>

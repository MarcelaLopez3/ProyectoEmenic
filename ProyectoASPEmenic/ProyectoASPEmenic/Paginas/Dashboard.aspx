<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center"><img src="../Imagenes/Logo_emenic_2.png" alt="IMG" class="rounded mx-auto d-block"/></div>
    <!-- Breadcrumbs-->
          <ol class="breadcrumb">
            <li class="breadcrumb-item">
              <a>Dashboard</a>
            </li>
          </ol>
          <!-- Icon Cards-->
          <div class="row">
            <div class="col-xl-3 col-sm-6 mb-3">
              <div class="card text-white bg-primary o-hidden h-100">
                <div class="card-body">
                  <div class="card-body-icon">
                    <i class="fas fa-user-tie"></i>
                  </div>
                  <div class="mr-5"><b><asp:Label runat="server" ID="lblClientes"/></b> Clientes</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="Clientes/ListadoClientes.aspx">
                  <span class="float-left">Ver Listado</span>
                  <span class="float-right">
                    <i class="fas fa-angle-right"></i>
                  </span>
                </a>
              </div>
            </div>
            <div class="col-xl-3 col-sm-6 mb-3">
              <div class="card text-white bg-warning o-hidden h-100">
                <div class="card-body">
                  <div class="card-body-icon">
                    <i class="fas fa-truck"></i>
                  </div>
                  <div class="mr-5"><b><asp:Label runat="server" ID="lblEquipo"></asp:Label></b> Equipos</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="Transporte/ListadoTransporte.aspx">
                  <span class="float-left">Ver Listado</span>
                  <span class="float-right">
                    <i class="fas fa-angle-right"></i>
                  </span>
                </a>
              </div>
            </div>
            <div class="col-xl-3 col-sm-6 mb-3">
              <div class="card text-white bg-success o-hidden h-100">
                <div class="card-body">
                  <div class="card-body-icon">
                    <i class="fas fa-file-invoice-dollar"></i>
                  </div>
                  <div class="mr-5"><b><asp:Label ID="lblServicios" runat="server"></asp:Label></b> Servicios Contratados</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="Reportes/Reportes.aspx">
                  <span class="float-left">Ver Listado</span>
                  <span class="float-right">
                    <i class="fas fa-angle-right"></i>
                  </span>
                </a>
              </div>
            </div>
            <div class="col-xl-3 col-sm-6 mb-3">
              <div class="card text-white bg-danger o-hidden h-100">
                <div class="card-body">
                  <div class="card-body-icon">
                    <i class="fas fa-users"></i>
                  </div>
                  <div class="mr-5"><b><asp:Label ID="lblUsuarios" runat="server"></asp:Label></b> Usuarios Activos</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="Usuarios/ListadoUsuarios.aspx">
                  <span class="float-left">Ver Listado</span>
                  <span class="float-right">
                    <i class="fas fa-angle-right"></i>
                  </span>
                </a>
              </div>
            </div>
          </div>
    <br />
    <div>        
        <div class="col-lg-12">
              <div class="card mb-3">
                <div class="card-header">
                  <i class="fas fa-chart-bar"></i>
                  Ventas, costos y utilidades anuales
                    <div class="form-inline float-right">
                    <asp:Label ID="lblYear" runat="server" Text="Año: " Font-Bold="true"></asp:Label>&nbsp;&nbsp;                        
                        <asp:DropDownList ID="ddlYear" runat="server" CssClass="form-control" Width="100px">

                        </asp:DropDownList>
                        </div>
                </div>                       
                <div class="card-body">
                  <canvas id="myBarChart" width="100%" height="50"></canvas>
                </div>
                <div class="card-footer small text-muted">Última fecha de actualización:  <%=DateTime.Now%></div>
              </div>
            </div>
        <%--<div class="row">
        <div class="col-xl-6 col-sm-6 mb-6">
              <div class="card text-white bg-danger o-hidden h-100">
                <div class="card-body">
                    <div class="mr-5">
                        MISIÓN:
                    </div>
                    <a class="card-footer text-white clearfix small">
                        <span class="float-left" style="align-content:center">
                        Satisfacer la necesidad de movilidad de las empresas con un sistema de transporte de carga pesada 
                        de calidad, competitivo y adecuado a sus exigencias.        
                        Ser socios estratégicos de nuestros clientes en transporte terrestre a través de una flota en óptimas
                        condiciones para satisfacer sus necesidades de traslado de mercancía.
                        </span>
                    </a>
                </div>
              </div>
            </div>   
        <div class="col-xl-6 col-sm-6 mb-6">
              <div class="card text-white bg-danger o-hidden h-100">
                <div class="card-body">
                    <div class="mr-5">
                        VISIÓN:
                    </div>
                    <a class="card-footer text-white clearfix small">
                        <span class="float-left" style="align-content:center">
                        Ser reconocido en el mercado de transporte de carga internacional y establecernos dentro 
                            los próximos diez años dentro de las mejores empresas en el mercado, brindando 
                            cada día un mejor servicio, de manera eficiente; estableciendo alianzas estratégicas 
                            comprometidas con las necesidades de nuestros clientes y en la búsqueda de un servicio 
                            cada vez más integral que nos permita alcanzar un reconocido prestigio a nivel nacional 
                            internacional. Así como de ir de la mano con el dinamismo del mundo actual y las nuevas 
                            tendencias del negocio.
                        </span>
                    </a>
                </div>
              </div>
            </div>
        </div>--%>
        <br />   
    </div>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <!-- Core plugin JavaScript-->    
     <script src="../js/jquery-2.2.3.min.js"></script>
    <script src="../js/sb-admin.min.js"></script>
    <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../vendor/jquery-easing/jquery.easing.min.js"></script>
    <script src="../vendor/chart/Chart.min.js"></script>
    <script type="text/javascript" >
        $(document).ready(function () {
                      
            $(window).load(function () {
                Senddata = { "year": $("#ContentPlaceHolder1_ddlYear :selected").val() };
                showGraph(Senddata);
            });


            $("#ContentPlaceHolder1_ddlYear").change(function () {
                Senddata = { "year": $(this).val() };
                showGraph(Senddata);
            });
        }

        );

        function showGraph(Senddata) {
            $.ajax({
                type: 'POST',
                url: 'Dashboard.aspx/GraphBar', // llamando al servicio web para obtener datos
                contentType: "application/json; charset=utf-8",
                dataType: 'json',
                data: JSON.stringify(Senddata),   //pasando el parametro de unidad                  

                success: function (response) {
                    var xmlDoc = $.parseXML(response.d);
                    var xml = $(xmlDoc);
                    var datas = xml.find("Data");
                    var d1 = [];
                    var d2 = [];
                    var d3 = [];
                    var count = 0;
                    $(datas).each(function () {
                        d1.push([$(this).find("Ventas").text()]);
                        d2.push([$(this).find("Costos").text()]);
                        d3.push([$(this).find("Utilidad").text()]);
                        count++;
                    });
                    var data2 = xml.find("MaxMin");
                    var maxValue = 0;
                    var minValue = 0;
                    $(data2).each(function () {
                        maxValue = parseInt($(this).find("Max").text());
                        minValue = parseInt($(this).find("Min").text());
                    });
                    
                    // Set new default font family and font color to mimic Bootstrap's default styling
                    Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
                    Chart.defaults.global.defaultFontColor = '#292b2c';

                    // Bar Chart Example
                    var ctx = document.getElementById("myBarChart");
                    var myLineChart = new Chart(ctx, {
                        type: 'bar',
                        data: {
                            labels: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"],
                            datasets: [{
                                label: "Ventas",
                                backgroundColor: "rgba(46, 134, 193)",
                                borderColor: "rgba(46, 134, 193)",
                                data: d1,
                            }, {
                                label: "Costos",
                                backgroundColor: "rgba(203, 67, 53)",
                                borderColor: "rgba(203, 67, 53)",
                                data: d2,
                            },
                            {
                                label: "Utilidad",
                                backgroundColor: "rgba(46, 204, 113)",
                                borderColor: "rgba(46, 204, 113)",
                                data: d3,
                            }
                            ],

                        },
                        options: {
                            scales: {
                                xAxes: [{
                                    time: {
                                        unit: 'month'
                                    },
                                    gridLines: {
                                        display: false
                                    },
                                    ticks: {
                                        maxTicksLimit: 12
                                    }
                                }],
                                yAxes: [{
                                    ticks: {
                                        min: minValue,
                                        max: maxValue,
                                        maxTicksLimit: 10
                                    },
                                    gridLines: {
                                        display: true
                                    }
                                }],
                            },
                            legend: {
                                display: false
                            }
                            
                        }
                    }); 
                } ,
                error: function (ex) {
                    alert('No hay registro de ventas')
                    console.log(JSON.stringify(ex));
                }
            });
        }
        
        </script>
</asp:Content>

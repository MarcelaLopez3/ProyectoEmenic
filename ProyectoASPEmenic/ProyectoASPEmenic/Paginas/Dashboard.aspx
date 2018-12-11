<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                    <i class="fas fa-fw fa-comments"></i>
                  </div>
                  <div class="mr-5">26 New Messages!</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="#">
                  <span class="float-left">View Details</span>
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
                    <i class="fas fa-fw fa-list"></i>
                  </div>
                  <div class="mr-5">11 New Tasks!</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="#">
                  <span class="float-left">View Details</span>
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
                    <i class="fas fa-fw fa-shopping-cart"></i>
                  </div>
                  <div class="mr-5">123 New Orders!</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="#">
                  <span class="float-left">View Details</span>
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
                    <i class="fas fa-fw fa-life-ring"></i>
                  </div>
                  <div class="mr-5">13 New Tickets!</div>
                </div>
                <a class="card-footer text-white clearfix small z-1" href="#">
                  <span class="float-left">View Details</span>
                  <span class="float-right">
                    <i class="fas fa-angle-right"></i>
                  </span>
                </a>
              </div>
            </div>
          </div>
    <br />
    <div>
        <center><img src="../Imagenes/Logo_emenic_2.png" alt="IMG"/></center>
        <br />
        <div class="row">
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
        </div>
        <br />   
    </div>
</asp:Content>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProyectoASPEmenic.Paginas.Publicidad.Index" %>

<!DOCTYPE html>
<html>
<head>
    <title>.:: EMENIC S.A. de C.V. ::.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
    </script>
    <link rel="stylesheet" href="../../css/bootstrap.css">
    <!-- Bootstrap-Core-CSS -->

    <link href="../../css/style.css" rel='stylesheet' type='text/css' />
    <link href="../../css/simpleLightbox.css" rel='stylesheet' type='text/css' />
    <link href="../../css/popup-box.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../../css/fontawesome-all.css" rel="stylesheet">

    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">
</head>

<body>
    <header>
        <div class="header">
            <nav class="navbar navbar-expand-lg navbar-light" style="background-color: #000000;">
                <a class="navbar-brand" href="index.aspx">
                    <asp:Image ID="imglogo" runat="server" ImageUrl="~/Imagenes/Logo_emenic.png" Height="20%" Width="20%" />
                    EMENIC</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarText">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                            <a class="nav-link" href="index.aspx">Home <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link scroll" href="#about">About</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link scroll" href="#services">Services</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link scroll" href="#works">Our Works</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link scroll" href="#pricing">Pricing</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link scroll" href="#contact">Contact</a>
                        </li>
                    </ul>
                    <div class="navbar-text">
                        <p class="right-p"><i class="fas fa-phone" aria-hidden="true"></i>098-765-4321</p>
                    </div>
                </div>
            </nav>
        </div>
    </header>
    <!--/banner-->
    <section class="banner-top">
        <div class="banner">
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                </ol>
                <div class="carousel-inner" role="listbox">
                    <div class="carousel-item active">
                        <asp:Image ID="imageEmenic1" runat="server" ImageUrl="~/Imagenes/Emenic1.jpg" />
                        <div class="carousel-caption">
                            <h3>Transport your cargo everywhere</h3>
                            <p>We offer a diverse range of transportation services from project cargo to international transportation and domestic retail distribution and delivery.</p>
                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter" role="button">Read More <i class="fa fa-caret-right" aria-hidden="true"></i></a>


                        </div>
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="imageEmenic2" runat="server" ImageUrl="~/Imagenes/Emenic2.png" />
                        <div class="carousel-caption">
                            <h3>World wide transport for everyone</h3>
                            <p>We offer a diverse range of transportation services from project cargo to international transportation and domestic retail distribution and delivery.</p>
                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter" role="button">Read More <i class="fa fa-caret-right" aria-hidden="true"></i></a>


                        </div>
                    </div>
                    <div class="carousel-item ">
                        <asp:Image ID="imageEmenic3" runat="server" ImageUrl="~/Imagenes/Emenic3.jpg" />
                        <div class="carousel-caption">
                            <h3>24*7 services provided for Customers</h3>
                            <p>We offer a diverse range of transportation services from project cargo to international transportation and domestic retail distribution and delivery.</p>
                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter" role="button">Read More <i class="fa fa-caret-right" aria-hidden="true"></i></a>
                        </div>
                    </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <!-- banner-bottom -->
            <div class="banner-bottom">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-4 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <div class="col-xs-3 wthree_banner_bottom_grid_left">
                                        <div class="agile_banner_bottom_grid_left_grid hvr-radial-out">
                                            <span class="fas fa-car" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="col-xs-9 wthree_banner_bottom_grid_right">
                                        <h4>ROAD TRANSPORT</h4>
                                        <p>Morbi viverra lacus commodo felis semper, eu iaculis lectus feugiat.</p>

                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <div class="col-xs-3 wthree_banner_bottom_grid_left">
                                        <div class="agile_banner_bottom_grid_left_grid hvr-radial-out">
                                            <span class="fas fa-fighter-jet" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="col-xs-9 wthree_banner_bottom_grid_right">
                                        <h4>AIR FREIGHT</h4>
                                        <p>Morbi viverra lacus commodo felis semper, eu iaculis lectus feugiat.</p>

                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 agileits_banner_bottom_left">
                            <div class="agileinfo_banner_bottom_pos">
                                <div class="w3_agileits_banner_bottom_pos_grid">
                                    <div class="col-xs-3 wthree_banner_bottom_grid_left">
                                        <div class="agile_banner_bottom_grid_left_grid hvr-radial-out">
                                            <span class="fas fa-subway" aria-hidden="true"></span>
                                        </div>
                                    </div>
                                    <div class="col-xs-9 wthree_banner_bottom_grid_right">
                                        <h4>RAILWAY LOGISTICS</h4>
                                        <p>Morbi viverra lacus commodo felis semper, eu iaculis lectus feugiat.</p>

                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
            <!-- //banner-bottom -->

        </div>
    </section>
    <!--//banner-->
    <!-- stats -->
    <div class="stats" id="stats">
        <div class="w3-head-all  mb-5">
            <h3>About us</h3>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-3  col-sm-6 w3layouts_stats_left w3_counter_grid">
                    <span class="fas fa-globe" aria-hidden="true"></span>
                    <p class="counter">45</p>
                    <h3>PROJECTS DONE</h3>
                </div>
                <div class="col-md-3 col-sm-6 w3layouts_stats_left w3_counter_grid1">
                    <span class="fas fa-users" aria-hidden="true"></span>
                    <p class="counter">165</p>
                    <h3>HAPPY CLIENTS</h3>
                </div>
                <div class="col-md-3 col-sm-6 w3layouts_stats_left w3_counter_grid2">
                    <span class="fas fa-handshake" aria-hidden="true"></span>
                    <p class="counter">563</p>
                    <h3>TEAM WORKERS </h3>
                </div>
                <div class="col-md-3 col-sm-6 w3layouts_stats_left w3_counter_grid3">
                    <span class="fa fa-trophy" aria-hidden="true"></span>
                    <p class="counter">245</p>
                    <h3>YEARS IN MARKET </h3>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //stats -->
    <!-- services-bottom -->
    <div class="services-bottom wthree-sub py-5" id="about">
        <div class="container py-md-3">
            <div class="row">
                <div class="col-sm-6 col-xs-4 services_bottom_grid_left">
                    <h3>Logistics Solutions</h3>
                    <p>Lorem ipsum dolor sit amet</p>
                    <a href="#" data-toggle="modal" data-target="#exampleModalCenter" role="button">Read More</a>
                </div>
                <div class="col-sm-6 col-xs-8 services_bottom_grid_right">
                    <h3>Why <span>Choose Us</span></h3>
                    <div class='bar_group'>
                        <div class='bar_group__bar thin elastic' label='100% Safe Delivery' value='230'></div>
                        <div class='bar_group__bar thin elastic' label='100% support' value='130'></div>
                        <div class='bar_group__bar thin elastic' label='Fast & On Time' value='160'></div>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //services-bottom -->
    <!-- services-main -->
    <div class="testimonials  py-5" id="services">
        <div class="container  py-md-3">
            <div class="w3-head-all  mb-5">
                <h3>Our Services</h3>
            </div>
            <div class="w3_testimonials_grids">
                <section class="slider">
                    <div class="flexslider">
                        <ul class="slides">
                            <li>
                                <!-- s1 -->
                                <div class="about-top w3ls-agile row">
                                    <div class="col-md-6 ser_w3">
                                        <asp:Image ID="imgService1" runat="server" ImageUrl="~/Imagenes/service1.jpg" CssClass="img-responsive img-fluid" />
                                    </div>
                                    <div class="col-md-6 come">
                                        <div class="about-wel">
                                            <h5>A Few Words About Our
												<span>logistics</span>
                                            </h5>
                                            <p>
                                                Masagni dolores eoquie int Basmodi temporant, ut laboreas dolore magnam aliquam kuytase uaeraquis autem vel eum iure
												reprehend.Unicmquam eius, Basmodi temurer sehsMunim.
                                            </p>
                                            <ul>
                                                <li>
                                                    <i class="fas fa-check"></i>100% satisfied customers</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Quality service</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Worldwide Locations</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Modern Vehicles Fleet</li>

                                            </ul>
                                        </div>
                                        <div class="button-styles">
                                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter">More Info</a>
                                            <a href="#contact" class="button2-w3l scroll">Contact Us</a>
                                        </div>
                                    </div>

                                </div>

                                <!-- //welcome -->

                            </li>
                            <li>
                                <div class="about-top w3ls-agile row">
                                    <div class="col-md-6 come">
                                        <div class="about-wel">
                                            <h5>A Few Words About Our
											<span>logistics</span>
                                            </h5>
                                            <p>
                                                Masagni dolores eoquie int Basmodi temporant, ut laboreas dolore magnam aliquam kuytase uaeraquis autem vel eum iure
											reprehend.Unicmquam eius, Basmodi temurer sehsMunim.
                                            </p>
                                            <ul>
                                                <li>
                                                    <i class="fas fa-check"></i>100% satisfied customers</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Quality service</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Worldwide Locations</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Modern Vehicles Fleet</li>

                                            </ul>
                                        </div>
                                        <div class="button-styles">
                                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter">More Info</a>
                                            <a href="#contact" class="button2-w3l scroll">Contact Us</a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 ser_w3">
                                        <asp:Image ID="imageService2" runat="server" ImageUrl="~/Imagenes/service2.jpg" CssClass="img-responsive img-fluid" />
                                    </div>

                                </div>
                            </li>

                            <li>
                                <div class="about-top w3ls-agile row">
                                    <div class="col-md-6 ser_w3">
                                        <asp:Image ID="imageServices3" runat="server" ImageUrl="~/Imagenes/service3.jpg" CssClass="img-responsive img-fluid" />
                                    </div>
                                    <div class="col-md-6 come">
                                        <div class="about-wel">
                                            <h5>A Few Words About Our
							<span>logistics</span>
                                            </h5>
                                            <p>
                                                Masagni dolores eoquie int Basmodi temporant, ut laboreas dolore magnam aliquam kuytase uaeraquis autem vel eum iure
							reprehend.Unicmquam eius, Basmodi temurer sehsMunim.
                                            </p>
                                            <ul>
                                                <li>
                                                    <i class="fas fa-check"></i>100% satisfied customers</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Quality service</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Worldwide Locations</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Modern Vehicles Fleet</li>

                                            </ul>
                                        </div>
                                        <div class="button-styles">
                                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter">More Info</a>
                                            <a href="#contact" class="button2-w3l scroll">Contact Us</a>
                                        </div>
                                    </div>

                                </div>

                            </li>
                            <li>
                                <div class="about-top w3ls-agile row">

                                    <div class="col-md-6 come">
                                        <div class="about-wel">
                                            <h5>A Few Words About Our
							<span>Transport</span>
                                            </h5>
                                            <p>
                                                Masagni dolores eoquie int Basmodi temporant, ut laboreas dolore magnam aliquam kuytase uaeraquis autem vel eum iure
							reprehend.Unicmquam eius, Basmodi temurer sehsMunim.
                                            </p>
                                            <ul>
                                                <li>
                                                    <i class="fas fa-check"></i>100% satisfied customers</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Quality service</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Worldwide Locations</li>
                                                <li>
                                                    <i class="fas fa-check"></i>Modern Vehicles Fleet</li>

                                            </ul>
                                        </div>
                                        <div class="button-styles">
                                            <a href="#" data-toggle="modal" data-target="#exampleModalCenter">More Info</a>
                                            <a href="#contact" class="button2-w3l scroll">Contact Us</a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 ser_w3">
                                        <asp:Image ID="imageService4" runat="server" ImageUrl="~/Imagenes/service4.jpg" CssClass="img-responsive img-fluid" />
                                    </div>
                                </div>

                            </li>
                        </ul>
                    </div>
                </section>

            </div>
        </div>
    </div>
    <!-- //services-main -->
    <!-- team -->
    <div class="team  py-5" id="team">
        <div class="container py-md-3">
            <div class="w3-head-all  mb-5">
                <h3>Our Team</h3>
            </div>
            <div class="teamgrids row">
                <div class="col-md-3  col-sm-6 teamgrid1">
                    <asp:Image ID="imageT1" runat="server" ImageUrl="~/Imagenes/t1.jpg" CssClass="img-responsive img-fluid" />
                    <div class="teaminfo">
                        <h3>Franklin</h3>
                        <div class="team-social">
                            <a href="#"><i class="fab fa-facebook-f"></i></a>
                            <a href="#"><i class="fab fa-twitter"></i></a>
                            <a href="#"><i class="fab fa-pinterest-p"></i></a>
                            <a href="#"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                        <p>Manager</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 teamgrid1">
                    <asp:Image ID="imageT2" runat="server" ImageUrl="~/Imagenes/t2.jpg" CssClass="img-responsive img-fluid" />
                    <div class="teaminfo">
                        <h3>Guptill</h3>
                        <div class="team-social">
                            <a href="#"><i class="fab fa-facebook-f"></i></a>
                            <a href="#"><i class="fab fa-twitter"></i></a>
                            <a href="#"><i class="fab fa-pinterest-p"></i></a>
                            <a href="#"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                        <p>Shipper</p>

                    </div>
                </div>
                <div class="col-md-3 col-sm-6 teamgrid1">
                    <asp:Image ID="imageT3" runat="server" ImageUrl="~/Imagenes/t3.jpg" CssClass="img-responsive img-fluid" />
                    <div class="teaminfo">
                        <h3>Mitchel</h3>
                        <div class="team-social">
                            <a href="#"><i class="fab fa-facebook-f"></i></a>
                            <a href="#"><i class="fab fa-twitter"></i></a>
                            <a href="#"><i class="fab fa-pinterest-p"></i></a>
                            <a href="#"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                        <p>Transporter</p>

                    </div>
                </div>
                <div class="col-md-3 col-sm-6 teamgrid1">
                    <asp:Image ID="imageT4" runat="server" ImageUrl="~/Imagenes/t4.jpg" CssClass="img-responsive img-fluid" />
                    <div class="teaminfo">
                        <h3>John Paul</h3>
                        <div class="team-social">
                            <a href="#"><i class="fab fa-facebook-f"></i></a>
                            <a href="#"><i class="fab fa-twitter"></i></a>
                            <a href="#"><i class="fab fa-pinterest-p"></i></a>
                            <a href="#"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                        <p>Director</p>

                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //team -->
    <!--/Projects-->
    <section class="services  py-5" id="works">
        <div class="container  py-md-3">
            <div class="w3-head-all  mb-5">
                <h3>Our Works</h3>
            </div>
            <div class="row inner-sec-w3layouts-agileinfo">

                <div class="col-md-4  proj_gallery_grid" data-aos="zoom-in">
                    <div class="section_1_gallery_grid">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal1.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imgGal1" runat="server" ImageUrl="~/Imagenes/gal1.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal2.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imagegal2" runat="server" ImageUrl="~/Imagenes/gal2.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal3.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal3" runat="server" ImageUrl="~/Imagenes/gal3.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4  proj_gallery_grid" data-aos="zoom-in">
                    <div class="section_1_gallery_grid">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal4.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal4" runat="server" ImageUrl="~/Imagenes/gal4.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal5.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal5" runat="server" ImageUrl="~/Imagenes/gal5.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal6.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal6" runat="server" ImageUrl="~/Imagenes/gal6.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4  proj_gallery_grid" data-aos="zoom-in">
                    <div class="section_1_gallery_grid">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal7.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal7" runat="server" ImageUrl="~/Imagenes/gal7.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="~/Imagenes/gal8.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal8" runat="server" ImageUrl="~/Imagenes/gal8.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="section_1_gallery_grid" data-aos="zoom-in">
                        <a title="Donec sapien massa, placerat ac sodales ac, feugiat quis est." href="images/gal9.jpg" class="img-fluid">
                            <div class="section_1_gallery_grid1">
                                <asp:Image ID="imageGal9" runat="server" ImageUrl="~/Imagenes/gal9.jpg" CssClass="img-responsive img-fluid" />
                                <div class="proj_gallery_grid1_pos">
                                    <h3>Transport</h3>

                                </div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--//Projects-->
    <!--main pricing table-->
    <div class="main  py-5" id="pricing">
        <div class="container py-md-3">
            <div class="w3-head-all  mb-5">
                <h3>Our Pricings</h3>
            </div>
            <div class="pricing-grids-info">
                <section class="slider grid">
                    <ul class="slides">
                        <li>
                            <div class="pricing-grid grid-one">
                                <div class="price-img">
                                    <asp:Image ID="imageP1" runat="server" ImageUrl="~/Imagenes/p1.jpg" AlternateText="img" CssClass="img-fluid" />
                                </div>
                                <div class="w3ls-top">
                                    <h3>Road Freigh</h3>
                                    <h4>30 <span class="sup">$</span> </h4>
                                    <div class="clear"></div>
                                </div>
                                <div class="w3ls-bottom">
                                    <ul class="count">
                                        <li>Unlimited Extra Features</li>
                                        <li>10*Free PSD files</li>
                                        <li>30/10 Tech Support</li>
                                        <li>1*Month Free resources</li>
                                    </ul>
                                    <div class="more">
                                        <a class="book" href="#" data-toggle="modal" data-target="#myModal3">Select</a>
                                    </div>
                                </div>
                            </div>
                            <div class="pricing-grid grid-two">
                                <div class="price-img">
                                    <asp:Image ID="imageP2" runat="server" ImageUrl="~/Imagenes/p2.jpg" AlternateText="img" CssClass="img-fluid" />
                                </div>
                                <div class="w3ls-top">
                                    <h3>Ocean Freight</h3>
                                    <h4>50 <span class="sup">$</span> </h4>
                                    <div class="clear"></div>
                                </div>
                                <div class="w3ls-bottom">
                                    <ul class="count">
                                        <li>Unlimited Extra Features</li>
                                        <li>10*Free PSD files</li>
                                        <li>30/10 Tech Support</li>
                                        <li>1*Month Free resources</li>
                                    </ul>
                                    <div class="more">
                                        <a class="book" href="#" data-toggle="modal" data-target="#myModal3">Select</a>
                                    </div>
                                </div>
                            </div>
                            <div class="pricing-grid grid-three">
                                <div class="price-img">
                                    <asp:Image ID="imageP3" runat="server" ImageUrl="~/Imagenes/p3.jpg" AlternateText="img" CssClass="img-fluid" />
                                </div>
                                <div class="w3ls-top">
                                    <h3>Train Freight</h3>
                                    <h4>70 <span class="sup">$</span> </h4>
                                    <div class="clear"></div>
                                </div>
                                <div class="w3ls-bottom">
                                    <ul class="count">
                                        <li>Unlimited Extra Features</li>
                                        <li>10*Free PSD files</li>
                                        <li>30/10 Tech Support</li>
                                        <li>1*Month Free resources</li>
                                    </ul>
                                    <div class="more">
                                        <a class="book" href="#" data-toggle="modal" data-target="#myModal3">Select</a>
                                    </div>
                                </div>
                            </div>
                            <div class="clear"></div>
                        </li>

                    </ul>
            </div>
        </div>
    </div>
    </section>
			<!-- main pricing table -->
    <!-- /contact us -->
    <div class="w3-contact py-5" id="contact">
        <div class="container py-md-3">
            <div class="w3-head-all  mb-5">
                <h3>Contact us</h3>
            </div>
            <div class="w3-contact1">
                <h1>100%</h1>
                <h2>The Best Shipping Services</h2>
                <p><a class="book popup-with-zoom-anim button-isi zoomIn animated" data-wow-delay=".5s" href="#small-dialog"><span class="fa fa-paper-plane-o"></span>Contact Us</a></p>
            </div>
        </div>
    </div>
    <!-- //contact us -->
    <!-- map -->
    <div class="w3l-map">
        <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d10446319.224363243!2d-101.53641366492933!3d40.52127641868563!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sin!4v1509778660321" style="border: 0" allowfullscreen></iframe>
    </div>
    <!-- Newsletter -->
    <section class="newsletter text-center py-5">
        <div class="container py-md-3">
            <h3 class="heading text-center text-uppercase mb-5">FOR BEST PRICE AND SERVICE </h3>
            <div class="w3l_header_contact_details_agile">
                <p>Give us a Call</p>
                <a class="w3l_header_contact_details_agile-info_inner"><span><i class="fas fa-phone"></i></span>919-993-1000-001 </a>
            </div>

            <div class="subscribe_inner">
                <p class="mb-4">Maecenas ac euismod eros. Aliquam a suscipit nibh. Aliquam iaculis erat porta mauris fermentum lacinia. </p>
                <div class="social mt-sm-5 mt-3">
                    <h4>Follow us</h4>
                    <ul class="d-flex mt-3 justify-content-center">
                        <li class="mx-2"><a href="#"><span class="fab fa-facebook"></span></a></li>
                        <li class="mx-2"><a href="#"><span class="fab fa-twitter-square"></span></a></li>
                        <li class="mx-2"><a href="#"><span class="fas fa-rss-square"></span></a></li>
                        <li class="mx-2"><a href="#"><span class="fab fa-linkedin"></span></a></li>
                        <li class="mx-2"><a href="#"><span class="fab fa-google-plus-square"></span></a></li>
                    </ul>
                </div>
            </div>

        </div>
    </section>
    <footer>
        <div class="container py-3 py-md-4">
            <div class="footer">
                <p class="text-center">© 2018 Transload. All Rights Reserved | Design by <a href="http://www.W3Layouts.com" target="_blank">W3Layouts</a></p>
            </div>
        </div>
    </footer>
    <!-- footer -->

    <!-- //Newsletter -->
    <!-- /modal -->
    <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title text-uppercase" id="exampleModalLongTitle">Transload</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="imageModal" runat="server" ImageUrl="~/Imagenes/modal.jpg" AlternateText="Modal Image" CssClass="img-fluid mb-4" />
                    Vivamus eget est in odio tempor interdum. Mauris maximus fermentum arcu, ac finibus ante. Sed mattis risus at ipsum elementum, ut auctor turpis cursus. Sed sed odio pharetra, aliquet velit cursus, vehicula enim. Mauris porta aliquet magna, eget laoreet ligula.
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
        </div>
    </div>
    <!-- //modal -->
    <!-- Modal2 -->
    <div class="modal fade" id="myModal3" tabindex="-1" role="dialog">
        <div class="modal-dialog">
            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>

                    <div class="signin-form profile">
                        <h3 class="agileinfo_sign">Sign Up</h3>
                        <div class="login-form">
                            <form action="#" method="post">
                                <input type="text" name="name" placeholder="Username" required="">
                                <input type="email" name="email" placeholder="Email" required="">
                                <input type="password" name="password" placeholder="Password" required="">
                                <input type="password" name="password" placeholder="Confirm Password" required="">
                                <input type="submit" value="Sign Up">
                            </form>
                        </div>
                        <p><a href="#">By clicking register, I agree to your terms</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //Modal2 -->

    <!-- /magnific-popup -->
    <div class="pop-up">
        <div id="small-dialog" class="mfp-hide book-form">
            <h3 class="sub-head-w3-agileits subscribe_us text-center py-3 head_size_con">Contact us </h3>
            <!-- banner -->
            <div class="video" data-vide-bg="video/ship">
                <div class="center-container">
                    <div class="bg-agile">
                        <h3>Order Contact</h3>
                        <div class="login-form">
                            <form action="#" method="post">
                                <input type="text" name="Name" placeholder="Full name" required="" />
                                <input type="text" name="Number" placeholder="Phone number" required="" />
                                <input type="email" name="Email" placeholder="Email" required="" />
                                <h3>Shipping address</h3>
                                <div class="left-w3-agile">
                                    <select class="form-control form2-color">
                                        <option>Choose your country</option>
                                        <option>Argentina</option>
                                        <option>Georgia</option>
                                        <option>Dominica</option>
                                        <option>Lithuania</option>
                                        <option>Monaco</option>
                                    </select>
                                    <input type="text" name="Region" placeholder="State/province/region" required="" />
                                </div>
                                <div class="right-agileits">
                                    <input type="text" name="City" placeholder="City" required="" />
                                    <input type="text" name="Zip/postal code" placeholder="Zip/postal code" required="" />
                                </div>
                                <textarea name="message" value="Address" placeholder="Street address"></textarea>
                                <input type="submit" value="Submit">
                            </form>
                        </div>
                    </div>
                    <!-- //banner -->

                </div>
            </div>
        </div>
    </div>
    <!-- //magnific-popup -->

    <!-- js -->
    <script type="text/javascript" src="../../js/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="../../js/bootstrap.js"></script>
    <!-- Necessary-JavaScript-File-For-Bootstrap -->
    <!-- //js -->


    <!-- stats -->
    <script src="../../js/jquery.waypoints.min.js"></script>
    <script src="../../js/jquery.countup.js"></script>
    <script>
        $('.counter').countUp();
    </script>
    <!-- //stats -->
    <!-- bars.js -->
    <script src="../../js/bars.js"></script>
    <!-- //bars.js -->

    <!-- flexSlider (for testimonials) -->
    <link rel="stylesheet" href="../../css/flexslider.css" type="text/css" media="screen" property="" />
    <script defer src="../../js/jquery.flexslider.js"></script>
    <script>
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide",
                start: function (slider) {
                    $('body').removeClass('loading');
                }
            });
        });
    </script>
    <!-- //flexSlider (for testimonials) -->
    <!-- simpleLightbox -->
    <script src="../../js/simpleLightbox.js"></script>
    <script>
        $('.proj_gallery_grid a').simpleLightbox();
    </script>
    <!-- //simpleLightbox -->
    <!--popup-js-->
    <script src="../../js/jquery.magnific-popup.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {
            $('.popup-with-zoom-anim').magnificPopup({
                type: 'inline',
                fixedContentPos: false,
                fixedBgPos: true,
                overflowY: 'auto',
                closeBtnInside: true,
                preloader: false,
                midClick: true,
                removalDelay: 300,
                mainClass: 'my-mfp-zoom-in'
            });

        });
    </script>
    <!--//popup-js-->
    <!-- start-smooth-scrolling -->
    <script src="../../js/move-top.js"></script>
    <script src="../../js/easing.js"></script>
    <script>
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();

                $('html,body').animate({
                    scrollTop: $(this.hash).offset().top
                }, 1000);
            });
        });
    </script>
    <!-- //end-smooth-scrolling -->

    <!-- smooth-scrolling-of-move-up -->
    <script>
        $(document).ready(function () {
			/*
			var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
			};
			*/

            $().UItoTop({
                easingType: 'easeOutQuart'
            });

        });
    </script>
    <!-- //smooth-scrolling-of-move-up -->


    <!-- smooth scrolling js -->
    <script src="../../js/SmoothScroll.min.js"></script>
    <!-- //smooth scrolling js -->
</body>
</html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ServicioContratado : System.Web.UI.Page
    {
        //Variables globales
        Conexion conexion = new Conexion();
        string query = "";
        DateTime Hoy = DateTime.Today;
        bool bandera_ser = false;

        //Propiedades
        public int IdDestinatario
        {
            set
            {
                this.hfIdDestinatario.Value = value.ToString();
            }
            get
            {
                return string.IsNullOrEmpty(this.hfIdDestinatario.Value) ? 0 : int.Parse(hfIdDestinatario.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MVServicios.SetActiveView(VNuevoServicio);
            CargandoTablaServicio();
            CargarDestinos();
        }

        protected void CargandoTablaServicio()
        {
            if (IsPostBack)
            {
                TipoServicio(ddltiposervicio.SelectedValue);
            }
            else if (!IsPostBack)
            {
                ddltiposervicio.SelectedValue = "Transporte";
                TipoServicio(ddltiposervicio.SelectedValue);
            }
        }

        protected void TipoServicio(string tipo)
        {
            //recuperando el IdCliente
            string VarSer = Request.QueryString["ser"];

            //Seleccionar tipo
            if (tipo == "Alquiler")
            {
                query = "SELECT Id,PagoEmpresa,FechaAdquisicion,FechaVencimiento,Descripcion" +
                " FROM serviciocontratado WHERE IdCliente = "+ VarSer + " AND Alquiler = 1;";
                EjecutarGridServicio(query);
            }
            else if (tipo == "Transporte")
            {
                query = "SELECT Id,PagoEmpresa,FechaAdquisicion,FechaVencimiento,Descripcion" +
               " FROM serviciocontratado WHERE IdCliente = " + VarSer + " AND Transporte = 1;";
                EjecutarGridServicio(query);
            }
        }

        //Función para llenar combobox
        protected void CargarDestinos()
        {
            string query = "SELECT IdPersona,NombreComercial from persona where PersonaJuridica=1 and Activo=1";
            conexion.IniciarConexion();
            ddlDestinoConsignatario.DataSource = conexion.llena(query);
            conexion.CerrarConexion();
            ddlDestinoConsignatario.DataTextField = "NombreComercial";
            ddlDestinoConsignatario.DataValueField = "IdPersona";
            ddlDestinoConsignatario.DataBind();            
        }

        protected void EjecutarGridServicio(string query)
        {
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoServicio);
            conexion.CerrarConexion();
        }

        protected void btnCartaPorte_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroCartaporte.aspx");
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroContrato.aspx");
        }

        protected void btnAgregarServicioContra_Click(object sender, EventArgs e)
        {
            if (btnAgregarServicioContra.Text == "Agregar")
            {
                if (!string.IsNullOrEmpty(ddlDestinoConsignatario.SelectedValue) || (string.IsNullOrWhiteSpace(ddlDestinoConsignatario.SelectedValue) && checkAlquiler.Checked) )
                {
                    //recuperando el IdCliente
                    string VarSer = Request.QueryString["ser"];

                    //recuperando entradas
                    bool Transporte = checkTransporte.Checked;
                    bool Alquiler = checkAlquiler.Checked;
                    string FechaAdquisicion = txtfechaAdquisicion.Text;
                    string FechaVencimiento = txtfechaVencimiento.Text;
                    string Descripcion = txtDescripcion.Text;
                    string PeriodoCobro = txtperiodocobro.Text;
                    bool Retorno = checkRetorno.Checked;
                    int IdConsigatario = string.IsNullOrWhiteSpace(ddlDestinoConsignatario.SelectedValue)? 1:Int32.Parse(ddlDestinoConsignatario.SelectedValue);
                    string PagoEmpresa = txtpagoempresa.Text;
                    string PagoEstadia = txtpagoestadia.Text;
                    string PagoGuardia = txtpagoguardia.Text;
                    string Galones = txtgalones.Text;
                    string ViaticosMotorista = txtviaticos.Text;
                    float PagoMotorista = string.IsNullOrEmpty(txtPagoMotorista.Text) ? 0 : float.Parse(txtPagoMotorista.Text);
                    float PrecioCombustible = string.IsNullOrEmpty(txtPrecioCombustible.Text) ? 0 : float.Parse(txtPrecioCombustible.Text);
                    float GastosVarios = string.IsNullOrEmpty(txtGastosVarios.Text) ? 0 : float.Parse(txtGastosVarios.Text);

                    //Verificar que haya 1 bandera activa (transporte o alquiler) pero que no esten vacias y que no esten ambas
                    if (Transporte == true && Alquiler == true)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Solo puede ser un tipo de servicio a la vez, Alquiler o Transporte.')", true);
                    }
                    else if (Transporte == false && Alquiler == false)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe marcar un servicio, Alquiler o Transporte.')", true);
                    }
                    else
                    {
                        bandera_ser = true;
                    }

                    //verificando el contenido de la fecha, si no tiene nada entonces se le coloca la fecha de hoy
                    if (FechaAdquisicion == "" || FechaAdquisicion == " ")
                    {
                        FechaAdquisicion = FormatoFecha(Hoy.ToShortDateString());
                    }
                    
                    if (FechaVencimiento == "" || FechaVencimiento == " ")
                    {
                        FechaVencimiento = FormatoFecha(Hoy.ToShortDateString());
                    }

                    //seteando un valor a las variables decimal
                    if (PagoEmpresa == "" || PagoEmpresa == " ")
                    {
                        PagoEmpresa = "0";
                    }

                    if (PagoEstadia == "" || PagoEstadia == " ")
                    {
                        PagoEstadia = "0";
                    }

                    if (PagoGuardia == "" || PagoGuardia == " ")
                    {
                        PagoGuardia = "0";
                    }

                    if (ViaticosMotorista == "" || ViaticosMotorista == " ")
                    {
                        ViaticosMotorista = "0";
                    }

                    if (Galones == "" || Galones == " ")
                    {
                        Galones = "0";
                    }

                    //inicio insert de servicio
                    if (bandera_ser == true)
                    {
                        query = "INSERT INTO serviciocontratado(IdCliente,IdConsignatorio,Transporte,Alquiler," +
                            "FechaAdquisicion,Descripcion,PeriodoCobro,Retorno,FechaVencimiento,PagoEmpresa," +
                            "PagoEstadia,PagoGuardia,ViaticosMotorista,Galones,PrecioCombustible,PagoMotorista,GastosVarios) VALUES (" + VarSer + "," + IdConsigatario +
                            "," + Transporte + "," + Alquiler + ",'" + FechaAdquisicion + "','" + Descripcion + "','" + PeriodoCobro +
                            "'," + Retorno + ",'" + FechaVencimiento + "'," + PagoEmpresa + "," + PagoEstadia +
                            "," + PagoGuardia + "," + ViaticosMotorista + "," + Galones + "," + PrecioCombustible + "," + PagoMotorista +
                            "," + GastosVarios + ")";
                        //enviar consulta a Mysql
                        conexion.IniciarConexion();
                        conexion.EnviarQuery(query);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                        CargandoTablaServicio();
                        LimpiarFormulario();
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido ingresar registro.')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un destinatario.')", true);
                }
            }
            else if (btnAgregarServicioContra.Text == "Actualizar")
            {
                //recuperando entradas de update
                bool Transporte = checkTransporte.Checked;
                bool Alquiler = checkAlquiler.Checked;
                string FechaAdquisicion = txtfechaAdquisicion.Text;
                string FechaVencimiento = txtfechaVencimiento.Text;
                string Descripcion = txtDescripcion.Text;
                string PeriodoCobro = txtperiodocobro.Text;
                bool Retorno = checkRetorno.Checked;
                int IdConsigatario = string.IsNullOrEmpty(ddlDestinoConsignatario.SelectedValue) ? IdDestinatario : Int32.Parse(ddlDestinoConsignatario.SelectedValue);
                string PagoEmpresa = txtpagoempresa.Text;
                string PagoEstadia = txtpagoestadia.Text;
                string PagoGuardia = txtpagoguardia.Text;
                string Galones = txtgalones.Text;
                string ViaticosMotorista = txtviaticos.Text;
                float PagoMotorista = string.IsNullOrEmpty(txtPagoMotorista.Text) ? 0 : float.Parse(txtPagoMotorista.Text);
                float PrecioCombustible = string.IsNullOrEmpty(txtPrecioCombustible.Text) ? 0 : float.Parse(txtPrecioCombustible.Text);
                float GastosVarios = string.IsNullOrEmpty(txtGastosVarios.Text) ? 0 : float.Parse(txtGastosVarios.Text);

                //Verificar que haya 1 bandera activa (transporte o alquiler) pero que no esten vacias y que no esten ambas
                if (Transporte == true && Alquiler == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Solo puede ser un tipo de servicio a la vez, Alquiler o Transporte.')", true);
                }
                else if (Transporte == false && Alquiler == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe marcar un servicio, Alquiler o Transporte.')", true);
                }
                else
                {
                    bandera_ser = true;
                }

                //verificando el contenido de las fechas, si no tiene nada entonces se le coloca la fecha de hoy
                if (FechaAdquisicion == "" || FechaAdquisicion == " ")
                {
                    FechaAdquisicion = FormatoFecha(Hoy.ToShortDateString());
                }

                if (FechaVencimiento == "" || FechaVencimiento == " ")
                {
                    FechaVencimiento = FormatoFecha(Hoy.ToShortDateString());
                }

                //seteando un valor a las variables decimal
                if (PagoEmpresa == "" || PagoEmpresa == " ")
                {
                    PagoEmpresa = "0";
                }

                if (PagoEstadia == "" || PagoEstadia == " ")
                {
                    PagoEstadia = "0";
                }

                if (PagoGuardia == "" || PagoGuardia == " ")
                {
                    PagoGuardia = "0";
                }

                if (ViaticosMotorista == "" || ViaticosMotorista == " ")
                {
                    ViaticosMotorista = "0";
                }

                if (Galones == "" || Galones == " ")
                {
                    Galones = "0";
                }


                if (bandera_ser == true)
                {
                    query = "UPDATE serviciocontratado SET Transporte = " + Transporte + ", Alquiler = " + Alquiler +
                        ", FechaAdquisicion = '" + FechaAdquisicion + "', FechaVencimiento = '" + FechaVencimiento +
                        "', Descripcion = '" + Descripcion + "', PeriodoCobro = '" + PeriodoCobro + "', Retorno = " +
                        Retorno + ", IdConsignatorio = " + IdConsigatario + ", PagoEmpresa = " + PagoEmpresa +
                        ", PagoEstadia = " + PagoEstadia + ", PagoGuardia = " + PagoGuardia + ", Galones = '" +
                        Galones + "', ViaticosMotorista = " + ViaticosMotorista + " WHERE Id = " + HFUpdateId.Value;

                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    conexion.CerrarConexion();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
                    btnAgregarServicioContra.Text = "Agregar";
                    LimpiarFormulario();
                    CargandoTablaServicio();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido ingresar registro.')", true);
                }
            }
        }

        protected void GridListadoServicio_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                //Inicio de update del servicio
                query = "SELECT IdConsignatorio,Transporte,Alquiler,FechaAdquisicion,Descripcion,"+
                    "PeriodoCobro,Retorno,FechaVencimiento,PagoEmpresa,PagoEstadia,PagoGuardia,"+
                    "ViaticosMotorista,Galones,Id,PrecioCombustible,PagoMotorista,GastosVarios FROM serviciocontratado WHERE Id = " + e.CommandArgument;

                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    if (conexion.reg.GetValue(0) != null || conexion.reg.GetValue(0).ToString() != "")
                    {
                        ddlDestinoConsignatario.SelectedValue = ddlDestinoConsignatario.Items.FindByValue(conexion.reg.GetValue(0).ToString()).Value;
                        IdDestinatario = int.Parse(ddlDestinoConsignatario.SelectedValue);
                    }
                    else
                        ddlDestinoConsignatario.Text = "";

                    checkTransporte.Checked = conexion.reg.GetBoolean(1);
                    checkAlquiler.Checked = conexion.reg.GetBoolean(2);

                    if (conexion.reg.GetValue(3) != null || conexion.reg.GetValue(3).ToString() != "")
                    {
                        string fecha = conexion.reg.GetValue(3).ToString();
                        txtfechaAdquisicion.Text = FormatoFecha(fecha);
                    }                        
                    else
                        txtfechaAdquisicion.Text = "";

                    if (conexion.reg.GetValue(4) != null || conexion.reg.GetValue(4).ToString() != "")
                        txtDescripcion.Text = conexion.reg.GetValue(4).ToString();
                    else
                        txtDescripcion.Text = "";

                    if (conexion.reg.GetValue(5) != null || conexion.reg.GetValue(5).ToString() != "")
                        txtperiodocobro.Text = conexion.reg.GetValue(5).ToString();
                    else
                        txtperiodocobro.Text = "";

                    checkRetorno.Checked = conexion.reg.GetBoolean(6);

                    if (conexion.reg.GetValue(7) != null || conexion.reg.GetValue(7).ToString() != "")
                    {
                        string fecha = conexion.reg.GetValue(7).ToString();
                        txtfechaVencimiento.Text = FormatoFecha(fecha);                           
                    }                       
                    else
                        txtfechaVencimiento.Text = "";

                    if (conexion.reg.GetValue(8) != null || conexion.reg.GetValue(8).ToString() != "")
                        txtpagoempresa.Text = conexion.reg.GetValue(8).ToString();
                    else
                        txtpagoempresa.Text = "";

                    if (conexion.reg.GetValue(9) != null || conexion.reg.GetValue(9).ToString() != "")
                        txtpagoestadia.Text = conexion.reg.GetValue(9).ToString();
                    else
                        txtpagoestadia.Text = "";

                    if (conexion.reg.GetValue(10) != null || conexion.reg.GetValue(10).ToString() != "")
                        txtpagoguardia.Text = conexion.reg.GetValue(10).ToString();
                    else
                        txtpagoguardia.Text = "";

                    if (conexion.reg.GetValue(11) != null || conexion.reg.GetValue(11).ToString() != "")
                        txtviaticos.Text = conexion.reg.GetValue(11).ToString();
                    else
                        txtviaticos.Text = "";

                    if (conexion.reg.GetValue(12) != null || conexion.reg.GetValue(12).ToString() != "")
                        txtgalones.Text = conexion.reg.GetValue(12).ToString();
                    else
                        txtgalones.Text = "";

                    if (conexion.reg.GetValue(14) != null || conexion.reg.GetValue(14).ToString() != "")
                        txtPrecioCombustible.Text = conexion.reg.GetValue(14).ToString();
                    else
                        txtPrecioCombustible.Text = "";

                    if (conexion.reg.GetValue(15) != null || conexion.reg.GetValue(15).ToString() != "")
                        txtPagoMotorista.Text = conexion.reg.GetValue(15).ToString();
                    else
                        txtPagoMotorista.Text = "";

                    if (conexion.reg.GetValue(16) != null || conexion.reg.GetValue(16).ToString() != "")
                        txtGastosVarios.Text = conexion.reg.GetValue(16).ToString();
                    else
                        txtGastosVarios.Text = "";

                    HFUpdateId.Value = conexion.reg.GetValue(13).ToString();

                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Puede iniciar la modificación de información.')", true);
                conexion.CerrarConexion();
                btnAgregarServicioContra.Text = "Actualizar";
            }
            else if(e.CommandName == "Documento")
            {
                if(ddltiposervicio.SelectedValue == "Transporte")
                {
                    int existe_cp=0;
                    query = "select if (EXISTS(select * from cartaporte where IdServicio=" + e.CommandArgument + "),1,0)";
                    conexion.IniciarConexion();
                    conexion.RecibeQuery(query);
                    while(conexion.reg.Read())
                    {
                        existe_cp = conexion.reg.GetInt32(0);
                    }
                    conexion.CerrarConexion();
                    if (existe_cp == 0)
                    {
                        //Redirige al formulario de cartaporte
                        Response.Redirect("~/Paginas/Servicios/RegistroCartaporte.aspx?srv=" + e.CommandArgument);
                    }
                    else
                    {
                        Response.Redirect("~/Paginas/Servicios/ActualizarCartaporte.aspx?srv=" + e.CommandArgument);
                    }

                }
                else if(ddltiposervicio.SelectedValue == "Alquiler")
                {
                    int existe_cp = 0;
                    query = "select if (EXISTS(select * from contrato where IdServicio=" + e.CommandArgument + "),1,0)";
                    conexion.IniciarConexion();
                    conexion.RecibeQuery(query);
                    while (conexion.reg.Read())
                    {
                        existe_cp = conexion.reg.GetInt32(0);
                    }
                    conexion.CerrarConexion();
                    if (existe_cp == 0)
                    {
                        //Redirige al formulario de cartaporte
                        Response.Redirect("~/Paginas/Servicios/RegistroContrato.aspx?srv=" + e.CommandArgument);
                    }
                    else
                    {
                        Response.Redirect("~/Paginas/Servicios/ActulizarContrato.aspx?srv=" + e.CommandArgument);
                    }
                }
            }
        }

        protected string FormatoFecha(string fecha)
        {
            DateTime nueva = DateTime.Parse(fecha);
            string nueva2 = nueva.ToShortDateString();
            string[] words = nueva2.Split('/');
            string devuelve = words[2] + "-" + words[1] + "-" + words[0];
            return devuelve;
        }

        protected void LimpiarFormulario()
        {
            checkAlquiler.Checked = false;
            checkRetorno.Checked = false;
            checkTransporte.Checked = false;
            txtperiodocobro.Text = "";
            txtgalones.Text = "";
            txtDescripcion.Text = "";
            txtfechaAdquisicion.Text = "";
            txtfechaVencimiento.Text = "";
            txtpagoempresa.Text = "";
            txtpagoestadia.Text = "";
            txtpagoguardia.Text = "";
            txtviaticos.Text = "";
        }
    }
}
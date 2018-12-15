using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Emenic
{
    public partial class ActualizarEmenic : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        Validacion validacion = new Validacion();
        string query = "";
        DateTime Hoy = DateTime.Today;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MetodoBloquear();
                string VarAct = Request.QueryString["act"];

                string query = "SELECT NombreLegal,NombreComercial,Giro,Tamano,Ubicacion,MunicipioCiudad," +
               "DepartamentoEstado,Pais,Telefono1,Telefono2,Telefono3,Fax,Email1,Email2,CodigoPostal,NIT," +
               "FechaExpedicionNIT,NombreSegunNIT,NRC,FechaExpedicionNRC,NombreSegunNRC,NombreContacto," +
               "DUIContacto,NITContacto,EmailContacto,TelefonoContacto,CelularContacto,Observaciones " +
               "FROM persona WHERE IdPersona=" + VarAct;

                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido
                    if (conexion.reg.GetValue(0) != null || conexion.reg.GetValue(0).ToString() != "")
                        txtnombrelegal.Text = conexion.reg.GetValue(0).ToString();
                    else
                        txtnombrelegal.Text = "";

                    if (conexion.reg.GetValue(1) != null || conexion.reg.GetValue(1).ToString() != "")
                        txtnombrecomercial.Text = conexion.reg.GetValue(1).ToString();
                    else
                        txtnombrecomercial.Text = "";

                    if (conexion.reg.GetValue(2) != null || conexion.reg.GetValue(2).ToString() != "")
                        txtgiroactividadeconomica.Text = conexion.reg.GetValue(2).ToString();
                    else
                        txtgiroactividadeconomica.Text = "";

                    ddltamanoempresa.SelectedValue = conexion.reg.GetString(3);

                    if (conexion.reg.GetValue(4) != null || conexion.reg.GetValue(4).ToString() != "")
                        txtdireccionubicacion.Text = conexion.reg.GetValue(4).ToString();
                    else
                        txtdireccionubicacion.Text = "";

                    if (conexion.reg.GetValue(5) != null || conexion.reg.GetValue(5).ToString() != "")
                        txtmunicipiociudad.Text = conexion.reg.GetValue(5).ToString();
                    else
                        txtmunicipiociudad.Text = "";

                    if (conexion.reg.GetValue(6) != null || conexion.reg.GetValue(6).ToString() != "")
                        txtdepartamentoestado.Text = conexion.reg.GetValue(6).ToString();
                    else
                        txtdepartamentoestado.Text = "";

                    if (conexion.reg.GetValue(7) != null || conexion.reg.GetValue(7).ToString() != "")
                        txtpais.Text = conexion.reg.GetValue(7).ToString();
                    else
                        txtpais.Text = "";

                    if (conexion.reg.GetValue(8) != null || conexion.reg.GetValue(8).ToString() != "")
                        txttelefono1.Text = conexion.reg.GetValue(8).ToString();
                    else
                        txttelefono1.Text = "";

                    if (conexion.reg.GetValue(9) != null || conexion.reg.GetValue(9).ToString() != "")
                        txttelefono2.Text = conexion.reg.GetValue(9).ToString();
                    else
                        txttelefono2.Text = "";

                    if (conexion.reg.GetValue(10) != null || conexion.reg.GetValue(10).ToString() != "")
                        txttelefono3.Text = conexion.reg.GetValue(10).ToString();
                    else
                        txttelefono3.Text = "";

                    if (conexion.reg.GetValue(11) != null || conexion.reg.GetValue(11).ToString() != "")
                        txtFax.Text = conexion.reg.GetValue(11).ToString();
                    else
                        txtFax.Text = "";

                    if (conexion.reg.GetValue(12) != null || conexion.reg.GetValue(12).ToString() != "")
                        txtcorreo1.Text = conexion.reg.GetValue(12).ToString();
                    else
                        txtcorreo1.Text = "";

                    if (conexion.reg.GetValue(13) != null || conexion.reg.GetValue(13).ToString() != "")
                        txtcorreo2.Text = conexion.reg.GetValue(13).ToString();
                    else
                        txtcorreo2.Text = "";

                    if (conexion.reg.GetValue(14) != null || conexion.reg.GetValue(14).ToString() != "")
                        txtcodigopostal.Text = conexion.reg.GetValue(14).ToString();
                    else
                        txtcodigopostal.Text = "";

                    if (conexion.reg.GetValue(15) != null || conexion.reg.GetValue(15).ToString() != "")
                        txtNIT.Text = conexion.reg.GetValue(15).ToString();
                    else
                        txtNIT.Text = "";

                    if (conexion.reg.GetValue(16) != null || conexion.reg.GetValue(16).ToString() != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetValue(16).ToString());
                        txtfechaexpedicionNIT.Text = fecha;
                    }
                    else
                        txtfechaexpedicionNIT.Text = "";

                    if (conexion.reg.GetValue(17) != null || conexion.reg.GetValue(17).ToString() != "")
                        txtnombreNIT.Text = conexion.reg.GetValue(17).ToString();
                    else
                        txtnombreNIT.Text = "";

                    if (conexion.reg.GetValue(18) != null || conexion.reg.GetValue(18).ToString() != "")
                        txtNRC.Text = conexion.reg.GetValue(18).ToString();
                    else
                        txtNRC.Text = "";

                    if (conexion.reg.GetValue(19) != null || conexion.reg.GetValue(19).ToString() != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetValue(19).ToString());
                        txtfechaexpedicionNRC.Text = fecha;
                    }
                    else
                        txtfechaexpedicionNRC.Text = "";

                    if (conexion.reg.GetValue(20) != null || conexion.reg.GetValue(20).ToString() != "")
                        txtnombreNRC.Text = conexion.reg.GetValue(20).ToString();
                    else
                        txtnombreNRC.Text = "";

                    if (conexion.reg.GetValue(21) != null || conexion.reg.GetValue(21).ToString() != "")
                        txtnombrecontacto.Text = conexion.reg.GetValue(21).ToString();
                    else
                        txtnombrecontacto.Text = "";

                    if (conexion.reg.GetValue(22) != null || conexion.reg.GetValue(22).ToString() != "")
                        txtDUIcontacto.Text = conexion.reg.GetValue(22).ToString();
                    else
                        txtDUIcontacto.Text = "";

                    if (conexion.reg.GetValue(23) != null || conexion.reg.GetValue(23).ToString() != "")
                        txtNITcontacto.Text = conexion.reg.GetValue(23).ToString();
                    else
                        txtNITcontacto.Text = "";

                    if (conexion.reg.GetValue(24) != null || conexion.reg.GetValue(24).ToString() != "")
                        txtemailcontacto.Text = conexion.reg.GetValue(24).ToString();
                    else
                        txtemailcontacto.Text = "";

                    if (conexion.reg.GetValue(25) != null || conexion.reg.GetValue(25).ToString() != "")
                        txttelefonocontacto.Text = conexion.reg.GetValue(25).ToString();
                    else
                        txttelefonocontacto.Text = "";

                    if (conexion.reg.GetValue(26) != null || conexion.reg.GetValue(26).ToString() != "")
                        txtcelularcontacto.Text = conexion.reg.GetValue(26).ToString();
                    else
                        txtcelularcontacto.Text = "";

                    if (conexion.reg.GetValue(27) != null || conexion.reg.GetValue(27).ToString() != "")
                        txtobservaciones.Text = conexion.reg.GetValue(27).ToString();
                    else
                        txtobservaciones.Text = "";                    
                }
                conexion.CerrarConexion();
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

        protected void MetodoBloquear()
        {

        }
    }
}
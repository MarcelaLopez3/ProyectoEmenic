using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Emenic
{
    public partial class ActualizarEmenicLogistica : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        Validacion validacion = new Validacion();
        string query = "";
        DateTime Hoy = DateTime.Today;

        //bandera del contacto
        bool bandera_dui_c = false, bandera_nit_c = false;
        //bandera de la empresa
        bool bandera_nrc_e = false, bandera_nit_e = false;

        //contenidos del contacto
        bool contenido_c = false, contenido_dui_c = false, contenido_nit_c = false, contenido_email_c = false, contenido_telefono_c = false, contenido_celular_c = false;

        //contenidos de la empresa
        bool contenido_nrc_e = false, contenido_nit_e = false;

        //---------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string VarAct = Request.QueryString["act"];

                //consulta
                string query = "SELECT ObjetivoGeneral,ObjetivoEspecifico1,ObjetivoEspecifico2,ObjetivoEspecifico3,"+
                    "Mision,Vision,Valores,Descripcion,Servicios FROM emenic WHERE Id = 1 AND IdPersona = " + VarAct;

                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    if (conexion.reg.GetValue(0) != null || conexion.reg.GetValue(0).ToString() != "")
                        txtobjetivogeneral.Text = conexion.reg.GetValue(0).ToString();
                    else
                        txtobjetivogeneral.Text = "";

                    if (conexion.reg.GetValue(1) != null || conexion.reg.GetValue(1).ToString() != "")
                        txtobjetivoespecifico1.Text = conexion.reg.GetValue(1).ToString();
                    else
                        txtobjetivoespecifico1.Text = "";

                    if (conexion.reg.GetValue(2) != null || conexion.reg.GetValue(2).ToString() != "")
                        txtobjetivoespecifico2.Text = conexion.reg.GetValue(2).ToString();
                    else
                        txtobjetivoespecifico2.Text = "";

                    if (conexion.reg.GetValue(3) != null || conexion.reg.GetValue(3).ToString() != "")
                        txtobjetivoespecifico3.Text = conexion.reg.GetValue(3).ToString();
                    else
                        txtobjetivoespecifico3.Text = "";

                    if (conexion.reg.GetValue(4) != null || conexion.reg.GetValue(4).ToString() != "")
                        txtmision.Text = conexion.reg.GetValue(4).ToString();
                    else
                        txtmision.Text = "";

                    if (conexion.reg.GetValue(5) != null || conexion.reg.GetValue(5).ToString() != "")
                        txtvision.Text = conexion.reg.GetValue(5).ToString();
                    else
                        txtvision.Text = "";

                    if (conexion.reg.GetValue(6) != null || conexion.reg.GetValue(6).ToString() != "")
                        txtvalores.Text = conexion.reg.GetValue(6).ToString();
                    else
                        txtvalores.Text = "";

                    if (conexion.reg.GetValue(7) != null || conexion.reg.GetValue(7).ToString() != "")
                        txtdescripcion.Text = conexion.reg.GetValue(7).ToString();
                    else
                        txtdescripcion.Text = "";

                    if (conexion.reg.GetValue(8) != null || conexion.reg.GetValue(8).ToString() != "")
                        txtservicios.Text = conexion.reg.GetValue(8).ToString();
                    else
                        txtservicios.Text = "";
                }
                conexion.CerrarConexion();
            }
        }


        //funcion para actualizar el registro en pantalla
        protected void btnActualizarEmenic_Click(object sender, EventArgs e)
        {
            //boton para actualizar los registros de emenic
            string VarAct = Request.QueryString["act"];

            //recuperando entradas
            string ObjetivoGeneral = txtobjetivogeneral.Text;
            string ObjetivoEspecifico1 = txtobjetivoespecifico1.Text;
            string ObjetivoEspecifico2 = txtobjetivoespecifico2.Text;
            string ObjetivoEspecifico3 = txtobjetivoespecifico3.Text;
            string Mision = txtmision.Text;
            string Vision = txtvision.Text;
            string Valores = txtvalores.Text;
            string Descripcion = txtdescripcion.Text;
            string Servicios = txtservicios.Text;

            //inicia el update del registro
            try
            {
                //consulta que se ingresa a la base de datos
                query = "UPDATE emenic SET ObjetivoGeneral ='" + ObjetivoGeneral + "',ObjetivoEspecifico1 = '" + ObjetivoEspecifico1 +
                "', ObjetivoEspecifico2 = '" + ObjetivoEspecifico2 + "', ObjetivoEspecifico3 = '" + ObjetivoEspecifico3 + "', Mision = '" + 
                Mision + "', Vision = '" + Vision + "', Valores = '" + Valores + "', Descripcion = '" + Descripcion + "', Servicios = '" +
                Servicios + "'  WHERE Id = 1 " +  "AND IdPersona like " + VarAct;

                //enviar consulta a Mysql
                conexion.IniciarConexion();
                conexion.EnviarQuery(query);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
                conexion.CerrarConexion();
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido actualizar los datos.')", true);
            }
        }
    }
}
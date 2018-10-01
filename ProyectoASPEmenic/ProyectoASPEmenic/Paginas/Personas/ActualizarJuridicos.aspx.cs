using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ActualizarJuridicos : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string VarAct = Request.QueryString["act"];

                string query = "SELECT NombreLegal,NombreComercial,Giro,Tamano,Ubicacion,MunicipioCiudad," +
                "DepartamentoEstado,Pais,Telefono1,Telefono2,Telefono3,Fax,Email1,Email2,CodigoPostal,NIT," +
                "FechaExpedicionNIT,NombreSegunNIT,NRC,FechaExpedicionNRC,NombreSegunNRC,NombreContacto," +
                "DUIContacto,NITContacto,EmailContacto,TelefonoContacto,CelularContacto,Observaciones, " +
                "Cliente,Proveedor,Socio,Activo FROM persona WHERE IdPersona=" + VarAct;

                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido
                    if (conexion.reg.GetString(0) != null || conexion.reg.GetString(0) != "")
                        txtnombrelegal.Text = conexion.reg.GetString(0);
                    else
                        txtnombrelegal.Text = "";

                    if (conexion.reg.GetString(1) != null || conexion.reg.GetString(1) != "")
                        txtnombrecomercial.Text = conexion.reg.GetString(1);
                    else
                        txtnombrecomercial.Text = "";

                    if (conexion.reg.GetString(2) != null || conexion.reg.GetString(2) != "")
                        txtgiroactividadeconomica.Text = conexion.reg.GetString(2);
                    else
                        txtgiroactividadeconomica.Text = "";

                    ddltamanoempresa.SelectedValue = conexion.reg.GetString(3);
                    
                    if (conexion.reg.GetString(4) != null || conexion.reg.GetString(4) != "")
                        txtdireccionubicacion.Text = conexion.reg.GetString(4);
                    else
                        txtdireccionubicacion.Text = "";

                    if (conexion.reg.GetString(5) != null || conexion.reg.GetString(5) != "")
                        txtmunicipiociudad.Text = conexion.reg.GetString(5);
                    else
                        txtmunicipiociudad.Text = "";

                    if (conexion.reg.GetString(6) != null || conexion.reg.GetString(6) != "")
                        txtdepartamentoestado.Text = conexion.reg.GetString(6);
                    else
                        txtdepartamentoestado.Text = "";

                    if (conexion.reg.GetString(7) != null || conexion.reg.GetString(7) != "")
                        txtpais.Text = conexion.reg.GetString(7);
                    else
                        txtpais.Text = "";

                    if (conexion.reg.GetString(8) != null || conexion.reg.GetString(8) != "")
                        txttelefono1.Text = conexion.reg.GetString(8);
                    else
                        txttelefono1.Text = "";

                    if (conexion.reg.GetString(9) != null || conexion.reg.GetString(9) != "")
                        txttelefono2.Text = conexion.reg.GetString(9);
                    else
                        txttelefono2.Text = "";

                    if (conexion.reg.GetString(10) != null || conexion.reg.GetString(10) != "")
                        txttelefono3.Text = conexion.reg.GetString(10);
                    else
                        txttelefono3.Text = "";

                    if (conexion.reg.GetString(11) != null || conexion.reg.GetString(11) != "")                     
                        txtFax.Text = conexion.reg.GetString(11);                   
                    else if(conexion.reg.GetString(11) == null)
                        txtFax.Text = "";

                    if (conexion.reg.GetString(12) != null || conexion.reg.GetString(12) != "")
                        txtcorreo1.Text = conexion.reg.GetString(12);
                    else
                        txtcorreo1.Text = "";

                    if (conexion.reg.GetString(13) != null || conexion.reg.GetString(13) != "")
                        txtcorreo2.Text = conexion.reg.GetString(13);
                    else
                        txtcorreo2.Text = "";

                    if (conexion.reg.GetString(14) != null || conexion.reg.GetString(14) != "")
                        txtcodigopostal.Text = conexion.reg.GetString(14);
                    else
                        txtcodigopostal.Text = "";

                    if (conexion.reg.GetString(15) != null || conexion.reg.GetString(15) != "")
                        txtNIT.Text = conexion.reg.GetString(15);
                    else
                        txtNIT.Text = "";

                    if (conexion.reg.GetString(16) != null || conexion.reg.GetString(16) != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetString(16));
                        txtfechaexpedicionNIT.Text = fecha;
                    }
                    else
                        txtfechaexpedicionNIT.Text = "";

                    if (conexion.reg.GetString(17) != null || conexion.reg.GetString(17) != "")
                        txtnombreNIT.Text = conexion.reg.GetString(17);
                    else
                        txtnombreNIT.Text = "";

                    if (conexion.reg.GetString(18) != null || conexion.reg.GetString(18) != "")
                        txtNRC.Text = conexion.reg.GetString(18);
                    else
                        txtNRC.Text = "";

                    if (conexion.reg.GetString(19) != null || conexion.reg.GetString(19) != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetString(19));
                        txtfechaexpedicionNRC.Text = fecha;
                    }                        
                    else
                        txtfechaexpedicionNRC.Text = "";

                    if (conexion.reg.GetString(20) != null || conexion.reg.GetString(20) != "")
                        txtnombreNRC.Text = conexion.reg.GetString(20);
                    else
                        txtnombreNRC.Text = "";

                    if (conexion.reg.GetString(21) != null || conexion.reg.GetString(21) != "")
                        txtnombrecontacto.Text = conexion.reg.GetString(21);
                    else
                        txtnombrecontacto.Text = "";

                    if (conexion.reg.GetString(22) != null || conexion.reg.GetString(22) != "")
                        txtDUIcontacto.Text = conexion.reg.GetString(22);
                    else
                        txtDUIcontacto.Text = "";

                    if (conexion.reg.GetString(23) != null || conexion.reg.GetString(23) != "")
                        txtNITcontacto.Text = conexion.reg.GetString(23);
                    else
                        txtNITcontacto.Text = "";

                    if (conexion.reg.GetString(24) != null || conexion.reg.GetString(24) != "")
                        txtemailcontacto.Text = conexion.reg.GetString(24);
                    else
                        txtemailcontacto.Text = "";

                    if (conexion.reg.GetString(25) != null || conexion.reg.GetString(25) != "")
                        txttelefonocontacto.Text = conexion.reg.GetString(25);
                    else
                        txttelefonocontacto.Text = "";

                    if (conexion.reg.GetString(26) != null || conexion.reg.GetString(26) != "")
                        txtcelularcontacto.Text = conexion.reg.GetString(26);
                    else
                        txtcelularcontacto.Text = "";

                    if (conexion.reg.GetString(27) != null || conexion.reg.GetString(27) != "")
                        txtobservaciones.Text = conexion.reg.GetString(27);
                    else
                        txtobservaciones.Text = "";

                    checkCliente.Checked = conexion.reg.GetBoolean(28);
                    checkProveedor.Checked = conexion.reg.GetBoolean(29);
                    checkSocio.Checked = conexion.reg.GetBoolean(30);
                    checkActivo.Checked = conexion.reg.GetBoolean(31);
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

        protected void btnActualizarJuridicos_Click(object sender, EventArgs e)
        {
            string VarAct = Request.QueryString["act"];

            //recuperando entradas
            string NombreLegal = txtnombrelegal.Text;
            string NombreComercial = txtnombrecomercial.Text;
            string Giro = txtgiroactividadeconomica.Text;
            string Tamano = ddltamanoempresa.SelectedValue;
            string DireccionUbicacion = txtdireccionubicacion.Text;
            string MunicipioCiudad = txtmunicipiociudad.Text;
            string DepartamentoEstado = txtdepartamentoestado.Text;
            string Pais = txtpais.Text;
            string Telefono1 = txttelefono1.Text;
            string Telefono2 = txttelefono2.Text;
            string Telefono3 = txttelefono3.Text;
            string Fax = txtFax.Text;
            string Email1 = txtcorreo1.Text;
            string Email2 = txtcorreo2.Text;
            string CodigoPostal = txtcodigopostal.Text;
            string NIT = txtNIT.Text;
            string FechaExpedicionNIT = txtfechaexpedicionNIT.Text;
            string NombreSegunNIT = txtnombreNIT.Text;
            string NRC = txtNRC.Text;
            string FechaExpedicionNRC = txtfechaexpedicionNRC.Text;
            string NombreSegunNRC = txtnombreNRC.Text;
            string NombreContacto = txtnombrecontacto.Text;
            string DUIContacto = txtDUIcontacto.Text;
            string NITContacto = txtNITcontacto.Text;
            string EmailContacto = txtemailcontacto.Text;
            string TelefonoContacto = txttelefonocontacto.Text;
            string CelularContacto = txtcelularcontacto.Text;
            string Observaciones = txtobservaciones.Text;
            Boolean Cliente = checkCliente.Checked;
            Boolean Proveedor = checkProveedor.Checked;
            Boolean Socio = checkSocio.Checked;
            Boolean Activo = checkActivo.Checked;

            //consulta que se ingresa a la base de datos
            string query = "";

            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);

        }
    }
}
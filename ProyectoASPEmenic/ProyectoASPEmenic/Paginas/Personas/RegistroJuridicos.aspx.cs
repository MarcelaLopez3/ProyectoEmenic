using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Clientes
{
    public partial class RegistroJuridicos : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnGuardarJuridicos_Click(object sender, EventArgs e)
        {
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
            Boolean PersonaJuridica = true;
            Boolean Activo = true;

            if (NombreContacto.Length > 0 && NombreContacto != " ")
            {
                contenido_c = true;
                //verificar si hay contenidos o no en las siguientes variables
                if (TelefonoContacto.Length > 0 && TelefonoContacto != " ")
                {
                    contenido_telefono_c = true;                    
                }
                if (EmailContacto.Length > 0 && EmailContacto != " ")
                {
                    contenido_email_c = true;
                }
                if (CelularContacto.Length > 0 && TelefonoContacto != " ")
                {
                    contenido_celular_c = true;
                }

                //verificar que haya alguna de esas variables esta en true
                if (contenido_telefono_c == false && contenido_email_c == false && contenido_celular_c == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ingresar Telefono, Email o Celular del la Persona de contacto.')", true);
                }

                if (DUIContacto.Length > 0 && DUIContacto != " ")
                {
                    if (validacion.EsDui(DUIContacto) == false)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Dui de Persona de contacto NO Valido')", true);
                    }
                }
            }

            //verificar que la empresa registre su NIT o NRC
            //validando Nit
            if (NIT.Length > 0 && NIT != " ")
            {
                contenido_nit_e = true;
                //verificar si no hay personas juridicas en bdd con ese mismo nit
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NIT = '" + NIT + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_nit = conexion.reg.GetInt32(0);
                    if (Resultado_nit == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Nit existente.')", true);
                    }
                    else
                    {
                        bandera_nit_e = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_nit_e = true;
            }

            //validando NRC
            if (NRC.Length > 0 && NRC != " ")
            {
                contenido_nrc_e = true;
                //verificar si no hay personas juridicas en bdd con ese mismo nrc
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NRC = '" + NRC + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_nrc = conexion.reg.GetInt32(0);
                    if (Resultado_nrc == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('NRC existente.')", true);
                    }
                    else
                    {
                        bandera_nrc_e = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_nrc_e = true;
            }

            //verificar fechas de NIT y NRC
            if (FechaExpedicionNIT == "" || FechaExpedicionNIT == " ")
            {
                FechaExpedicionNIT = FormatoFecha(Hoy.ToShortDateString());
            }

            if (FechaExpedicionNRC == "" || FechaExpedicionNRC == " ")
            {
                FechaExpedicionNRC = FormatoFecha(Hoy.ToShortDateString());
            }

            //inicia el insert del registro
            if (bandera_nit_e == true && bandera_nrc_e == true)
            {
                if (contenido_nit_e == true || contenido_nrc_e == true)
                {
                    //consulta que se ingresa a la base de datos
                    query = "INSERT INTO persona(NombreLegal,NombreComercial,Giro,Tamano,Ubicacion,MunicipioCiudad," +
                "DepartamentoEstado,Pais,Telefono1,Telefono2,Telefono3,Fax,Email1,Email2,CodigoPostal,NIT," +
                "FechaExpedicionNIT,NombreSegunNIT,NRC,FechaExpedicionNRC,NombreSegunNRC,NombreContacto," +
                "DUIContacto,NITContacto,EmailContacto,TelefonoContacto,CelularContacto,Observaciones, " +
                "Cliente,Proveedor,Socio,PersonaJuridica,Activo) VALUES ('" + NombreLegal + "','" + NombreComercial +
                "','" + Giro + "','" + Tamano + "','" + DireccionUbicacion + "','" + MunicipioCiudad +
                "','" + DepartamentoEstado + "','" + Pais + "','" + Telefono1 + "','" + Telefono2 + "','" + Telefono3 +
                "','" + Fax + "','" + Email1 + "','" + Email2 + "','" + CodigoPostal + "','" + NIT +
                "','" + FechaExpedicionNIT + "','" + NombreSegunNIT + "','" + NRC + "','" + FechaExpedicionNRC +
                "','" + NombreSegunNRC + "','" + NombreContacto + "','" + DUIContacto + "','" + NITContacto +
                "','" + EmailContacto + "','" + TelefonoContacto + "','" + CelularContacto + "','" + Observaciones +
                "'," + Cliente + "," + Proveedor + "," + Socio + "," + PersonaJuridica + "," + Activo + ")";

                    //enviar consulta a Mysql
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                    conexion.CerrarConexion();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe haber al menos un documento de identificación.')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido ingresar registro, verificar que los documentos de identificación son correctos.')", true);
            }         
        }

        protected string FormatoFecha(string nueva2)
        {            
            string[] words = nueva2.Split('/');
            string devuelve = words[2] + "-" + words[1] + "-" + words[0];
            return devuelve;
        }
    }
}
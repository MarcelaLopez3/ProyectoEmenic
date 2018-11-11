using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ActualizarJuridicos : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        Validacion validacion = new Validacion();
        string query = "";
        DateTime Hoy = DateTime.Today;
        int Resultado_servicio = 0;

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

            //Verificar si la persona posee o ha tenido servicios contratados de emenic
            if (Cliente == false)
            {
                query = "SELECT IF( EXISTS(SELECT * FROM serviciocontratado WHERE IdCliente = '" + VarAct + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    Resultado_servicio = conexion.reg.GetInt32(0);
                }
                conexion.reg.Close();
                conexion.CerrarConexion();

                //verificar si es o no eliminado
                if (Resultado_servicio == 1)
                {
                    //no puede ser eliminado porque tiene registros hijos
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Este registro es cliente activo, tiene registros de servicios contratados, NO puede desactivar la bandera Cliente.')", true);
                }
            }

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
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NIT = '" + NIT + "' AND IdPersona != "+ VarAct +"), 1, 0) as Resultado";
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

            //inicia el update del registro
            if (bandera_nit_e == true && bandera_nrc_e == true)
            {
                if (contenido_nit_e == true || contenido_nrc_e == true)
                {
                    //consulta que se ingresa a la base de datos
                    query = "UPDATE persona  SET NombreLegal ='" + NombreLegal + "',NombreComercial = '" + NombreComercial +
                    "', Giro = '" + Giro + "', Tamano = '" + Tamano + "', Ubicacion = '" + DireccionUbicacion + "', MunicipioCiudad = '" + 
                    MunicipioCiudad+ "', DepartamentoEstado = '" + DepartamentoEstado + "', Pais = '" + Pais + "', Telefono1 = '" + 
                    Telefono1 + "', Telefono2 = '" + Telefono2 + "', Telefono3 = '" + Telefono3 + "', Fax = '" + Fax +"', Email1 = '" +
                    Email1 + "', Email2 = '" + Email2 + "', CodigoPostal = '" + CodigoPostal + "', NIT = '" + NIT + "', FechaExpedicionNIT = '" + 
                    FechaExpedicionNIT+ "', NombreSegunNIT = '" + NombreSegunNIT + "', NRC = '" + NRC + "', FechaExpedicionNRC = '" + 
                    FechaExpedicionNRC + "', NombreSegunNRC = '" + NombreSegunNRC + "', NombreContacto = '" + NombreContacto + 
                    "', DUIContacto = '" + DUIContacto + "', NITContacto = '" + NITContacto + "', EmailContacto = '" + EmailContacto + 
                    "', TelefonoContacto = '" + TelefonoContacto + "', CelularContacto = '" + CelularContacto + "', Observaciones = '" + 
                    Observaciones + "', Cliente = " + Cliente + ", Proveedor = " + Proveedor + ", Socio = " + Socio + ", Activo = " + 
                    Activo + " WHERE IdPersona like " + VarAct;

                    //enviar consulta a Mysql
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
                    conexion.CerrarConexion();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe haber al menos un documento de identificación de la empresa.')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido ingresar registro, verificar que los documentos de identificación son correctos.')", true);
            }
        }
    }
}
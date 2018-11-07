using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ActualizarNaturales : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        Validacion validacion = new Validacion();
        string query = "";
        bool bandera_dui = false, bandera_nit = false, bandera_licencia = false, bandera_pasaporte = false, bandera_otro = false;
        bool contenido_dui = false, contenido_nit = false, contenido_licencia = false, contenido_pasaporte = false, contenido_otro = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string VarAct = Request.QueryString["act"];

                string query = "SELECT PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido," +
                    "Edad,Genero,EstadoCivil,ProfesionOficio,DireccionResidencia,DepartamentoResidencia," +
                    "MunicipioResidencia,FechaNacimiento,DepartamentoNacimiento,MunicipioNacimiento,DUI,NIT," +
                    "NumeroLicencia,Pasaporte,NombreOtro,NumeroOtro,Telefono1,Telefono2,Telefono3,Celular," +
                    "Email1,Email2,Observaciones,Usuario,Empleado,Cliente,Proveedor,Socio,Activo " +
                    "FROM persona WHERE IdPersona =" + VarAct;
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido  
                    if (conexion.reg.GetValue(0) != null || conexion.reg.GetValue(0).ToString() != "")
                        txtprimernombre.Text = conexion.reg.GetValue(0).ToString();
                    else
                        txtprimernombre.Text = "";

                    if (conexion.reg.GetValue(1) != null || conexion.reg.GetValue(1).ToString() != "")
                        txtsegundonombre.Text = conexion.reg.GetValue(1).ToString();
                    else
                        txtsegundonombre.Text = "";

                    if (conexion.reg.GetValue(2) != null || conexion.reg.GetValue(2).ToString() != "")
                        txtprimerapellido.Text = conexion.reg.GetValue(2).ToString();
                    else
                        txtprimerapellido.Text = "";

                    if (conexion.reg.GetValue(3) != null || conexion.reg.GetValue(3).ToString() != "")
                        txtsegundoapellido.Text = conexion.reg.GetValue(3).ToString();
                    else
                        txtsegundoapellido.Text = "";

                    if (conexion.reg.GetValue(4) != null || conexion.reg.GetValue(4).ToString() != "")
                        txtedad.Text = conexion.reg.GetValue(4).ToString();
                    else
                        txtedad.Text = "";

                    ddlgenero.SelectedValue = conexion.reg.GetString(5);                 
                    ddlestadocivil.SelectedValue = conexion.reg.GetString(6);

                    if (conexion.reg.GetValue(7) != null || conexion.reg.GetValue(7).ToString() != "")
                        txtprofesionoficio.Text = conexion.reg.GetValue(7).ToString();
                    else
                        txtprofesionoficio.Text = "";

                    if (conexion.reg.GetValue(8) != null || conexion.reg.GetValue(8).ToString() != "")
                        txtdireccionresidencia.Text = conexion.reg.GetValue(8).ToString();
                    else
                        txtdireccionresidencia.Text = "";

                    if (conexion.reg.GetValue(9) != null || conexion.reg.GetValue(9).ToString() != "")
                        txtdepartamentoresidencia.Text = conexion.reg.GetValue(9).ToString();
                    else
                        txtdepartamentoresidencia.Text = "";

                    if (conexion.reg.GetValue(10) != null || conexion.reg.GetValue(10).ToString() != "")
                        txtmunicipioresidencia.Text = conexion.reg.GetValue(10).ToString();
                    else
                        txtmunicipioresidencia.Text = "";

                    if (conexion.reg.GetValue(11) != null || conexion.reg.GetValue(11).ToString() != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetValue(11).ToString());
                        txtfechanacimiento.Text = fecha;
                    }
                    else
                        txtfechanacimiento.Text = "";

                    if (conexion.reg.GetValue(12) != null || conexion.reg.GetValue(12).ToString() != "")
                        txtdepartamentonacimiento.Text = conexion.reg.GetValue(12).ToString();
                    else
                        txtdepartamentonacimiento.Text = "";

                    if (conexion.reg.GetValue(13) != null || conexion.reg.GetValue(13).ToString() != "")
                        txtmunicipionacimiento.Text = conexion.reg.GetValue(13).ToString();
                    else
                        txtmunicipionacimiento.Text = "";

                    if (conexion.reg.GetValue(14) != null || conexion.reg.GetValue(14).ToString() != "")
                        txtDUI.Text = conexion.reg.GetValue(14).ToString();
                    else
                        txtDUI.Text = "";

                    if (conexion.reg.GetValue(15) != null || conexion.reg.GetValue(15).ToString() != "")
                        txtNIT.Text = conexion.reg.GetValue(15).ToString();
                    else
                        txtNIT.Text = "";

                    if (conexion.reg.GetValue(16) != null || conexion.reg.GetValue(16).ToString() != "")
                        txtnumerolicencia.Text = conexion.reg.GetValue(16).ToString();
                    else
                        txtnumerolicencia.Text = "";

                    if (conexion.reg.GetValue(17) != null || conexion.reg.GetValue(17).ToString() != "")
                        txtpasaporte.Text = conexion.reg.GetValue(17).ToString();
                    else
                        txtpasaporte.Text = "";

                    if (conexion.reg.GetValue(18) != null || conexion.reg.GetValue(18).ToString() != "")
                        txtnombreotro.Text = conexion.reg.GetValue(18).ToString();                                                                    
                    else
                        txtnombreotro.Text = "";

                    if (conexion.reg.GetValue(19) != null || conexion.reg.GetValue(19).ToString() != "")
                        txtnumerootro.Text = conexion.reg.GetValue(19).ToString();
                    else
                        txtnumerootro.Text = "";

                    if (conexion.reg.GetValue(20) != null || conexion.reg.GetValue(20).ToString() != "")
                        txttelefono1.Text = conexion.reg.GetValue(20).ToString();
                    else
                        txttelefono1.Text = "";

                    if (conexion.reg.GetValue(21) != null || conexion.reg.GetValue(21).ToString() != "")
                        txttelefono2.Text = conexion.reg.GetValue(21).ToString();
                    else
                        txttelefono2.Text = "";

                    if (conexion.reg.GetValue(22) != null || conexion.reg.GetValue(22).ToString() != "")
                        txttelefono3.Text = conexion.reg.GetValue(22).ToString();
                    else
                        txttelefono3.Text = "";

                    if (conexion.reg.GetValue(23) != null || conexion.reg.GetValue(23).ToString() != "")
                        txtcelular.Text = conexion.reg.GetValue(23).ToString();
                    else
                        txtcelular.Text = "";

                    if (conexion.reg.GetValue(24) != null || conexion.reg.GetValue(24).ToString() != "")
                        txtemail1.Text = conexion.reg.GetValue(24).ToString();
                    else
                        txtemail1.Text = "";

                    if (conexion.reg.GetValue(25) != null || conexion.reg.GetValue(25).ToString() != "")
                        txtemail2.Text = conexion.reg.GetValue(25).ToString();
                    else
                        txtemail2.Text = "";

                    if (conexion.reg.GetValue(26) != null || conexion.reg.GetValue(26).ToString() != "")
                        txtobservaciones.Text = conexion.reg.GetValue(26).ToString();
                    else
                        txtobservaciones.Text = "";

                    checkUsuario.Checked = conexion.reg.GetBoolean(27);
                    checkEmpleado.Checked = conexion.reg.GetBoolean(28);
                    checkCliente.Checked = conexion.reg.GetBoolean(29);
                    checkProveedor.Checked = conexion.reg.GetBoolean(30);
                    checkSocio.Checked = conexion.reg.GetBoolean(31);
                    checkActivo.Checked = conexion.reg.GetBoolean(32);               
                }
                conexion.CerrarConexion();
            }
        }

        protected void btnActualizarNaturales_Click(object sender, EventArgs e)
        {
            string VarAct = Request.QueryString["act"];

            //recuperando entradas
            string PrimerNombre = txtprimernombre.Text;
            string SegundoNombre = txtsegundonombre.Text;
            string PrimerApellido = txtprimerapellido.Text;
            string SegundoApellido = txtsegundoapellido.Text;
            int Edad = Int32.Parse(txtedad.Text);
            string Genero = ddlgenero.SelectedValue;
            string EstadoCivil = ddlestadocivil.SelectedValue;
            string ProfesionOficio = txtprofesionoficio.Text;
            string DireccionResidencia = txtdireccionresidencia.Text;
            string DepartamentoResidencia = txtdepartamentoresidencia.Text;
            string MunicipioResidencia = txtmunicipioresidencia.Text;
            string FechaNacimiento = txtfechanacimiento.Text;
            string DepartamentoNacimiento = txtdepartamentonacimiento.Text;
            string MunicipioNacimiento = txtmunicipionacimiento.Text;
            string DUI = txtDUI.Text;
            string NIT = txtNIT.Text;
            string NumeroLicencia = txtnumerolicencia.Text;
            string Pasaporte = txtpasaporte.Text;
            string NombreOtro = txtnombreotro.Text;
            string NumeroOtro = txtnumerootro.Text;
            string Telefono1 = txttelefono1.Text;
            string Telefono2 = txttelefono2.Text;
            string Telefono3 = txttelefono3.Text;
            string Celular = txtcelular.Text;
            string Email1 = txtemail1.Text;
            string Email2 = txtemail2.Text;
            string Observaciones = txtobservaciones.Text;
            Boolean Usuario = checkUsuario.Checked;
            Boolean Empleado = checkEmpleado.Checked;
            Boolean Cliente = checkCliente.Checked;
            Boolean Proveedor = checkProveedor.Checked;
            Boolean Socio = checkSocio.Checked;
            Boolean Activo = checkActivo.Checked;

            //validando dui
            if (txtDUI.Text.Length > 0 && txtDUI.Text != " ")
            {
                contenido_dui = true;
                if (validacion.EsDui(DUI) == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Dui NO Valido')", true);
                }
                else
                {
                    //si hay dui y es valido, verificar si no hay persona en bdd con ese mismo dui que no sea el registro actual
                    query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE DUI = '" + DUI + "' AND IdPersona != " + VarAct + " ), 1, 0) as Resultado";
                    conexion.IniciarConexion();
                    conexion.RecibeQuery(query);
                    while (conexion.reg.Read())
                    {
                        int Resultado_dui = conexion.reg.GetInt32(0);
                        if (Resultado_dui == 1)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Dui existente.')", true);
                        }
                        else
                        {
                            bandera_dui = true;
                        }
                    }
                    conexion.reg.Close();
                    conexion.CerrarConexion();
                }
            }
            else
            {
                bandera_dui = true;
            }

            //validando Nit
            if (txtNIT.Text.Length > 0 && txtNIT.Text != " ")
            {
                contenido_nit = true;
                //verificar si no hay persona en bdd con ese mismo nit
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NIT = '" + NIT + "' AND IdPersona != " + VarAct + "), 1, 0) as Resultado";
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
                        bandera_nit = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_nit = true;
            }

            //validando licencia
            if (txtnumerolicencia.Text.Length > 0 && txtnumerolicencia.Text != " ")
            {
                contenido_licencia = true;
                //verificar si no hay persona en bdd con ese mismo numero de licencia
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NumeroLicencia = '" + NumeroLicencia + "' AND IdPersona != " + VarAct + "), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_licencia = conexion.reg.GetInt32(0);
                    if (Resultado_licencia == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Licencia existente.')", true);
                    }
                    else
                    {
                        bandera_licencia = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_licencia = true;
            }

            //validando pasaporte
            if (txtpasaporte.Text.Length > 0 && txtpasaporte.Text != " ")
            {
                contenido_pasaporte = true;
                //verificar si no hay persona en bdd con ese mismo numero de pasaporte
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE Pasaporte = '" + Pasaporte + "' AND IdPersona != " + VarAct + "), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_pasaporte = conexion.reg.GetInt32(0);
                    if (Resultado_pasaporte == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pasaporte existente.')", true);
                    }
                    else
                    {
                        bandera_pasaporte = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_pasaporte = true;
            }

            //validando otro documento
            if (txtnumerootro.Text.Length > 0 && txtnumerootro.Text != " ")
            {
                contenido_otro = true;
                //verificar si no hay persona en bdd con ese mismo numero de otro documento
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NumeroOtro = '" + NumeroOtro + "' AND IdPersona != " + VarAct + "), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_otro = conexion.reg.GetInt32(0);
                    if (Resultado_otro == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Otro Documento existente.')", true);
                    }
                    else
                    {
                        bandera_otro = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_otro = true;
            }

            //inicia el update del registro
            if (bandera_dui == true && bandera_nit == true && bandera_licencia == true && bandera_pasaporte == true && bandera_otro == true)
            {
                if (contenido_dui == true || contenido_nit == true || contenido_licencia == true || contenido_pasaporte == true || contenido_otro == true)
                {
                    //consulta que se ingresa a la base de datos
                    query = "UPDATE persona SET PrimerNombre = '" + PrimerNombre + "', SegundoNombre = '" + SegundoNombre +
                "', PrimerApellido = '" + PrimerApellido + "', SegundoApellido = '" + SegundoApellido + "', Edad = " +
                Edad + ", Genero = '" + Genero + "', EstadoCivil = '" + EstadoCivil + "', ProfesionOficio = '" + ProfesionOficio +
                "', DireccionResidencia = '" + DireccionResidencia + "', DepartamentoResidencia = '" + DepartamentoResidencia +
                "', MunicipioResidencia = '" + MunicipioResidencia + "', FechaNacimiento = '" + FechaNacimiento +
                "', DepartamentoNacimiento = '" + DepartamentoNacimiento + "', MunicipioNacimiento = '" + MunicipioNacimiento +
                "', DUI = '" + DUI + "', NIT = '" + NIT + "', NumeroLicencia = '" + NumeroLicencia + "' ,Pasaporte = '" +
                Pasaporte + "', NombreOtro = '" + NombreOtro + "', NumeroOtro = '" + NumeroOtro + "', Telefono1 = '" + Telefono1 +
                "', Telefono2 = '" + Telefono2 + "', Telefono3 = '" + Telefono3 + "', Celular = '" + Celular + "', Email1 = '" +
                Email1 + "', Email2 = '" + Email2 + "', Observaciones = '" + Observaciones + "', Usuario = " + Usuario +
                ", Empleado = " + Empleado + ", Cliente = " + Cliente + ", Proveedor = " + Proveedor + ", Socio = " + Socio +
                ", Activo = " + Activo + " WHERE IdPersona like " + VarAct;

                    //enviar consulta a Mysql
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    conexion.CerrarConexion();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
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

        protected string FormatoFecha(string fecha)
        {
            DateTime nueva = DateTime.Parse(fecha);
            string nueva2 = nueva.ToShortDateString();
            string[] words = nueva2.Split('/');
            string devuelve = words[2] + "-" + words[1] + "-" + words[0];
            return devuelve;
        }
    }
}
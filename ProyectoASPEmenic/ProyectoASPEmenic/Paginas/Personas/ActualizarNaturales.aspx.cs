using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ActualizarNaturales : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();        

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
                    "FROM persona WHERE IdPersona=" + VarAct;
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido
                    if (conexion.reg.GetString(0) != null || conexion.reg.GetString(0) != "")                    
                        txtprimernombre.Text = conexion.reg.GetString(0);                 
                    else                    
                        txtprimernombre.Text = "";

                    if (conexion.reg.GetString(1) != null || conexion.reg.GetString(1) != "")
                        txtsegundonombre.Text = conexion.reg.GetString(1);
                    else
                        txtsegundonombre.Text = "";

                    if (conexion.reg.GetString(2) != null || conexion.reg.GetString(2) != "")
                        txtprimerapellido.Text = conexion.reg.GetString(2);
                    else
                        txtprimerapellido.Text = "";

                    if (conexion.reg.GetString(3) != null || conexion.reg.GetString(3) != "")
                        txtsegundoapellido.Text = conexion.reg.GetString(3);
                    else
                        txtsegundoapellido.Text = "";

                    if (conexion.reg.GetString(4) != null || conexion.reg.GetString(4) != "")
                        txtedad.Text = conexion.reg.GetString(4);
                    else
                        txtedad.Text = "";

                    ddlgenero.SelectedValue = conexion.reg.GetString(5);                 
                    ddlestadocivil.SelectedValue = conexion.reg.GetString(6);

                    if (conexion.reg.GetString(7) != null || conexion.reg.GetString(7) != "")
                        txtprofesionoficio.Text = conexion.reg.GetString(7);
                    else
                        txtprofesionoficio.Text = "";

                    if (conexion.reg.GetString(8) != null || conexion.reg.GetString(8) != "")
                        txtdireccionresidencia.Text = conexion.reg.GetString(8);
                    else
                        txtdireccionresidencia.Text = "";

                    if (conexion.reg.GetString(9) != null || conexion.reg.GetString(9) != "")
                        txtdepartamentoresidencia.Text = conexion.reg.GetString(9);
                    else
                        txtdepartamentoresidencia.Text = "";

                    if (conexion.reg.GetString(10) != null || conexion.reg.GetString(10) != "")
                        txtmunicipioresidencia.Text = conexion.reg.GetString(10);
                    else
                        txtmunicipioresidencia.Text = "";

                    if (conexion.reg.GetString(11) != null || conexion.reg.GetString(11) != "")
                    {
                        string fecha = FormatoFecha(conexion.reg.GetString(11));
                        txtfechanacimiento.Text = fecha;
                    }
                    else
                        txtfechanacimiento.Text = "";

                    if (conexion.reg.GetString(12) != null || conexion.reg.GetString(12) != "")
                        txtdepartamentonacimiento.Text = conexion.reg.GetString(12);
                    else
                        txtdepartamentonacimiento.Text = "";

                    if (conexion.reg.GetString(13) != null || conexion.reg.GetString(13) != "")
                        txtmunicipionacimiento.Text = conexion.reg.GetString(13);
                    else
                        txtmunicipionacimiento.Text = "";

                    if (conexion.reg.GetString(14) != null || conexion.reg.GetString(14) != "")
                        txtDUI.Text = conexion.reg.GetString(14);
                    else
                        txtDUI.Text = "";

                    if (conexion.reg.GetString(15) != null || conexion.reg.GetString(15) != "")
                        txtNIT.Text = conexion.reg.GetString(15);
                    else
                        txtNIT.Text = "";

                    if (conexion.reg.GetString(16) != null || conexion.reg.GetString(16) != "")
                        txtnumerolicencia.Text = conexion.reg.GetString(16);
                    else
                        txtnumerolicencia.Text = "";

                    if (conexion.reg.GetString(17) != null || conexion.reg.GetString(17) != "")
                        txtpasaporte.Text = conexion.reg.GetString(17);
                    else
                        txtpasaporte.Text = "";

                    if (conexion.reg.GetString(18) != null || conexion.reg.GetString(18) != "")
                        txtnombreotro.Text = conexion.reg.GetString(18);
                    else
                        txtnombreotro.Text = "";

                    if (conexion.reg.GetString(19) != null || conexion.reg.GetString(19) != "")
                        txtnumerootro.Text = conexion.reg.GetString(19);
                    else
                        txtnumerootro.Text = "";

                    if (conexion.reg.GetString(20) != null || conexion.reg.GetString(20) != "")
                        txttelefono1.Text = conexion.reg.GetString(20);
                    else
                        txttelefono1.Text = "";

                    if (conexion.reg.GetString(21) != null || conexion.reg.GetString(21) != "")
                        txttelefono2.Text = conexion.reg.GetString(21);
                    else
                        txttelefono2.Text = "";

                    if (conexion.reg.GetString(22) != null || conexion.reg.GetString(22) != "")
                        txttelefono3.Text = conexion.reg.GetString(22);
                    else
                        txttelefono3.Text = "";

                    if (conexion.reg.GetString(23) != null || conexion.reg.GetString(23) != "")
                        txtcelular.Text = conexion.reg.GetString(23);
                    else
                        txtcelular.Text = "";

                    if (conexion.reg.GetString(24) != null || conexion.reg.GetString(24) != "")
                        txtemail1.Text = conexion.reg.GetString(24);
                    else
                        txtemail1.Text = "";

                    if (conexion.reg.GetString(25) != null || conexion.reg.GetString(25) != "")
                        txtemail2.Text = conexion.reg.GetString(25);
                    else
                        txtemail2.Text = "";

                    if (conexion.reg.GetString(26) != null || conexion.reg.GetString(26) != "")
                        txtobservaciones.Text = conexion.reg.GetString(26);
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

            //consulta que se ingresa a la base de datos
            string query = "UPDATE persona SET PrimerNombre = '" + PrimerNombre + "', SegundoNombre = '" + SegundoNombre +
                "', PrimerApellido = '" + PrimerApellido + "', SegundoApellido = '" + SegundoApellido + "', Edad = " + 
                Edad + ", Genero = '" + Genero + "', EstadoCivil = '" + EstadoCivil + "', ProfesionOficio = '" + ProfesionOficio +
                "', DireccionResidencia = '" + DireccionResidencia + "', DepartamentoResidencia = '" + DepartamentoResidencia +
                "', MunicipioResidencia = '" + MunicipioResidencia + "', FechaNacimiento = '" + FechaNacimiento + 
                "', DepartamentoNacimiento = '" + DepartamentoNacimiento + "', MunicipioNacimiento = '" + MunicipioNacimiento +
                "', DUI = '" + DUI + "', NIT = '" + NIT + "', NumeroLicencia = '" + NumeroLicencia + "' ,Pasaporte = '" + 
                Pasaporte + "', NombreOtro = '" + NombreOtro +"', NumeroOtro = '" + NumeroOtro + "', Telefono1 = '" + Telefono1 +
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
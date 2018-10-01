using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Clientes
{
    public partial class RegistroJuridicos : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {

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

            //consulta que se ingresa a la base de datos
            string query = "INSERT INTO persona(NombreLegal,NombreComercial,Giro,Tamano,Ubicacion,MunicipioCiudad," +
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
            conexion.CerrarConexion();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);

        }
    }
}
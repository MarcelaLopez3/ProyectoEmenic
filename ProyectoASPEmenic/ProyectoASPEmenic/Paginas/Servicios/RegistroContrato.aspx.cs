using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class RegistroContrato : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarddlIDtransporte();
            LlenarddlIDservicio();
        }

        //Función para llenar ajaxtoolkit-combobox
        private void LlenarddlIDtransporte()
        {
            string query = "SELECT IdTransporte,Placa from transporte";
            conexion.IniciarConexion();
            ddlIDtransporte.DataSource = conexion.llena(query);
            conexion.CerrarConexion();
            ddlIDtransporte.DataTextField = "Placa";
            ddlIDtransporte.DataValueField = "IdTransporte";
            ddlIDtransporte.DataBind();
        }

        //Función para llenar ajaxtoolkit-combobox
        private void LlenarddlIDservicio()
        {
            string query = "SELECT a.Id, concat_ws(' -> ', b.NombreSegunNIT,c.NombreSegunNIT) as servicio FROM serviciocontratado a " +
            "INNER JOIN persona b ON a.IdCliente = b.IdPersona " +
            "INNER JOIN persona c ON a.IdConsignatorio = c.IdPersona";
            conexion.IniciarConexion();
            ddlIDservicio.DataSource = conexion.llena(query);
            conexion.CerrarConexion();
            ddlIDservicio.DataTextField = "servicio";
            ddlIDservicio.DataValueField = "Id";
            ddlIDservicio.DataBind();
        }

        protected void btnGuardarContrato_Click(object sender, EventArgs e)
        {

            //recuperando entradas
            int IdTransporte = Int32.Parse(ddlIDtransporte.SelectedValue);
            int IdServicio = Int32.Parse(ddlIDservicio.SelectedValue);
            int CantidadMeses = Int32.Parse(txtcantidadmeses.Text);
            string FechaEmision = txtfechaemision.Text;

            //Boolean Cabezal = checkCabezal.Checked;
            //Boolean Furgon = checkFurgon.Checked;
            //string Placa = txtPlaca.Text;
            //string Equipo = txtvehiculoequipo.Text;
            //string Descripcion = txtDescripcion.Text;

            //consulta que se ingresa a la base de datos
            string query = "INSERT INTO `contrato` (`IdContrato`, `IdTransporte`, `IdServicio`, `FechaEmision`, `CantidadMeses`) " +
                "VALUES(NULL,'" + IdTransporte + "','" + IdServicio + "','" + FechaEmision + "'," + CantidadMeses + ")";
            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
            Response.Redirect("~/Paginas/Servicios/ListadoContrato.aspx");
        }
    }
}
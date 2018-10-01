using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class Transporte : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiarTransporte_Click(object sender, EventArgs e)
        {
            LimpiarTransporte();
        }

        protected void btnGuardarTransporte_Click(object sender, EventArgs e)
        {
            //recuperando entradas
            Boolean Cabezal = checkCabezal.Checked;
            Boolean Furgon = checkFurgon.Checked;
            string Placa = txtPlaca.Text;
            string Equipo = txtvehiculoequipo.Text;
            string Descripcion = txtDescripcion.Text;
            //consulta que se ingresa a la base de datos
            string query = "INSERT INTO `transporte` (`Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal`) " +
                "VALUES('"+Placa + "','" + Descripcion + "','"+Equipo+"',"+Furgon+","+Cabezal+")";
            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
            Response.Redirect("~/Paginas/Servicios/ListadoTransporte.aspx");
        }

        protected void LimpiarTransporte()
        {
            checkCabezal.Checked = false;
            checkFurgon.Checked = false;

            txtDescripcion.Text = "";
            txtPlaca.Text = "";
            txtvehiculoequipo.Text = "";
        }
    }
}
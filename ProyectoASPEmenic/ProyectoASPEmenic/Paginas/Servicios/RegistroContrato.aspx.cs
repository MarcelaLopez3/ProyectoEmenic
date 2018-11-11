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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            /*
            //recuperando entradas
            Boolean Cabezal = checkCabezal.Checked;
            Boolean Furgon = checkFurgon.Checked;
            string Placa = txtPlaca.Text;
            string Equipo = txtvehiculoequipo.Text;
            string Descripcion = txtDescripcion.Text;

            if (Cabezal == false && Furgon == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe seleccionar una opción')", true);
            }
            else if (Cabezal == true && Furgon == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe seleccionar solo una opción')", true);
            }
            else
            {
                //consulta que se ingresa a la base de datos
                string query = "INSERT INTO `transporte` (`Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal`, `IdEmenic`) " +
                    "VALUES('" + Placa + "','" + Descripcion + "','" + Equipo + "'," + Furgon + "," + Cabezal + ", 1)";
                //enviar consulta a Mysql
                conexion.IniciarConexion();
                conexion.EnviarQuery(query);
                conexion.CerrarConexion();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                Response.Redirect("~/Paginas/Transporte/ListadoTransporte.aspx");
            }*/
        }
    }
}
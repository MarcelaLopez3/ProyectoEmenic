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

        public object MessageBox { get; private set; }

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
            int Resultado_placa = 0;
            string query;

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
                query = "SELECT COUNT(Placa) FROM transporte WHERE Placa = '" + Placa + "'";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    Resultado_placa = conexion.reg.GetInt32(0);

                }
                conexion.reg.Close();
                conexion.CerrarConexion();
                if (Resultado_placa == 1)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('El numero de Placa ya existente.')", true);
                }
                else
                {
                    //consulta que se ingresa a la base de datos
                    query = "INSERT INTO `transporte` (`Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal`, `IdEmenic`) " +
                    "VALUES('" + Placa + "','" + Descripcion + "','" + Equipo + "'," + Furgon + "," + Cabezal + ", 1)";
                    //enviar consulta a Mysql
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    conexion.CerrarConexion();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                    Response.Redirect("~/Paginas/Transporte/ListadoTransporte.aspx");
                }
            }
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
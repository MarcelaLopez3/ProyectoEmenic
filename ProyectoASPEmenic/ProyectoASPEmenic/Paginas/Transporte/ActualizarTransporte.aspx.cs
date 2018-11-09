using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
	public partial class ActualizarTransporte : System.Web.UI.Page
	{
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                string VarAct = Request.QueryString["act"];

                string query = "SELECT `Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal` FROM `transporte` WHERE IdTransporte=" + VarAct;
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido
                    if (conexion.reg.GetString(0) != null || conexion.reg.GetString(0) != "")
                        txtPlaca.Text = conexion.reg.GetString(0);
                    else
                        txtPlaca.Text = "";

                    if (conexion.reg.GetString(1) != null || conexion.reg.GetString(1) != "")
                        txtDescripcion.Text = conexion.reg.GetString(1);
                    else
                        txtDescripcion.Text = "";

                    if (conexion.reg.GetString(2) != null || conexion.reg.GetString(2) != "")
                        txtvehiculoequipo.Text = conexion.reg.GetString(2);
                    else
                        txtvehiculoequipo.Text = "";
                    checkCabezal.Checked = conexion.reg.GetBoolean(3);
                    checkFurgon.Checked = conexion.reg.GetBoolean(4);
                }
                conexion.CerrarConexion();
            }
        }

        protected void btnActualizarTransporte_Click(object sender, EventArgs e)
        {
            string VarAct = Request.QueryString["act"];
            int idTransporte=Convert.ToInt32(VarAct);
            //recuperando entradas
            Boolean Cabezal = checkCabezal.Checked;
            Boolean Furgon = checkFurgon.Checked;
            string Placa = txtPlaca.Text;
            string Equipo = txtvehiculoequipo.Text;
            string Descripcion = txtDescripcion.Text;
            //consulta que se ingresa a la base de datos
            string query = "UPDATE `transporte` " +
                "SET `Placa`='"+Placa+"'," +
                "`Descripcion`='"+Descripcion+"'," +
                "`Equipo`='"+Equipo+"'," +
                "`Furgon` = " + Furgon+"," +
                "`Cabezal` = "+Cabezal+" " +
                "WHERE `transporte`.`IdTransporte` ="+ idTransporte + ";";
            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
            Response.Redirect("~/Paginas/Servicios/ListadoTransporte.aspx");
        }
    }
}
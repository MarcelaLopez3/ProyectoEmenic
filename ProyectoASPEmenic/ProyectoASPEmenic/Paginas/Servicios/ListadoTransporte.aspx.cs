using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ListadoTransporte : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT `IdTransporte`, `Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal` FROM `transporte`;";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoTransporte);
            conexion.CerrarConexion();
            GridListadoTransporte.DataBind();
        }
        protected void GridListadoTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridListadoTransporte.SelectedRow;
            HFIdTransporte.Value = row.Cells[1].Text;
            Response.Redirect("~/Paginas/Personas/ActualizarNaturales.aspx?act=" + HFIdTransporte.Value);
        }
    }
}
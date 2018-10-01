using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ListadoNaturales : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT IdPersona,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido," +
                "DUI,NIT,Activo FROM persona WHERE PersonaNatural = 1;";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoNaturales);
            conexion.CerrarConexion();

        }

        protected void GridListadoNaturales_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridListadoNaturales.SelectedRow;
            HFIdPersona.Value = row.Cells[1].Text;
            Response.Redirect("~/Paginas/Personas/ActualizarNaturales.aspx?act=" + HFIdPersona.Value);
        }
    }
}
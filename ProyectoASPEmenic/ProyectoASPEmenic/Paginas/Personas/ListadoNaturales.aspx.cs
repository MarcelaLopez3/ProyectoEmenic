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
        string query = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            query = "SELECT IdPersona,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido," +
                "DUI,NIT,Activo FROM persona WHERE PersonaNatural = 1;";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoNaturales);
            conexion.CerrarConexion();
        }        

        protected void GridListadoNaturales_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ////IdPersona de la tabla que selecciona
            //HFIdPersona.Value = GridListadoNaturales.Rows[e.NewEditIndex].Cells[1].Text;
            ////Envia IdPersona a formulario de actualizar       
            //Response.Redirect("~/Paginas/Personas/ActualizarNaturales.aspx?act=" + HFIdPersona.Value);
        }

        protected void GridListadoNaturales_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Personas/RegistroNaturales.aspx");
        }

        protected void GridListadoNaturales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridListadoNaturales_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Actualizar")
            {
                Response.Redirect("~/Paginas/Personas/ActualizarNaturales.aspx?act=" + e.CommandArgument);
            }
        }

        protected void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Reporteria/ReportePersonasNaturales.aspx");
        }
    }
}
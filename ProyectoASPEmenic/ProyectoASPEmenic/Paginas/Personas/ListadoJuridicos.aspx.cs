using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Personas
{
    public partial class ListadoJuridicos : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT IdPersona,NombreLegal,Tamano,Ubicacion,Pais,Giro," +
               "NombreContacto,Activo FROM persona WHERE PersonaJuridica = 1 AND IdPersona != 1;";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoJuridicas);
            conexion.CerrarConexion();

        }

        protected void GridListadoJuridicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridViewRow row = GridListadoJuridicas.SelectedRow;
            //HFIdPersona.Value = row.Cells[1].Text;
            //Response.Redirect("~/Paginas/Personas/ActualizarJuridicos.aspx?act=" + HFIdPersona.Value);
        }

        protected void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Personas/RegistroJuridicos.aspx");
        }

        protected void GridListadoJuridicas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ////IdPersona de la tabla que selecciona
            //HFIdPersona.Value = GridListadoJuridicas.Rows[e.NewEditIndex].Cells[1].Text;
            ////Envia IdPersona a formulario de actualizar   
            //Response.Redirect("~/Paginas/Personas/ActualizarJuridicos.aspx?act=" + HFIdPersona.Value);
        }

        protected void GridListadoJuridicas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Actualizar")
            {
                //Envia IdPersona a formulario de actualizar   
                Response.Redirect("~/Paginas/Personas/ActualizarJuridicos.aspx?act=" + e.CommandArgument);
            }
        }
    }
}
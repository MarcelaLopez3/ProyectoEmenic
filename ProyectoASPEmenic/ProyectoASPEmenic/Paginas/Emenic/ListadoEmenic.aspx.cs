using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Emenic
{
    public partial class ListadoEmenic : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //Cargar las dos tablas
                CargarGrid1();
                CargarGrid2();
            }
            else if (!IsPostBack)
            {
                //Cargar las dos tablas
                CargarGrid1();
                CargarGrid2();
            }
        }

        //Debo cambiar los eventos

        protected void GridListadoEmenic1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        protected void GridListadoEmenic2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        //Informacion de emenic
        protected void CargarGrid1()
        {
            query = "SELECT IdPersona,NombreLegal,Tamano,Ubicacion,Pais,Giro," +
                "NombreContacto FROM persona WHERE IdPersona = 1;";
            EjecutarGridEmenic(query, this.GridListadoEmenic1);
        }

        //Informacion logistica de emenic
        protected void CargarGrid2()
        {
            query = "SELECT Id,Mision,Vision,Valores,Servicios,Descripcion " +
                "FROM emenic WHERE Id = 1;";
            EjecutarGridEmenic(query, this.GridListadoEmenic2);
        }

        protected void EjecutarGridEmenic(string query, GridView grid)
        {
            conexion.IniciarConexion();
            conexion.TablasQuery(query, grid);
            conexion.CerrarConexion();
        }

        protected void btnDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Dashboard.aspx");
        }

        protected void GridListadoEmenic1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //tabla persona
            //Ir a formulario de Ver detalles de emenic
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ver Detalles de Emenic.')", true);
        }

        protected void GridListadoEmenic2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //tabla emenic
            //Ir a formulario de Ver informacion logistica de emenic
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ver informacion logistica de Emenic.')", true);
        }
    }
}
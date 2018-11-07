using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Clientes
{
    public partial class ListadoClientes : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CargarGridCliente(ddltipopersona.SelectedValue);
            }
            else if (!IsPostBack)
            {
                ddltipopersona.SelectedValue = "PersonaJuricica";
                CargarGridCliente(ddltipopersona.SelectedValue);
            }
        }

        protected void CargarGridCliente(string TipoPersona)
        {
            //Seleccionar tipo
            if (TipoPersona == "PersonaNatural")
            {
                query = "SELECT IdPersona,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido," +
                "DUI,NIT,Activo FROM persona WHERE PersonaNatural = 1 AND Activo = 1 AND Cliente = 1;";
                EjecutarGridCliente(query);
            }
            else if (TipoPersona == "PersonaJuridica")
            {
                query = "SELECT IdPersona,NombreLegal,Tamano,Ubicacion,Pais,Giro," +
               "NombreContacto,Activo FROM persona WHERE PersonaJuridica = 1 AND Activo = 1 AND Cliente = 1;";
                EjecutarGridCliente(query);
            }            
        }

        protected void EjecutarGridCliente(string query)
        {
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoClientes);
            conexion.CerrarConexion();
        }        

        protected void GridListadoClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Boton para agregar un nuevo servicio al cliente
            //IdPersona de la tabla que selecciona
            HFIdPersona.Value = GridListadoClientes.Rows[e.NewEditIndex].Cells[1].Text;
            //Envia IdPersona a formulario de servicios       
            Response.Redirect("~/Paginas/Servicios/ServicioContratado.aspx?ser=" + HFIdPersona.Value);
        }

        protected void GridListadoClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //IdPersona de la tabla que selecciona
            HFIdPersona.Value = GridListadoClientes.Rows[e.RowIndex].Cells[1].Text;
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se eliminará al cliente "+ HFIdPersona.Value+"')", true);
        }
    }
}
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
            string query = "";
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

        protected void GridListadoClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/ServicioContratado.aspx");
        }
    }
}
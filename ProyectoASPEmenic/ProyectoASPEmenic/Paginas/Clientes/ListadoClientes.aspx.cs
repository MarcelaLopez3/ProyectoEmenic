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
            int Resultado_servicio = 0;
            //IdPersona de la tabla que selecciona
            HFIdPersona.Value = GridListadoClientes.Rows[e.RowIndex].Cells[1].Text;

            //Verificar si la persona posee o ha tenido servicios contratados de emenic
            query = "SELECT IF( EXISTS(SELECT * FROM serviciocontratado WHERE IdCliente = '" + HFIdPersona.Value + "'), 1, 0) as Resultado";
            conexion.IniciarConexion();
            conexion.RecibeQuery(query);
            while (conexion.reg.Read())
            {
                 Resultado_servicio = conexion.reg.GetInt32(0);                
            }
            conexion.reg.Close();
            conexion.CerrarConexion();

            //verificar si es o no eliminado
            if (Resultado_servicio == 1)
            {
                //no puede ser eliminado porque tiene registros hijos
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cliente NO puede ser eliminado, tiene servicios contratados.')", true);
            }
            else
            {
                //si puede ser eliminado
                query = "UPDATE persona SET Cliente = 0 WHERE IdPersona = " + HFIdPersona.Value;
                conexion.IniciarConexion();
                conexion.EnviarQuery(query);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se eliminó al cliente " + HFIdPersona.Value + "')", true);
                conexion.CerrarConexion();
                Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
            }

            HFIdPersona.Value = "";
            
        }
    }
}
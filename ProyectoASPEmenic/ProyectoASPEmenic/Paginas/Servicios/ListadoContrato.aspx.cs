using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ListadoContrato : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            query = "SELECT `contrato`.`IdContrato`,`transporte`.`Placa`, concat_ws(' -> ', p1.NombreSegunNIT,p2.NombreSegunNIT) as Servicio, `contrato`.`FechaEmision`, `contrato`.`CantidadMeses` " +
                    "FROM `contrato` " +
                    "INNER JOIN `transporte` ON `contrato`.`IdTransporte` = `transporte`.`IdTransporte` " +
                    "INNER JOIN serviciocontratado ON contrato.IdServicio = serviciocontratado.Id " +
                    "INNER JOIN persona p1 ON serviciocontratado.IdCliente = p1.IdPersona " +
                    "INNER JOIN persona p2 ON serviciocontratado.IdConsignatorio = p2.IdPersona";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoContrato);
            conexion.CerrarConexion();
        }

        protected void GridListadoContrato_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Paginas/Servicios/ActualizarContrato.aspx?act=" + e.CommandArgument);
            }
        }

        protected void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroContrato.aspx");
        }
    }
}
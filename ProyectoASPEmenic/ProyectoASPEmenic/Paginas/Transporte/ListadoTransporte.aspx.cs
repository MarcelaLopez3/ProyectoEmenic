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
        //string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT `IdTransporte`, `Placa`, `Descripcion`, `Equipo`, `Furgon`, `Cabezal` FROM transporte;";
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoTransporte);
            conexion.CerrarConexion();
            GridListadoTransporte.DataBind();
        }
        protected void GridListadoTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridListadoTransporte.SelectedRow;
            HFIdTransporte.Value = row.Cells[1].Text;
            Response.Redirect("~/Paginas/Transporte/ActualizarTransporte.aspx?act=" + HFIdTransporte.Value);
        }

        protected void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Transporte/Transporte.aspx");
        }

        protected void GridListadoTransporte_Eliminar(object sender, GridViewDeleteEventArgs e)
        {
            string query;
            int Resultado_transporte = 0;
            int Resultado_transporte1 = 0;
            //IdPersona de el transporte que selecciona
            HFIdTransporte.Value = GridListadoTransporte.Rows[e.RowIndex].Cells[1].Text;

            //Verificar si el transporte posee o ha tenido servicios contratados de emenic
            query = "SELECT * FROM contrato WHERE IdTransporte = " + HFIdTransporte.Value ;
            conexion.IniciarConexion();
            conexion.RecibeQuery(query);
            while (conexion.reg.Read())
            {
                Resultado_transporte = conexion.reg.GetInt32(0);
            }
            conexion.reg.Close();
            conexion.CerrarConexion();

            //verificar si es o no eliminado
            if (Resultado_transporte == 1)
            {
                //no puede ser eliminado porque tiene registros hijos
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Transporte NO puede ser eliminado, tiene contratos.')", true);
            }
            else
            {
                //verifica si no existe el transporte en cartaporte
                query = "SELECT * FROM cartaporte WHERE IdTransporte = " + HFIdTransporte.Value;
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    Resultado_transporte1 = conexion.reg.GetInt32(0);
                }
                conexion.reg.Close();
                conexion.CerrarConexion();

                //verificar si es o no eliminado
                if (Resultado_transporte1 == 1)
                {
                    //no puede ser eliminado porque tiene registros hijos
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Transporte NO puede ser eliminado, tiene contratos.')", true);
                }
                else
                {
                    //si puede ser eliminado
                    query = "DELETE FROM transporte WHERE IdTransporte = " + HFIdTransporte.Value;
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se eliminó el transporte " + int.Parse(HFIdTransporte.Value) + "')", true);
                    conexion.CerrarConexion();
                    Response.Redirect("~/Paginas/Transporte/ListadoTransporte.aspx");
                }
            }

            HFIdTransporte.Value = "";
        }
    }
}
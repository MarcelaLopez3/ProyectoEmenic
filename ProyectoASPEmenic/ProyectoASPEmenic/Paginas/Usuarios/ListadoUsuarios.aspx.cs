using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Usuarios
{
    public partial class ListadoUsuarios : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT persona.IdPersona as Id,concat(PrimerNombre,' ',SegundoNombre)" +
                " as Nombres,concat(PrimerApellido,' ',SegundoApellido) as Apellidos,NombreUsuario as Usuario,estado as Estado" +
                " FROM persona left join usuario on persona.IdPersona=usuario.IdPersona where PersonaNatural=1 and usuario=1";
            cn.IniciarConexion();
            cn.TablasQuery(query, this.dataTable);
            cn.CerrarConexion();
        }

        protected void dataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void dataTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Actualizar")
            {
                string ID = e.CommandArgument.ToString();
                int existeUsuario = 0;
                string query = "select count(idusuario) from usuario where idpersona=" + ID;
                cn.IniciarConexion();
                cn.RecibeQuery(query);
                if (cn.reg.Read())
                {
                    existeUsuario = cn.reg.GetInt32(0);
                }
                cn.CerrarConexion();
                if (existeUsuario == 0)
                {
                    Response.Redirect("~/Paginas/Usuarios/CrearUsuario.aspx?id=" + ID);
                }
                else
                {
                    Response.Redirect("~/Paginas/Usuarios/ActualizarUsuario.aspx?id=" + ID);
                }

            }
        }
    }
}
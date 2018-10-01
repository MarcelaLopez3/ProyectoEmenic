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
                " as Nombres,concat(PrimerApellido,' ',SegundoApellido) as Apellidos,NombreUsuario as Usuario,Activo" +
                " FROM persona left join usuario on persona.IdPersona=usuario.IdPersona where PersonaNatural=1 and usuario=1";
            cn.IniciarConexion();
            cn.TablasQuery(query, this.GridListadoUsuarios);
            cn.CerrarConexion();
        }
    }
}
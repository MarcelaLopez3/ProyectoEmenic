using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Usuarios
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.IniciarConexion();
            ddlUsers.DataSource = cn.llena("SELECT idPersona,PrimerNombre FROM `persona` WHERE PersonaNatural=1");
            ddlUsers.DataTextField = "PrimerNombre";
            ddlUsers.DataValueField = "idPersona";
            ddlUsers.DataBind();
            cn.CerrarConexion();
        }
    }
}
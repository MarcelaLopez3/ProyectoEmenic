using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic
{
    public partial class Login : System.Web.UI.Page
    {
        Conexion cn = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pwd = txtContrasena.Text;
            int counter = 0;
            string query = "SELECT count(IdUsuario) from usuario inner join persona on usuario.IdPersona=persona.IdPersona where" +
                " NombreUsuario = '" + usuario + "' and ContrasenaUsuario = sha1('" + pwd + "') and usuario.estado=true";
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                counter = cn.reg.GetInt32(0);
            }
            cn.CerrarConexion();
            if (counter > 0)
            {
                Session["Usuario"] = usuario;
                Response.Redirect("~/Paginas/Dashboard.aspx");
            }
            else
            {   // No encuentra coincidencias
                lblNotificacion.Text = "Credenciales incorrectas";
                lblNotificacion.Visible = true;
            }
        }
    }
    
}
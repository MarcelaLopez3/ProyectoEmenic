using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                //Si no ha iniciado sesión o la sesión expiro, redirige al login
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lblUserSession.Text = "¡Bienvenido " + Session["Usuario"].ToString() +"!";
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("~/Paginas/Publicidad/Index.aspx");
        }
    }
}
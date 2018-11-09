using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ServicioContratado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MVServicios.SetActiveView(VNuevoServicio);
            CargandoServicio();
        }

        protected void CargandoServicio()
        {
            if (checkTransporte.Checked == true)
            {
                btnCartaPorte.Visible = true;
            }
            else 
            {
                btnCartaPorte.Visible = false;
            }

            if (checkAlquiler.Checked == true)
            {
                btnContrato.Visible = true;
            }
            else
            {
                btnContrato.Visible = false;
            }
        }

        protected void btnCartaPorte_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroCartaporte.aspx");
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroContrato.aspx");
        }
    }
}
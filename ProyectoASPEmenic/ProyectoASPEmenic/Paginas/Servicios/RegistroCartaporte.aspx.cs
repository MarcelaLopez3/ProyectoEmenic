using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class RegistroCartaporte : System.Web.UI.Page
    {
        //Variables globales
        string query;
        Conexion cn;

        //Propiedades
        public int IdServicio
        {
            set
            {
                hfIdServicio.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfIdServicio.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["srv"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un servicio.')", true);
                btnGuardarcartaporte.Visible = false;
            }
            else
            {
                IdServicio = int.Parse(Request.QueryString["srv"].ToString());                              
            }
        }
    }
}
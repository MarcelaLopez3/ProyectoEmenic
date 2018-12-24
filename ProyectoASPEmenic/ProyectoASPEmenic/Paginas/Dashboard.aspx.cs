using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Conexion cn = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadCards();
            }
        }

        //Función para cargar datos de las tarjetas
        private void loadCards()
        {
            string query = "SELECT count(*) as TotalClientes from persona where persona.Cliente=1";
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                lblClientes.Text = cn.reg.GetString(0);
            }
            cn.reg.Close();
            query = "SELECT count(*) as TotalEquipo from transporte";
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                lblEquipo.Text = cn.reg.GetString(0);
            }
            cn.reg.Close();
            query = "SELECT count(*) from serviciocontratado";
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                lblServicios.Text = cn.reg.GetString(0);
            }
            cn.reg.Close();
            query = "SELECT count(*) from usuario WHERE usuario.Estado=1";
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                lblUsuarios.Text = cn.reg.GetString(0);
            }
            cn.CerrarConexion();
        }
    }
}
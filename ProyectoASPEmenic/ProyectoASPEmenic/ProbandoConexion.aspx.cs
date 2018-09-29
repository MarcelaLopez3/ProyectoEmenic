using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoASPEmenic
{
    public partial class ProbandoConexion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.IniciarConexion();
            string consulta = "Select Vision from emenic";
            MySqlDataReader reader = con.RecibeQuery(consulta);

            while (reader.Read())
            {
                lbTexto.Text = reader.GetString(0);
            }
        }
    }
}
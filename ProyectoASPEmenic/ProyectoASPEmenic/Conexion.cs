using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic
{
    public class Conexion
    {
        public Conexion()
        {

        }
        public MySqlConnection cnn = new MySqlConnection("Persist Security Info=False;server=localhost;SslMode=none;database=bdd_emenic;uid=root;password=");
        //variables de conexion
        //public MySqlConnection cnn = new MySqlConnection();
        //MySqlConnection cnn = new MySqlConnection("server=localhost:81;database=bdd_emenic;userid=root2;password=123456;charsetutf8;");
        public MySqlDataReader reg;


        //funcion que inicia conexion
        public void IniciarConexion()
        {
            try
            {
                //cnn.ConnectionString = (@"Server=localhost;Port=81;Database=bdd_emenic;Uid=root2;Pwd=123456;charsetutf8;");
                cnn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //using (cnn)
            //{
            //    cnn.Open();
            //}

        }

        public void CerrarConexion()
        {
            cnn.Close();
        }

        public void EnviarQuery(string query)
        {
            MySqlCommand con = new MySqlCommand(query, cnn);
            con.ExecuteNonQuery();
        }

        public MySqlDataReader RecibeQuery(string query)
        {
            MySqlCommand con = new MySqlCommand(query, cnn);
            con.ExecuteNonQuery();
            reg = con.ExecuteReader();
            return reg;
        }

        public void TablasQuery(string query, GridView tabla)
        {
            try
            {
                MySqlCommand con = new MySqlCommand(query, cnn);
                MySqlDataAdapter da = new MySqlDataAdapter(con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;
                tabla.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
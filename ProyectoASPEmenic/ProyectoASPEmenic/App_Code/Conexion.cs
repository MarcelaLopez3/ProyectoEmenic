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

        //variables de conexion
        public MySqlConnection cnn;
        public MySqlDataReader reg;        

        //funcion que inicia conexion
        public void IniciarConexion()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                builder.Port = 3306;
                builder.Database = "bdd_emenic";
                builder.SslMode = 0;
                builder.PersistSecurityInfo = false;
                //cnn.ConnectionString = "datasource=localhost;port=3307;username=root;password=root";
                cnn = new MySqlConnection(builder.ToString());
                cnn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //funcion que cierra conexion existente
        public void CerrarConexion()
        {
            cnn.Close();
        }

        //funcion que envia query para ser ejecutada, y no devuelve datos (insert,update, delete)
        public void EnviarQuery(string query)
        {
            MySqlCommand con = new MySqlCommand(query, cnn);
            con.ExecuteNonQuery();
        }

        //funcion que envia query para ser ejecutada y devuelve filas
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


        public DataSet llena(string texto)
        {
            MySqlCommand con = new MySqlCommand(texto, cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        //Función para llenar dataset con stored procedure - CARTA PORTE
        public DSEmenic call_sp(int id, int opcion, string dt)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DSEmenic ds = new DSEmenic();
            MySqlCommand cmd = new MySqlCommand();
            IniciarConexion();
            EnviarQuery("SET lc_time_names = 'es_ES'");
            cmd.Connection = cnn;
            cmd.CommandText = "sp_getCartaPorte";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Carta", id);
            cmd.Parameters.AddWithValue("@Opcion", opcion);
            da.SelectCommand = cmd;
            da.Fill(ds,dt);
            CerrarConexion();
            return ds;
        }

        //Función para llenar stored procedure - CONTRATO
        public DSEmenic call_spGetContrato(int servicio,string dt)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DSEmenic ds = new DSEmenic();
            MySqlCommand cmd = new MySqlCommand();
            IniciarConexion();
            EnviarQuery("SET lc_time_names = 'es_ES'");
            cmd.Connection = cnn;
            cmd.CommandText = "sp_getContrato";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Servicio", servicio);
            da.SelectCommand = cmd;
            da.Fill(ds, dt);
            CerrarConexion();
            return ds;
        }

        //Función para llenar stored procedure de Ventas Mensuales de Emenic
        public DSEmenic call_spGetVentasMensuales(int year,string dt)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DSEmenic ds = new DSEmenic();
            MySqlCommand cmd = new MySqlCommand();
            IniciarConexion();
            cmd.Connection = cnn;
            cmd.CommandText = "sp_getVentasMensuales";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Anio", year);
            da.SelectCommand = cmd;
            da.Fill(ds, dt);
            CerrarConexion();
            return ds;
        }

        //Función para obtener datos de bitácora de Emenic
        public DSEmenic call_spGetRegistroActividades(int year, string dt)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DSEmenic ds = new DSEmenic();
            MySqlCommand cmd = new MySqlCommand();
            IniciarConexion();
            EnviarQuery("SET lc_time_names = 'es_ES'");
            cmd.Connection = cnn;
            cmd.CommandText = "sp_getRegistroActividades";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Anio", year);
            da.SelectCommand = cmd;
            da.Fill(ds, dt);
            CerrarConexion();
            return ds;
        }
    }
}
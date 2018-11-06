﻿using System;
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
    }
}
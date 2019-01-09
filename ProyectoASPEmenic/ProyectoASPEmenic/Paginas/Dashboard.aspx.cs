using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
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
                loadYears();
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

        //Función para cargar los años de ventas
        private void loadYears()
        {
            string query = "SELECT year(serviciocontratado.FechaVencimiento) as year from serviciocontratado GROUP by year(serviciocontratado.FechaVencimiento)";
            cn.IniciarConexion();
            ddlYear.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlYear.DataTextField = "year";
            ddlYear.DataValueField = "year";
            ddlYear.DataBind();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string GraphBar(string year)
        {
            DataTable dt = new DataTable("Data");
            Conexion cnn = new Conexion();
            //Agregar columnas al datatable
            dt.Columns.Add("Ventas", typeof(double));
            dt.Columns.Add("Costos", typeof(double));
            dt.Columns.Add("Utilidad", typeof(double));
            //Consulta pata obtener datos
            string query = "SELECT i.mm as mm, IFNULL((sum(sc.PagoEmpresa)+sum(sc.PagoEstadia)+sum(sc.PagoGuardia)),0) as Ventas,"
                + " IFNULL(sum(sc.PagoMotorista)+sum(sc.GastosVarios)+sum(sc.ViaticosMotorista)+(sum(sc.PrecioCombustible*sc.Galones)),0)" +
                " as Costos, IFNULL((sum(sc.PagoEmpresa)+sum(sc.PagoEstadia)+sum(sc.PagoGuardia)),0)-IFNULL(sum(sc.PagoMotorista)+" +
                "sum(sc.GastosVarios)+sum(sc.ViaticosMotorista)+(sum(sc.PrecioCombustible*sc.Galones)),0) as Utilidad FROM " +
                "( SELECT 1 AS mm UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6" +
                " UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12 )" +
                " i LEFT JOIN serviciocontratado sc ON sc.FechaVencimiento >= concat(" + year + ",'-01-01') + INTERVAL ( i.mm - 1 ) MONTH" +
                " AND sc.FechaVencimiento < concat(" + year + ",'-01-01') + INTERVAL ( i.mm + 0 ) MONTH group by i.mm";
            cnn.IniciarConexion();
            cnn.RecibeQuery(query);
            while(cnn.reg.Read())
            {
                //Pasar datos al datatable
                dt.Rows.Add(cnn.reg.GetValue(1), cnn.reg.GetValue(2), cnn.reg.GetValue(3));
            }
            cnn.CerrarConexion();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds.GetXml();
        }
    }
}
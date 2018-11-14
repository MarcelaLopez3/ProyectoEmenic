using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ActulizarContrato : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();

        //Propiedades
        public int IdPlaca
        {
            set
            {
                hfIdPlaca.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfIdPlaca.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarddlIDtransporte();
                //LlenarddlIDservicio();
                string VarAct = Request.QueryString["srv"];
                string query = "SELECT `transporte`.`IdTransporte`, `contrato`.`FechaEmision`, `contrato`.`CantidadMeses` " +
                    "FROM `contrato` " +
                    "INNER JOIN `transporte` ON `contrato`.`IdTransporte` = `transporte`.`IdTransporte` " +
                    "WHERE `contrato`.`IdServicio` = "+VarAct;
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);

                while (conexion.reg.Read())
                {
                    //asignando los valores recuperados de la bdd y validando su contenido
                    if (conexion.reg.GetValue(0) != null || conexion.reg.GetValue(0).ToString() != "")
                    {
                        ddlIDtransporte.SelectedValue = ddlIDtransporte.Items.FindByValue(conexion.reg.GetValue(0).ToString()).Value;
                        IdPlaca = int.Parse(ddlIDtransporte.SelectedValue);
                    }
                    else
                        ddlIDtransporte.Text = "";

                    //if (conexion.reg.GetString(1) != null || conexion.reg.GetString(1) != "")
                    //    ddlIDservicio.SelectedValue = conexion.reg.GetString(1);
                    //else
                    //    ddlIDservicio.SelectedValue = "";

                    if (conexion.reg.GetString(1) != null || conexion.reg.GetString(1) != "")
                    {
                        string fecha = conexion.reg.GetString(1);
                        txtfechaemision.Text = FormatoFecha(fecha);
                    }
                    else
                        txtfechaemision.Text = "";

                    //if (conexion.reg.GetValue(2) != null || conexion.reg.GetValue(2).ToString() != "")
                    //    txtprimerapellido.Text = conexion.reg.GetValue(2).ToString();
                    //else
                    //    txtprimerapellido.Text = "";

                    if (conexion.reg.GetValue(2) != null || conexion.reg.GetValue(2).ToString() != "")
                        txtcantidadmeses.Text = conexion.reg.GetValue(2).ToString();
                    else
                        txtcantidadmeses.Text = "";
                }
                conexion.CerrarConexion();
            }
        }

        //Función para llenar ajaxtoolkit-combobox
        private void LlenarddlIDtransporte()
        {
            string query = "SELECT IdTransporte,Placa from transporte";
            conexion.IniciarConexion();
            ddlIDtransporte.DataSource = conexion.llena(query);
            conexion.CerrarConexion();
            ddlIDtransporte.DataTextField = "Placa";
            ddlIDtransporte.DataValueField = "IdTransporte";
            ddlIDtransporte.DataBind();
        }

        //Función para llenar ajaxtoolkit-combobox
        //private void LlenarddlIDservicio()
        //{
        //    string query = "SELECT a.Id, concat_ws(' -> ', b.NombreSegunNIT,c.NombreSegunNIT) as servicio FROM serviciocontratado a " +
        //    "INNER JOIN persona b ON a.IdCliente = b.IdPersona " +
        //    "INNER JOIN persona c ON a.IdConsignatorio = c.IdPersona";
        //    conexion.IniciarConexion();
        //    ddlIDservicio.DataSource = conexion.llena(query);
        //    conexion.CerrarConexion();
        //    ddlIDservicio.DataTextField = "servicio";
        //    ddlIDservicio.DataValueField = "Id";
        //    ddlIDservicio.DataBind();
        //}

        protected void btnActualizarContrato_Click(object sender, EventArgs e)
        {
            string VarSer = Request.QueryString["srv"];
            int IdServicio = Convert.ToInt32(VarSer);

            //recuperando entradas
            int IdTransporte = string.IsNullOrEmpty(ddlIDtransporte.SelectedValue) ? IdPlaca : Int32.Parse(ddlIDtransporte.SelectedValue);
            //int IdServicio = Int32.Parse(ddlIDservicio.SelectedValue);
            int CantidadMeses = Int32.Parse(txtcantidadmeses.Text);
            string FechaEmision = txtfechaemision.Text;

            //consulta que se ingresa a la base de datos
            string query = "UPDATE `contrato` " +
            "SET `IdTransporte`='" + IdTransporte + "'," +
            "`CantidadMeses`='" + CantidadMeses + "'," +
            "`FechaEmision` ='" + FechaEmision + "' " +
            "WHERE `contrato`.`IdServicio` =" + IdServicio + ";";
            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado con exito.')", true);
            if (String.IsNullOrEmpty(VarSer))
            {
                Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
            }
            Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            string VarSer = Request.QueryString["ser"];
            if (String.IsNullOrEmpty(VarSer))
            {
                Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
            }
            Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
        }

        protected string FormatoFecha(string fecha)
        {
            DateTime nueva = DateTime.Parse(fecha);
            string nueva2 = nueva.ToShortDateString();
            string[] words = nueva2.Split('/');
            string devuelve = words[2] + "-" + words[1] + "-" + words[0];
            return devuelve;
        }
    }
}
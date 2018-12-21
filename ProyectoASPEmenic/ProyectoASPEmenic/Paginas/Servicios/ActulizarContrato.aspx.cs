using Microsoft.Reporting.WebForms;
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

        public int IdServicio
        {
            set
            {
                hfServicio.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfServicio.Value);
            }
        }

        public int IdCliente
        {
            set
            {
                hfIdCliente.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfIdCliente.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string VarAct = Request.QueryString["srv"];
                IdServicio = int.Parse(VarAct);
                MVContrato.SetActiveView(VActualizar);
                LlenarddlIDtransporte();
                getNombreCliente();
                //LlenarddlIDservicio();                
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
                        txtfechaemision.Text = DateTime.Parse(fecha).ToShortDateString();
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

        private void getNombreCliente()
        {
            string query = "SELECT serviciocontratado.IdCliente as Id,if(persona.PersonaNatural=1," +
                "concat(persona.PrimerNombre,' ',persona.SegundoNombre,' ',persona.PrimerApellido,' '," +
                "persona.SegundoApellido),persona.NombreLegal) as Cliente,if(persona.PersonaNatural=1," +
                "concat(persona.DireccionResidencia,', ',persona.MunicipioResidencia,', ',persona.DepartamentoResidencia)" +
                ",concat(persona.Ubicacion,', ',persona.MunicipioCiudad,', ',persona.DepartamentoEstado)) as Direccion" +
                " from contrato inner join serviciocontratado on contrato.IdServicio=serviciocontratado.Id inner join " +
                "persona on serviciocontratado.IdCliente=persona.IdPersona where serviciocontratado.Id=" + IdServicio;
            conexion.IniciarConexion();
            conexion.RecibeQuery(query);
            while (conexion.reg.Read())
            {
                IdCliente = conexion.reg.GetInt32(0);
                lblCliente.Text = conexion.reg.GetString(1);
                lblDireccion.Text = conexion.reg.GetString(2);
            }
            conexion.CerrarConexion();

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
            string FechaEmision = FormatoFecha(txtfechaemision.Text);

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
            MVContrato.SetActiveView(VActualizar);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            //string VarSer = Request.QueryString["srv"];
            //if (String.IsNullOrEmpty(VarSer))
            //{
            //    Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
            //}
            Response.Redirect("~/Paginas/Servicios/ServicioContratado.aspx?ser="+IdCliente);
        }

        protected string FormatoFecha(string fecha)
        {
            DateTime nueva = DateTime.Parse(fecha);
            string nueva2 = nueva.ToShortDateString();
            string[] words = nueva2.Split('/');
            string devuelve = words[2] + "-" + words[1] + "-" + words[0];
            return devuelve;
        }

        protected void btnModificarContrato_Click(object sender, EventArgs e)
        {
            MVContrato.SetActiveView(VActualizar);
        }

        protected void btnGenerarContrato_Click(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/RContrato.rdlc");
            //Se utiliza el mismo reporte para manifiesto de carga
            DSEmenic ds = conexion.call_spGetContrato(IdServicio, "Contrato");
            ReportDataSource source = new ReportDataSource("DataSet1", ds.Tables[1]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(source);
            ReportViewer1.LocalReport.Refresh();
            MVContrato.SetActiveView(VContrato);
        }
    }
}
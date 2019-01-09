using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Reportes
{
    public partial class Reportes : System.Web.UI.Page
    {
        //Declaración de variables
        Conexion cn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string query = "SELECT year(serviciocontratado.FechaVencimiento)" +
                " as year from serviciocontratado GROUP by year(serviciocontratado.FechaVencimiento) " +
                "order by year(serviciocontratado.FechaVencimiento) desc";
                cn.IniciarConexion();
                ddlYear.DataSource = cn.llena(query);
                cn.CerrarConexion();
                ddlYear.DataTextField = "year";
                ddlYear.DataValueField = "year";
                ddlYear.DataBind();
            }
        }

        protected void btnGenerarVentas_Click(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reportes/RVentasMensuales.rdlc");
            DSEmenic ds = cn.call_spGetVentasMensuales(int.Parse(ddlYear.SelectedValue), "VentasMensuales");
            ReportDataSource source = new ReportDataSource("DSEmenic", ds.Tables[2]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(source);
            ReportViewer1.LocalReport.Refresh();
            mvReport.SetActiveView(vVentas);
        }

        protected void btnGenerarRegistros_Click(object sender, EventArgs e)
        {
            ReportViewer2.ProcessingMode = ProcessingMode.Local;
            ReportViewer2.LocalReport.ReportPath = Server.MapPath("~/Reportes/RRegistroActividades.rdlc");
            DSEmenic ds = cn.call_spGetRegistroActividades(int.Parse(ddlYear.SelectedValue), "RegistroActividades");
            ReportDataSource source = new ReportDataSource("DataSet1", ds.Tables[3]);
            ReportViewer2.LocalReport.DataSources.Clear();
            ReportViewer2.LocalReport.DataSources.Add(source);
            ReportViewer2.LocalReport.Refresh();
            mvReport.SetActiveView(vRegistro);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ServicioContratado : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            MVServicios.SetActiveView(VNuevoServicio);
            CargandoDocumentoServicio();
            CargandoTablaServicio();
            cargarDestinos();
        }

        protected void CargandoDocumentoServicio()
        {
            if (checkTransporte.Checked == true)
            {
                btnCartaPorte.Visible = true;
            }
            else 
            {
                btnCartaPorte.Visible = false;
            }

            if (checkAlquiler.Checked == true)
            {
                btnContrato.Visible = true;
            }
            else
            {
                btnContrato.Visible = false;
            }
        }

        protected void CargandoTablaServicio()
        {
            if (IsPostBack)
            {
                TipoServicio(ddltiposervicio.SelectedValue);
            }
            else if (!IsPostBack)
            {
                ddltiposervicio.SelectedValue = "Transporte";
                TipoServicio(ddltiposervicio.SelectedValue);
            }
        }

        protected void TipoServicio(string tipo)
        {
            //recuperando el IdCliente
            string VarSer = Request.QueryString["ser"];

            //Seleccionar tipo
            if (tipo == "Alquiler")
            {
                query = "SELECT Id,PagoEmpresa,FechaAdquisicion,FechaVencimiento,Descripcion" +
                " FROM serviciocontratado WHERE IdCliente = "+ VarSer + " AND Alquiler = 1;";
                EjecutarGridServicio(query);
            }
            else if (tipo == "Transporte")
            {
                query = "SELECT Id,PagoEmpresa,FechaAdquisicion,FechaVencimiento,Descripcion" +
               " FROM serviciocontratado WHERE IdCliente = " + VarSer + " AND Transporte = 1;";
                EjecutarGridServicio(query);
            }
        }

        //Función para llenar combobox
        protected void cargarDestinos()
        {
            string query = "SELECT IdPersona,NombreComercial from persona where PersonaJuridica=1 and Activo=1";
            conexion.IniciarConexion();
            ddlDestinoConsignatario.DataSource = conexion.llena(query);
            conexion.CerrarConexion();
            ddlDestinoConsignatario.DataTextField = "NombreComercial";
            ddlDestinoConsignatario.DataValueField = "IdPersona";
            ddlDestinoConsignatario.DataBind();            
        }

        protected void EjecutarGridServicio(string query)
        {
            conexion.IniciarConexion();
            conexion.TablasQuery(query, this.GridListadoServicio);
            conexion.CerrarConexion();
        }

        protected void btnCartaPorte_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroCartaporte.aspx");
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Servicios/RegistroContrato.aspx");
        }

        protected void btnAgregarServicioContra_Click(object sender, EventArgs e)
        {
            //recuperando entradas
            bool Transporte = checkTransporte.Checked;
            bool Alquiler = checkAlquiler.Checked;
            string FechaAdquisicion = txtfechaAdquisicion.Text;
            string FechaVencimiento = txtfechaVencimiento.Text;
            string Descripcion = txtDescripcion.Text;
            string PeriodoCobro = txtperiodocobro.Text;
            bool Retorno = false;
            if (ddlretorno.SelectedValue == "Si")
            {
                Retorno = true;
            }
            string Destino = ddlDestinoConsignatario.SelectedValue;
            string PagoEmpresa = txtpagoempresa.Text;
            string PagoEstadia = txtpagoestadia.Text;
            string PagoGuardia = txtpagoguardia.Text;
            string ViaticosMotorista = txtviaticos.Text;
            string Galones = txtgalones.Text;            
        }
    }
}
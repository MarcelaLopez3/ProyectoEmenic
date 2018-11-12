using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class RegistroCartaporte : System.Web.UI.Page
    {
        //Variables globales
        string query;
        Conexion cn = new Conexion();

        //Propiedades
        public int IdServicio
        {
            set
            {
                hfIdServicio.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfIdServicio.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["srv"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione un servicio.')", true);
                btnGuardarcartaporte.Visible = false;
            }
            else
            {
                IdServicio = int.Parse(Request.QueryString["srv"].ToString());
                cargarMotoristas();
                cargarCabezal();
                cargarFurgon();
                cargarTransporte();                            
            }
        }

        //Función para cargar nombre de empleados
        public void cargarMotoristas()
        {
            query = "SELECT IdPersona as Id,concat(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as Nombre from persona where Empleado=1";
            cn.IniciarConexion();
            ddlConductor.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlConductor.DataTextField = "Nombre";
            ddlConductor.DataValueField = "Id";
            ddlConductor.DataBind();
        }

        //Función para cargar cabezales
        public void cargarCabezal()
        {
            query = "SELECT IdTransporte as Id, Placa from transporte where Cabezal=1";
            cn.IniciarConexion();
            ddlIDcabezal.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlIDcabezal.DataTextField = "Placa";
            ddlIDcabezal.DataValueField = "Id";
            ddlIDcabezal.DataBind();
        }

        //Función para cargar furgones
        public void cargarFurgon()
        {
            query = "SELECT IdTransporte as Id, Placa from transporte where Furgon=1";
            cn.IniciarConexion();
            ddlIDfurgon.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlIDfurgon.DataTextField = "Placa";
            ddlIDfurgon.DataValueField = "Id";
            ddlIDfurgon.DataBind();
        }

        //Función para cargar transporte
        public void cargarTransporte()
        {
            query = "SELECT IdPersona as Id,NombreLegal as empresa FROM persona where IdPersona=1 or (Cliente=1 and PersonaJuridica=1)";
            cn.IniciarConexion();
            ddlTransporte.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlTransporte.DataTextField = "empresa";
            ddlTransporte.DataValueField = "Id";
            ddlTransporte.DataBind();
        }
    }
}
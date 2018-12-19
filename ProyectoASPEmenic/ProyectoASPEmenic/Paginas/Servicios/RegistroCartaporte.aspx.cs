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
                if (Request.QueryString["srv"] == null)
                {
                    mensaje("Seleccione un servicio.");
                    btnGuardarcartaporte.Visible = false;
                }
                else
                {
                    IdServicio = int.Parse(Request.QueryString["srv"].ToString());
                    cargarMotoristas();
                    cargarCabezal();
                    cargarFurgon();
                    cargarTransporte();
                    cargarInformacion();
                }
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
            query = "SELECT IdPersona as Id,NombreLegal as empresa FROM persona where IdPersona=1 or (Socio=1 and PersonaJuridica=1)";
            cn.IniciarConexion();
            ddlTransporte.DataSource = cn.llena(query);
            cn.CerrarConexion();
            ddlTransporte.DataTextField = "empresa";
            ddlTransporte.DataValueField = "Id";
            ddlTransporte.DataBind();
        }

        //Función para cargar información
        public void cargarInformacion()
        {
            query = "SELECT sc.IdCliente as Id,if(re.PersonaJuridica=1,re.NombreLegal,concat(re.PrimerNombre,' ',"
                +"re.SegundoNombre,' ',re.PrimerApellido,' ',re.SegundoApellido)) as Remitente,if(co.PersonaJuridica=1"
                +",co.NombreLegal,concat(co.PrimerNombre,' ',co.SegundoNombre,' ',co.PrimerApellido,' ',co.SegundoApellido))"+
                " as Consignatario from serviciocontratado sc inner join persona re on re.IdPersona=sc.IdCliente inner join "
                +"persona co on co.IdPersona=sc.IdConsignatorio where sc.Id=" + IdServicio;
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            while(cn.reg.Read())
            {
                IdCliente = cn.reg.GetInt32(0);
                lblRemitente.Text = cn.reg.GetString(1);
                lblConsignatario.Text = cn.reg.GetString(2);
            }
            cn.CerrarConexion();
        }

        protected void btnGuardarcartaporte_Click(object sender, EventArgs e)
        {
            if (ddlConductor.SelectedValue == "")
            {
                mensaje("Seleccione un motorista.");
            }
            else
            {
                int idConductor = Int32.Parse(ddlConductor.SelectedValue);
                int idCabezal = Int32.Parse(ddlIDcabezal.SelectedValue);
                int idFurgon = Int32.Parse(ddlIDfurgon.SelectedValue);
                string fecha = !string.IsNullOrEmpty(txtfechacartaporte.Text) ? DateTime.Parse(txtfechacartaporte.Text).ToString("yyyy-MM-dd") : DateTime.Today.ToString("yyyy-MM-dd");
                string aduanaIngreso = !string.IsNullOrEmpty(txtaduanaentrada.Text) ? txtaduanaentrada.Text : "";
                string lugarEmbarque = !string.IsNullOrEmpty(txtlugarembarque.Text) ? txtlugarembarque.Text : "";
                string aduanaSalida = !string.IsNullOrEmpty(txtaduanasalida.Text) ? txtaduanasalida.Text : "";
                string lugarDestino = !string.IsNullOrEmpty(txtdestinocartaporte.Text) ? txtdestinocartaporte.Text : "";
                int idTransporte = Int32.Parse(ddlTransporte.SelectedValue);
                string codigo = !string.IsNullOrEmpty(txtcodigocartaporte.Text) ? txtcodigocartaporte.Text : "";
                string contenido = !string.IsNullOrEmpty(txtcontenidocartaporte.Text) ? txtcontenidocartaporte.Text : "";
                string descripcion = !string.IsNullOrEmpty(txtdestinocartaporte.Text) ? txtdescripcion.Text : "";
                int cantidad = int.TryParse(txtcantidad.Text, out cantidad) ? int.Parse(txtcantidad.Text) : 0;
                double pesoNeto = double.TryParse(txtpesoneto.Text, out pesoNeto) ? double.Parse(txtpesoneto.Text) : 0;
                float totalPesoNeto = float.TryParse(txttotalpesoneto.Text, out totalPesoNeto) ? float.Parse(txttotalpesoneto.Text) : 0;
                float totalPesoBruto = float.TryParse(txttotalpesobruto.Text, out totalPesoBruto) ? float.Parse(txttotalpesobruto.Text) : 0;
                float flete = float.TryParse(txtflete.Text, out flete) ? float.Parse(txtflete.Text) : 0;
                string observaciones = !string.IsNullOrEmpty(txtobservacionescartaporte.Text) ? txtobservacionescartaporte.Text : "";

                query = "INSERT INTO `cartaporte`(`IdServicio`, `IdCabezal`, `IdFurgon`, `IdConductor`, `IdTransporte`, `Fecha`,"
                    + " `AduanaIngreso`, `AduanaSalida`, `LugarDestino`, `LugarEmbarque`, `Codigo`, `Cantidad`, `Descripcion`, `PesoNeto`,"
                    + " `Contenido`, `TotalPesoBruto`, `TotalPesoNeto`, `Flete`, `Observaciones`) VALUES (" + IdServicio + "," + idCabezal + ","
                    + idFurgon + "," + idConductor + "," + idTransporte + ",'" + fecha + "','" + aduanaIngreso + "','" + aduanaSalida + "','" + lugarDestino + "','"
                    + lugarEmbarque + "','" + codigo + "'," + cantidad + ",'" + descripcion + "','" + pesoNeto + "','" + contenido + "','" + totalPesoBruto + "','" + totalPesoNeto
                    + "','" + flete + "','" + observaciones + "')";

                try
                {
                    //Enviar consulta
                    cn.IniciarConexion();
                    cn.EnviarQuery(query);
                    cn.CerrarConexion();
                    Response.Redirect("~/Paginas/Servicios/ActualizarCartaPorte.aspx?srv=" + IdServicio);
                    mensaje("Se ha insertado el registro con éxito");
                }
                catch (Exception ex)
                {
                    mensaje("Ocurrió un error: " + ex.Message);
                    throw ex;
                }
            }
        }

        public void mensaje(string content)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + content + "')", true);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class ActualizarCartaPorte : System.Web.UI.Page
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

        public int IdCartaPorte
        {
            set
            {
                hfIdCartaPorte.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfIdCartaPorte.Value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
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
                cargaCartaPorte();
            }
        }

        //Función para cargar información de carta porte
        public void cargaCartaPorte()
        {
            query = "select * from cartaporte where IdServicio=" + IdServicio;
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            while(cn.reg.Read())
            {
                IdCartaPorte = cn.reg.GetInt32(0);
                IdServicio = cn.reg.GetInt32(1);
                ddlIDcabezal.SelectedValue = cn.reg.GetInt32(2).ToString();
                ddlIDfurgon.SelectedValue = cn.reg.GetInt32(3).ToString();
                ddlConductor.SelectedValue = ddlConductor.Items.FindByValue(cn.reg.GetInt32(4).ToString()).Value;
                ddlTransporte.SelectedValue = cn.reg.GetInt32(5).ToString();
                txtfechacartaporte.Text = FormatoFecha(cn.reg.GetString(6));
                txtaduanaentrada.Text = cn.reg.GetString(7);
                txtaduanasalida.Text = cn.reg.GetString(8);
                txtdestinocartaporte.Text = cn.reg.GetString(9);
                txtlugarembarque.Text = cn.reg.GetString(10);
                txtcodigocartaporte.Text = cn.reg.GetString(11);
                txtcantidad.Text = cn.reg.GetInt32(12).ToString();
                txtdescripcion.Text = cn.reg.GetString(13);
                txtpesoneto.Text = cn.reg.GetFloat(14).ToString();
                txtcontenidocartaporte.Text = cn.reg.GetString(15);
                txttotalpesobruto.Text = cn.reg.GetFloat(16).ToString();
                txttotalpesoneto.Text = cn.reg.GetFloat(17).ToString();
                txtflete.Text = cn.reg.GetFloat(18).ToString();
                txtobservacionescartaporte.Text = cn.reg.GetString(19);
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

        //Función para cargar información
        public void cargarInformacion()
        {
            query = "SELECT sc.IdCliente as Id,if(re.PersonaJuridica=1,re.NombreLegal,concat(re.PrimerNombre,' ',"
                + "re.SegundoNombre,' ',re.PrimerApellido,' ',re.SegundoApellido)) as Remitente,if(co.PersonaJuridica=1"
                + ",co.NombreLegal,concat(co.PrimerNombre,' ',co.SegundoNombre,' ',co.PrimerApellido,' ',co.SegundoApellido))" +
                " as Consignatario from serviciocontratado sc inner join persona re on re.IdPersona=sc.IdCliente inner join "
                + "persona co on co.IdPersona=sc.IdConsignatorio where sc.Id=" + IdServicio;
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            while (cn.reg.Read())
            {
                IdCliente = cn.reg.GetInt32(0);
                lblRemitente.Text = cn.reg.GetString(1);
                lblConsignatario.Text = cn.reg.GetString(2);
            }
            cn.CerrarConexion();
        }

        public void mensaje(string content)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + content + "')", true);
        }

        protected void btnModificarCP_Click(object sender, EventArgs e)
        {
            Edit(true);
        }

        public void Edit(bool state)
        {
            ddlConductor.Enabled = state;
            ddlIDcabezal.Enabled = state;
            ddlIDfurgon.Enabled = state;
            txtfechacartaporte.Enabled = state;
            txtaduanaentrada.Enabled = state;
            txtlugarembarque.Enabled = state;
            txtaduanasalida.Enabled = state;
            txtdestinocartaporte.Enabled = state;
            ddlTransporte.Enabled = state;
            txtcodigocartaporte.Enabled = state;
            txtcontenidocartaporte.Enabled = state;
            txtdescripcion.Enabled = state;
            txtcantidad.Enabled = state;
            txtpesoneto.Enabled = state;
            txttotalpesoneto.Enabled = state;
            txttotalpesobruto.Enabled = state;
            txtflete.Enabled = state;           
            txtobservacionescartaporte.Enabled = state;
            btnGuardarcartaporte.Visible = state;
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
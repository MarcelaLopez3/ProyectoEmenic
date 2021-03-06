﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Servicios
{
    public partial class RegistroContrato : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        string query = "";

        private int IdCliente
        {
            set
            {
                hfCliente.Value = value.ToString();
            }
            get
            {
                return int.Parse(hfCliente.Value);
            }
        }

        private int IdServicio
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string VarServicio = Request.QueryString["srv"];
                string VarSer = Request.QueryString["ser"];
                if (String.IsNullOrEmpty(VarServicio))
                {
                    if (String.IsNullOrEmpty(VarSer))
                    {
                        Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
                    }
                    Response.Redirect("~/Paginas/Servicios/ServicioContratado.aspx?ser=" + VarSer);
                }
                IdServicio = int.Parse(VarServicio);
                getNombreCliente();
                LlenarddlIDtransporte();
            }
            //LlenarddlIDservicio();
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

        protected void btnGuardarContrato_Click(object sender, EventArgs e)
        {

            //recuperando entradas
            int IdTransporte = Int32.Parse(ddlIDtransporte.SelectedValue);
            //recuperando idcliente para regresar a serviciocontrato
            string VarSer = Request.QueryString["ser"];

            string VarServicio = Request.QueryString["srv"];
            int IdServicio = Convert.ToInt32(VarServicio);

            int CantidadMeses = Int32.Parse(txtcantidadmeses.Text);
            string FechaEmision = txtfechaemision.Text;

            //consulta con la que se verificara si ya existe un contrato
            string queryvalidador = "Select contrato.IdServicio FROM contrato WHERE contrato.IdServicio = " + VarServicio;

            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.RecibeQuery(queryvalidador);

            if (conexion.reg.Read())
            {
                conexion.CerrarConexion();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ya existe un registro de contrato para este servicio.')", true);
                if (String.IsNullOrEmpty(VarSer))
                {
                    Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
                }
                Response.Redirect("~/Paginas/Servicios/ServicioContratado.aspx?ser=" + VarSer);
            }
            else
            {
                conexion.CerrarConexion();
                //consulta que se ingresa a la base de datos
                query = "INSERT INTO `contrato` (`IdContrato`, `IdTransporte`, `IdServicio`, `FechaEmision`, `CantidadMeses`) " +
                        "VALUES(NULL,'" + IdTransporte + "','" + IdServicio + "','" + FechaEmision + "'," + CantidadMeses + ")";
                //enviar consulta a Mysql
                conexion.IniciarConexion();
                conexion.EnviarQuery(query);
                conexion.CerrarConexion();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                if (String.IsNullOrEmpty(VarServicio))
                {
                    Response.Redirect("~/Paginas/Clientes/ListadoClientes.aspx");
                }
                Response.Redirect("~/Paginas/Servicios/ActulizarContrato.aspx?srv=" + IdServicio);
            }
        }
    }
}
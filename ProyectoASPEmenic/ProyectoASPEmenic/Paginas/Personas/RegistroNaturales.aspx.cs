﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Clientes
{
    public partial class RegistroNaturales : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarNaturales_Click(object sender, EventArgs e)
        {
            //recuperando entradas
            string PrimerNombre = txtprimernombre.Text;
            string SegundoNombre = txtsegundonombre.Text;
            string PrimerApellido = txtprimerapellido.Text;
            string SegundoApellido = txtsegundoapellido.Text;
            int Edad = Int32.Parse(txtedad.Text);
            string Genero = ddlgenero.SelectedValue;
            string EstadoCivil = ddlestadocivil.SelectedValue;
            string ProfesionOficio = txtprofesionoficio.Text;
            string DireccionResidencia = txtdireccionresidencia.Text;
            string DepartamentoResidencia = txtdepartamentoresidencia.Text;
            string MunicipioResidencia = txtmunicipioresidencia.Text;
            string FechaNacimiento = txtfechanacimiento.Text;
            string DepartamentoNacimiento = txtdepartamentonacimiento.Text;
            string MunicipioNacimiento = txtmunicipionacimiento.Text;
            string DUI = txtDUI.Text;
            string NIT = txtNIT.Text;
            string NumeroLicencia = txtnumerolicencia.Text;
            string Pasaporte = txtpasaporte.Text;
            string NombreOtro = txtnombreotro.Text;
            string NumeroOtro = txtnumerootro.Text;
            string Telefono1 = txttelefono1.Text;
            string Telefono2 = txttelefono2.Text;
            string Telefono3 = txttelefono3.Text;
            string Celular = txtcelular.Text;
            string Email1 = txtemail1.Text;
            string Email2 = txtemail2.Text;
            string Observaciones = txtobservaciones.Text;
            Boolean Usuario = checkUsuario.Checked;
            Boolean Empleado = checkEmpleado.Checked;
            Boolean Cliente = checkCliente.Checked;
            Boolean RepresentanteLegal = checkRepresentanteLegal.Checked;
            Boolean Proveedor = checkProveedor.Checked;
            Boolean Socio = checkSocio.Checked;
            Boolean PersonaNatural = true;

            //consulta que se ingresa a la base de datos
            string query = "INSERT INTO persona(PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Edad," +
                "Genero,EstadoCivil,ProfesionOficio,DireccionResidencia,DepartamentoResidencia,MunicipioResidencia," +
                "FechaNacimiento,DepartamentoNacimiento,MunicipioNacimiento,DUI,NIT,NumeroLicencia,Pasaporte,NombreOtro," +
                "NumeroOtro,Telefono1,Telefono2,Telefono3,Celular,Email1,Email2,Observaciones,Usuario,Empleado,Cliente," +
                "RepresentanteLegal,Proveedor,Socio,PersonaNatural) VALUES ('" + PrimerNombre +"','" + SegundoNombre + "','" +
                PrimerApellido + "','" + SegundoApellido + "'," + Edad +",'" + Genero + "','" + EstadoCivil + "','" + ProfesionOficio + 
                "','" + DireccionResidencia + "','" + DepartamentoResidencia + "','" + MunicipioResidencia + "','" + FechaNacimiento + 
                "','" +  DepartamentoNacimiento + "','" + MunicipioNacimiento + "','" + DUI + "','" + NIT + "','" + NumeroLicencia + 
                "','" + Pasaporte + "','" + NombreOtro + "','" + NumeroOtro + "','" + Telefono1 + "','" + Telefono2 + "','" + Telefono3 +
                "','" + Celular + "','" + Email1 + "','" + Email2 + "','" + Observaciones + "'," + Usuario + "," + Empleado + 
                "," + Cliente + "," + RepresentanteLegal + "," + Proveedor + "," + Socio + "," + PersonaNatural +")";

            //enviar consulta a Mysql
            conexion.IniciarConexion();
            conexion.EnviarQuery(query);
            conexion.CerrarConexion();

        }
    }
}
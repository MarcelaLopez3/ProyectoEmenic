﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoASPEmenic.Clases;

namespace ProyectoASPEmenic.Paginas.Clientes
{
    public partial class RegistroNaturales : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        Validacion validacion = new Validacion();
        string query = "";
        bool bandera_dui = false, bandera_nit = false, bandera_licencia = false, bandera_pasaporte = false, bandera_otro = false;
        bool contenido_dui = false, contenido_nit = false, contenido_licencia = false, contenido_pasaporte = false, contenido_otro = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            
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
            Boolean Proveedor = checkProveedor.Checked;
            Boolean Socio = checkSocio.Checked;
            Boolean PersonaNatural = true;
            Boolean Activo = true;

            //validando dui
            if (txtDUI.Text.Length > 0 && txtDUI.Text != " ")
            {
                contenido_dui = true;
                if (validacion.EsDui(DUI) == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Dui NO Valido')", true);
                }
                else
                {
                    //si hay dui y es valido, verificar si no hay persona en bdd con ese mismo dui
                    query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE DUI = '" + DUI + "'), 1, 0) as Resultado";
                    conexion.IniciarConexion();
                    conexion.RecibeQuery(query);
                    while (conexion.reg.Read())
                    {
                        int Resultado_dui = conexion.reg.GetInt32(0);
                        if (Resultado_dui == 1)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Dui existente.')", true);
                        }
                        else
                        {
                            bandera_dui = true;
                        }
                    }
                    conexion.reg.Close();
                    conexion.CerrarConexion();
                }
            }
            else
            {
                bandera_dui = true;
            }

            //validando Nit
            if (txtNIT.Text.Length > 0 && txtNIT.Text != " ")
            {
                contenido_nit = true;
                //verificar si no hay persona en bdd con ese mismo nit
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NIT = '" + NIT + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                   int Resultado_nit = conexion.reg.GetInt32(0);
                   if (Resultado_nit == 1)
                   {
                       ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Nit existente.')", true);
                   }
                   else
                   {
                        bandera_nit = true;
                   }
                 }
                 conexion.reg.Close();
                 conexion.CerrarConexion();                
            }
            else
            {
                bandera_nit = true;
            }

            //validando licencia
            if (txtnumerolicencia.Text.Length > 0 && txtnumerolicencia.Text != " ")
            {
                contenido_licencia = true;
                //verificar si no hay persona en bdd con ese mismo numero de licencia
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NumeroLicencia = '" + NumeroLicencia + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_licencia = conexion.reg.GetInt32(0);
                    if (Resultado_licencia == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Licencia existente.')", true);
                    }
                    else
                    {
                        bandera_licencia = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_licencia = true;
            }

            //validando pasaporte
            if (txtpasaporte.Text.Length > 0 && txtpasaporte.Text != " ")
            {
                contenido_pasaporte = true;
                //verificar si no hay persona en bdd con ese mismo numero de pasaporte
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE Pasaporte = '" + Pasaporte + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_pasaporte = conexion.reg.GetInt32(0);
                    if (Resultado_pasaporte == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Pasaporte existente.')", true);
                    }
                    else
                    {
                        bandera_pasaporte = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_pasaporte = true;
            }

            //validando otro documento
            if (txtnumerootro.Text.Length > 0 && txtnumerootro.Text != " ")
            {
                contenido_otro = true;
                //verificar si no hay persona en bdd con ese mismo numero de otro documento
                query = "SELECT IF( EXISTS(SELECT * FROM persona WHERE NumeroOtro = '" + NumeroOtro + "'), 1, 0) as Resultado";
                conexion.IniciarConexion();
                conexion.RecibeQuery(query);
                while (conexion.reg.Read())
                {
                    int Resultado_otro = conexion.reg.GetInt32(0);
                    if (Resultado_otro == 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Otro Documento existente.')", true);
                    }
                    else
                    {
                        bandera_otro = true;
                    }
                }
                conexion.reg.Close();
                conexion.CerrarConexion();
            }
            else
            {
                bandera_otro = true;
            }


            //inicia el insert del registro
            if (bandera_dui == true && bandera_nit == true && bandera_licencia == true && bandera_pasaporte == true && bandera_otro == true)
            {           
                if (contenido_dui == true || contenido_nit == true || contenido_licencia == true || contenido_pasaporte == true || contenido_otro == true)
                {
                    //consulta que se ingresa a la base de datos
                    query = "INSERT INTO persona(PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Edad," +
                        "Genero,EstadoCivil,ProfesionOficio,DireccionResidencia,DepartamentoResidencia,MunicipioResidencia," +
                        "FechaNacimiento,DepartamentoNacimiento,MunicipioNacimiento,DUI,NIT,NumeroLicencia,Pasaporte,NombreOtro," +
                        "NumeroOtro,Telefono1,Telefono2,Telefono3,Celular,Email1,Email2,Observaciones,Usuario,Empleado,Cliente," +
                        "Proveedor,Socio,PersonaNatural,Activo) VALUES ('" + PrimerNombre + "','" + SegundoNombre + "','" +
                        PrimerApellido + "','" + SegundoApellido + "'," + Edad + ",'" + Genero + "','" + EstadoCivil + "','" + ProfesionOficio +
                        "','" + DireccionResidencia + "','" + DepartamentoResidencia + "','" + MunicipioResidencia + "','" + FechaNacimiento +
                        "','" + DepartamentoNacimiento + "','" + MunicipioNacimiento + "','" + DUI + "','" + NIT + "','" + NumeroLicencia +
                        "','" + Pasaporte + "','" + NombreOtro + "','" + NumeroOtro + "','" + Telefono1 + "','" + Telefono2 + "','" + Telefono3 +
                        "','" + Celular + "','" + Email1 + "','" + Email2 + "','" + Observaciones + "'," + Usuario + "," + Empleado +
                        "," + Cliente + "," + Proveedor + "," + Socio + "," + PersonaNatural + "," + Activo + ")";

                    //enviar consulta a Mysql
                    conexion.IniciarConexion();
                    conexion.EnviarQuery(query);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha insertado con exito.')", true);
                    if (Usuario)
                    {
                        //Obtiene el último id del usuario agregado
                        int idUsuario = 0;
                        query = "SELECT max(IdPersona) FROM persona";
                        conexion.RecibeQuery(query);
                        while (conexion.reg.Read())
                        {
                            idUsuario = conexion.reg.GetInt32(0);
                        }
                        conexion.reg.Close();
                        conexion.CerrarConexion();
                        Response.Redirect("~/Paginas/Usuarios/CrearUsuario.aspx?id=" + idUsuario); ///redirige a formulario de usuario
                    }
                    else
                    {
                        conexion.CerrarConexion();
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe haber al menos un documento de identificación.')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se ha podido ingresar registro, verificar que los documentos de identificación son correctos.')", true);
            }
        }
    }
}
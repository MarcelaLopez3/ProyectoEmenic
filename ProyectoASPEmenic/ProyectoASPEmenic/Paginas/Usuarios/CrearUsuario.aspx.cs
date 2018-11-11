using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Usuarios
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] == null)
            { 
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione una persona.')", true);
                btnGuardarUsuario.Visible = false;
            }
            else
            {
                hfIdPersona.Value = Request.QueryString["id"].ToString();
                cargarUsuario(hfIdPersona.Value);
            }
            //cn.IniciarConexion();
            //ddlUsers.DataSource = cn.llena("SELECT idPersona,PrimerNombre FROM `persona` WHERE PersonaNatural=1");
            //ddlUsers.DataTextField = "PrimerNombre";
            //ddlUsers.DataValueField = "idPersona";
            //ddlUsers.DataBind();
            //cn.CerrarConexion();
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtContra.Text, txtConfirmContra.Text) != 0)
            {
                lblNotificacion.Text = "ERROR! Las contraseñas no coinciden";
                lblNotificacion.Visible = true;
            }
            else
            {
                string usuario = txtUsuario.Text;
                string password = txtContra.Text;
                string query;
                int countRecords = 0;
                query = "SELECT count(idusuario) from usuario where IdPersona=" + hfIdPersona.Value;
                cn.IniciarConexion();
                cn.RecibeQuery(query);
                if (cn.reg.Read())
                {
                    countRecords = cn.reg.GetInt32(0);
                }
                cn.reg.Close();
                if (countRecords > 0)
                {
                    //Una persona no puede tener dos usuarios
                    lblNotificacion.Text = "ERROR! Esta persona ya tiene un usuario asociado";
                    lblNotificacion.CssClass = "alert alert-danger";
                    lblNotificacion.Visible = true;
                    cn.CerrarConexion();
                }
                else
                {
                    query = "SELECT count(IdPersona) from usuario where NombreUsuario like '" + usuario + "'";
                    cn.RecibeQuery(query);
                    if (cn.reg.Read())
                    {
                        countRecords = cn.reg.GetInt32(0);
                    }
                    // si hay un usuario con el mismo username no podrá crearse el usuario
                    if (countRecords > 0)
                    {
                        lblNotificacion.Text = "ERROR! Este Usuario ya existe";
                        lblNotificacion.CssClass = "alert alert-danger";
                        lblNotificacion.Visible = true;
                        cn.CerrarConexion();
                    }
                    else
                    {
                        cn.reg.Close();
                        query = "insert into usuario(IdPersona,NombreUsuario,ContrasenaUsuario,Estado) values("+hfIdPersona.Value+
                            ",'" + usuario + "',SHA1('" + password + "'),1)";
                        cn.EnviarQuery(query);
                        cn.CerrarConexion();
                        lblNotificacion.CssClass = "alert alert-success";
                        lblNotificacion.Text = "ÉXITO! Usuario agregado";
                        lblNotificacion.Visible = true;
                    }
                }
            }
        }

        private void cargarUsuario(string idPersona)
        {
            //Función para cargar los datos de la persona
            string query = "SELECT concat(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido)" +
                " as nombre, Email1 from persona where idPersona=" + idPersona;
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            if (cn.reg.Read())
            {
                lblNombre.Text = cn.reg.GetString("nombre");
                lblEmail.Text = cn.reg.GetString("Email1");
            }
            cn.CerrarConexion();
        }
    }
}
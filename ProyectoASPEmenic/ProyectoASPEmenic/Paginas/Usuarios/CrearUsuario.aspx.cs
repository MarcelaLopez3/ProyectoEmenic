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
                query = "SELECT count(IdPersona) from usuario where NombreUsuario like '" + usuario + "'";
                cn.IniciarConexion();
                cn.RecibeQuery(query);
                while (cn.reg.Read())
                {
                    countRecords = cn.reg.GetInt32(0);
                }
                cn.CerrarConexion();
                // si hay más de un usuario con el mismo username no podrá crearse el usuario
                if (countRecords > 0)
                {
                    lblNotificacion.Text = "ERROR! Este Usuario ya existe";
                    lblNotificacion.Visible = true;
                }
                else
                {
                    query = "insert into usuario(IdPersona,NombreUsuario,ContrasenaUsuario) values(3,'" + usuario + "',SHA1('" + password + "'))";
                    cn.IniciarConexion();
                    cn.EnviarQuery(query);
                    cn.CerrarConexion();
                    lblNotificacion.CssClass = "alert alert-success";
                    lblNotificacion.Text = "ÉXITO! Usuario agregado";
                    lblNotificacion.Visible = true;
                }
            }
        }
    }
}
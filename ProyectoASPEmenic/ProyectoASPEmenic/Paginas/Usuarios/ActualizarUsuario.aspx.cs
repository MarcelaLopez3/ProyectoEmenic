using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoASPEmenic.Paginas.Usuarios
{
    public partial class ActualizarUsuario : System.Web.UI.Page
    {
        Conexion cn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Seleccione una persona.')", true);
                btnGuardarUsuario.Visible = false;
            }
            else
            {
                hfIdPersona.Value = Request.QueryString["id"].ToString();
                cargarUsuario(hfIdPersona.Value);
            }
        }

        private void cargarUsuario(string idPersona)
        {
            //Función para cargar los datos de la persona
            string query = "SELECT concat(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido)" +
                " as nombre, Email1,NombreUsuario,Estado from persona inner join usuario on persona.idpersona= usuario.idpersona"+
                " where usuario.idPersona=" + idPersona;
            cn.IniciarConexion();
            cn.RecibeQuery(query);
            if (cn.reg.Read())
            {
                lblNombre.Text = cn.reg.GetString("nombre");
                lblEmail.Text = cn.reg.GetString("Email1");
                lblUsuario.Text = cn.reg.GetString("NombreUsuario");
                hfIdEstado.Value = cn.reg.GetBoolean("Estado").ToString();
            }
            cn.CerrarConexion();
            if (Boolean.Parse(hfIdEstado.Value) == true)
            {
                btnAltaUsuario.Text = "Dar de Baja";
                lblEstado.Text = "Activo";
            }
            else
            {
                btnAltaUsuario.Text = "Activar Usuario";
                lblEstado.Text = "Inactivo";
            }
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtContra.Text) || String.IsNullOrWhiteSpace(txtConfirmCon.Text))
            { 
}
            if (String.Compare(txtContra.Text, txtConfirmCon.Text) != 0)
            {
                lblNotificacion.Text = "ERROR! Las contraseñas no coinciden";
                lblNotificacion.CssClass = "alert alert-danger";
                lblNotificacion.Visible = true;
            }
            else
            {
                string query = "update usuario set ContrasenaUsuario=sha1('" + txtContra.Text
                    + "') where idpersona=" + hfIdPersona.Value;
                cn.IniciarConexion();
                cn.EnviarQuery(query);
                cn.CerrarConexion();
                lblNotificacion.Text = "ÉXITO! Contraseña actualizada";
                lblNotificacion.CssClass = "alert alert-success";
                lblNotificacion.Visible = true;
            }
        }

        protected void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            bool estado = !Boolean.Parse(hfIdEstado.Value);
            string query = "update usuario set estado=" + estado + " where idpersona=" + hfIdPersona.Value;
            lblNotificacion.Text = query;
            cn.IniciarConexion();
            cn.EnviarQuery(query);
            cn.CerrarConexion();
            if (!estado)
            {
                lblNotificacion.Text = "ADVERTENCIA! Usuario dado de baja";
                lblNotificacion.CssClass = "alert alert-warning";
                lblNotificacion.Visible = true;
            }
            else
            {
                lblNotificacion.Text = "ÉXITO! Usuario activo";
                lblNotificacion.CssClass = "alert alert-success";
                lblNotificacion.Visible = true;
            }
            cargarUsuario(hfIdPersona.Value);
        }
    }
}
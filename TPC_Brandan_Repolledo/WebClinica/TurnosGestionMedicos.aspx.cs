using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebClinica
{
    public partial class TurnosGestionMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rol = Session["Rol"].ToString();

            if (rol == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }

            string var = Session["Turno"].ToString();
            idTextTurno.Text = var;

            NegocioTurno datos = new NegocioTurno();
            List<DetalleTurno> turno = datos.DetalleTurno(long.Parse(var));

            foreach (var item in turno)
            {
                idTextApellido.Text = item.Apellido;
                idTextNombre.Text = item.Nombre;
                idTextMotivo.Text = item.Motivo;
            }
        }

        protected void Click_AceptarGestionMedico(object sender, EventArgs e)
        {
            bool val = ValidaGestion(); 
            try
            {
                if (val)
                {
                    Turno gestion = new Turno();
                    gestion.IdTurno = long.Parse(idTextTurno.Text);
                    gestion.Motivo = TxtMotivoTurno.Text;
                    gestion.Estado = ddlEstadoTurno.SelectedItem.Text;

                    NegocioTurno update = new NegocioTurno();
                    update.GestionarTurno(gestion);
                    Response.Redirect("TurnosLista.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public bool ValidaGestion()
        {
            bool valido = true;  
            if (TxtMotivoTurno.Text == "" || idTextMotivo.Text == "REQUERIDO")
            {
                TxtMotivoTurno.ForeColor = System.Drawing.Color.Red;
                TxtMotivoTurno.Text = "REQUERIDO";
                valido = false;
            }

            if (Convert.ToInt32(ddlEstadoTurno.SelectedIndex) == 0)
            {
                ddlEstadoTurno.ForeColor = System.Drawing.Color.Red; 
                valido = false;
            } 
            return valido;
        }
    }
}
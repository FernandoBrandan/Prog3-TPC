using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClinica
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_btnMedicosAlta(object sender, EventArgs e)
        {
            Response.Redirect("MedicosAlta.aspx");
        }

        protected void Click_btnPacientesAlta(object sender, EventArgs e)
        {
            Response.Redirect("PacientesAlta.aspx");
        }

        protected void Click_btnUsuariosAlta(object sender, EventArgs e)
        {
            Response.Redirect("UsuariosAlta.aspx");
        }

        protected void Click_btnTurnosLista(object sender, EventArgs e)
        {
            Response.Redirect("TurnosLista.aspx");
        }

        protected void Click_btnEspecialidadesAlta(object sender, EventArgs e)
        {
            Response.Redirect("EspecialidadesAlta.aspx");
        }
        protected void Click_btnContactos(object sender, EventArgs e)
        {
            Response.Redirect("Contactos.aspx");
        }

        protected void Click_btnInformacion(object sender, EventArgs e)
        {
            Response.Redirect("Informacion.aspx");
        }

    }
}
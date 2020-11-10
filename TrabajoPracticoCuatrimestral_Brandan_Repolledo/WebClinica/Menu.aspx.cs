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

        protected void Click_btnUsuarios(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }

        protected void Click_btnTurnos(object sender, EventArgs e)
        {
            Response.Redirect("Turnos.aspx");
        }

        protected void Click_btnEspecialidades(object sender, EventArgs e)
        {
            Response.Redirect("Especialidades.aspx");
        }
    }
}
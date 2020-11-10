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

        protected void Click_btnMedicos(object sender, EventArgs e)
        {
            Response.Redirect("Medicos.aspx");
        }

<<<<<<< HEAD
        protected void Click_btnPacientesAlta(object sender, EventArgs e)
=======
        protected void Click_btnPacientes(object sender, EventArgs e)
>>>>>>> 509ee3ba8cced2c8ec465f11389975e25959644a
        {
            Response.Redirect("Pacientes.aspx");
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
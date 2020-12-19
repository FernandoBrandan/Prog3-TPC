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
    public partial class PacientesListar : System.Web.UI.Page
    {

        public List<Paciente> ListadoOriginal { get; set; }
        public List<Paciente> ListaFiltrada { get; set; }
        public List<Paciente> ListaVacia { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                NegocioPaciente CargarBuscar = new NegocioPaciente();
                ListadoOriginal = CargarBuscar.ListaPaciente();
                // gvBusquedaPaciente.DataSource = ListadoOriginal;
                // gvBusquedaPaciente.DataBind();
            }

        }
        protected void Click_BuscarBajaPaciente(object sender, EventArgs e)
        {
            

        }

        protected void Click_BorrarPacienteBaja(object sender, EventArgs e)
        {


               
            //LimpiarTabla();
        }


    }
}
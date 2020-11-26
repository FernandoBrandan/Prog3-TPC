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
    public partial class PacientesModifica : System.Web.UI.Page
    {
        public List<Paciente> ListadoOriginal { get; set; }
        public List<Paciente> ListaFiltrada { get; set; }
        public List<Paciente> ListaVacia { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Click_BuscarPaciente(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                NegocioPaciente Buscar = new NegocioPaciente();
                ListadoOriginal = Buscar.ListaPaciente();
                try
                {
                    if (TextBuscarPaciente.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarPaciente.Text) || TextBuscarPaciente.LegajoUsuario.ToLower().Contains(TextBuscarPaciente.Text.ToLower()) || Y.Nombre.ToLower().Contains(TextBuscarPaciente.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarPaciente.Text.ToLower()));
                    }
                    gvBusquedaPaciente.DataSource = ListaFiltrada;
                    gvBusquedaPaciente.DataSource = ListaFiltrada;
                    gvBusquedaPaciente.DataBind();

                }



                catch (Exception ex)
                {

                    
                    throw ex;
                }
            }
        }

    }
}
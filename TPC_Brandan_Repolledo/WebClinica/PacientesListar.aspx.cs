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
        //public List <Paciente> ListaTotal { get; set; }
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
                ListadoOriginal = CargarBuscar.ListaPaciente2();
                gvBusquedaPaciente.DataSource = ListadoOriginal;
                gvBusquedaPaciente.DataBind();
            }

        }
        protected void Click_BusquedaPaciente(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                TextBuscarPaciente.Text = "";
                NegocioPaciente Buscar = new NegocioPaciente();
                ListadoOriginal = Buscar.ListaPaciente2();

                try
                {
                    if (TextBuscarPaciente.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarPaciente.Text) || Y.Nombre.ToLower().Contains(TextBuscarPaciente.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarPaciente.Text.ToLower()));
                    }
                    gvBusquedaPaciente.DataSource = ListaFiltrada;
                    gvBusquedaPaciente.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        protected void ListaPaciente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaPaciente.Rows[index].Cells[1].Text;
            TextRecuperarPaciente.Text = gvBusquedaPaciente.Rows[index].Cells[1].Text;
        }
        protected void Click_AceptarRecuperarPaciente(object sender, EventArgs e)
        {
            Paciente recuperarPaciente = new Paciente();
            recuperarPaciente.DNI = long.Parse(TextRecuperarPaciente.Text);
            NegocioPaciente Borrar = new NegocioPaciente();
            Borrar.RecuperarPaciente(recuperarPaciente);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Se Recuperó al paciente: " + recuperarPaciente.DNI + "')</script>");
            LimpiarTabla();
        }



        private void LimpiarTabla()
        {
            TextBuscarPaciente.Text = "";
            TextRecuperarPaciente.Text = "";
            gvBusquedaPaciente.DataSource = ListaVacia;
            gvBusquedaPaciente.DataBind();
        }
        protected void Click_LimpiarBusqueda(object sender, EventArgs e)
        {
            LimpiarTabla();
        }



    }
}
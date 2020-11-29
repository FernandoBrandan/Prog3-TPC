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
                        
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarPaciente.Text) || Y.Nombre.ToLower().Contains(TextBuscarPaciente.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarPaciente.Text.ToLower()));
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


        protected void Click_BorrarListadoPaciente(object sender, EventArgs e)
        {
      

             TextBuscarPaciente.Text = "";
             gvBusquedaPaciente.DataSource = ListaVacia;
             gvBusquedaPaciente.DataBind();
        }


        protected void BusquedaPaciente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaPaciente.Rows[index].Cells[1].Text;
            TextModDNI.Text = gvBusquedaPaciente.Rows[index].Cells[2].Text;
            TextModNombre.Text = gvBusquedaPaciente.Rows[index].Cells[3].Text;
            TextModApellido.Text = gvBusquedaPaciente.Rows[index].Cells[4].Text;
            TextModDomicilio.Text = gvBusquedaPaciente.Rows[index].Cells[5].Text;
            TextModFechaNacimiento.Text = gvBusquedaPaciente.Rows[index].Cells[6].Text;

        }

        protected void Click_AceptarModiPaciente(object sender, EventArgs e)
        {
            NegocioPaciente Modificar = new NegocioPaciente();
            Paciente PacienteMod = new Paciente();

            try
            {

                PacienteMod.DNI = Convert.ToInt64(TextModDNI.Text);
                PacienteMod.Nombre = TextModNombre.Text;
                PacienteMod.Apellido = TextModApellido.Text;
                PacienteMod.Domicilio = TextModDomicilio.Text;
                PacienteMod.FechaNacimiento = DateTime.Parse(TextModFechaNacimiento.Text);

                Modificar.ModificarPaciente(PacienteMod);
                Response.Write("<script LANGUAGE='JavaScript' >alert('Se ha modificado al paciente correctamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('A ocurrido un error intente nuevamente')</script>");
                throw ex;
            }
        }

        public virtual int CellSpacing { get; set; } // Le da espaciado a las celdas de grilla

    }

}

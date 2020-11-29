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
    public partial class PacientesBaja : System.Web.UI.Page
    {
        public List<Paciente> ListadoOriginal { get; set; }
        public List<Paciente> ListaFiltrada { get; set; }
        public List<Paciente> ListaVacia { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       /* protected void BusquedaPaciente_RowCommand(object sender, GridViewCommandEventArgs e)
         {
             int index = Convert.ToInt32(e.CommandArgument);
             string Legajo = gvBusquedaPaciente.Rows[index].Cells[1].Text;
             TextElimDNI.Text = gvBusquedaPaciente.Rows[index].Cells[2].Text;
             TextElimNombre.Text = gvBusquedaPaciente.Rows[index].Cells[3].Text;
             TextElimApellido.Text = gvBusquedaPaciente.Rows[index].Cells[4].Text;
             TextElimDomicilio.Text = gvBusquedaPaciente.Rows[index].Cells[5].Text;
             TextElimFechaNacimiento.Text = gvBusquedaPaciente.Rows[index].Cells[6].Text;

         }*/

        protected void Click_BuscarPacienteB(object sender, EventArgs e)
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


        protected void Click_BorrarPacienteB(object sender, EventArgs e)
        {
            NegocioPaciente Eliminar = new NegocioPaciente();
            Paciente pacienteElim = new Paciente();
            try
            {

                pacienteElim.DNI = Convert.ToInt64(TextBuscarPaciente.Text);
                Eliminar.EliminarPaciente(pacienteElim);
                Response.Write("<script LANGUAGE='JavaScript' >alert('Se ha borrado al paciente')</script>");

            }
            catch (Exception ex)
            {

                throw ex;
            }

            /* TextBuscarPaciente.Text = "";
             gvBusquedaPaciente.DataSource = ListaVacia;
             gvBusquedaPaciente.DataBind();*/
        }



        protected void Click_BorrarListadoPaciente(object sender, EventArgs e)
        {
            NegocioPaciente Eliminar = new NegocioPaciente();
            Paciente pacienteElim = new Paciente();
            try
            {
                Eliminar.EliminarPaciente(pacienteElim);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            /* TextBuscarPaciente.Text = "";
             gvBusquedaPaciente.DataSource = ListaVacia;
             gvBusquedaPaciente.DataBind();*/
        }


        public virtual int CellSpacing { get; set; } // Le da espaciado a las celdas de grilla
        public void limpiarTabla( )
        {
            TextBuscarPaciente.Text = "";
            gvBusquedaPaciente.DataSource = ListaVacia;
            gvBusquedaPaciente.DataBind();
        }
    }
}
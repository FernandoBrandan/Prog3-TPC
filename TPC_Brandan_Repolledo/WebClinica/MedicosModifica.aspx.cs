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
    public partial class MedicosModifica : System.Web.UI.Page
    {
        public List<Medico> ListadoOriginal { get; set; }
        public List<Medico> ListaFiltrada { get; set; }
        public List<Medico> ListaVacia { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_BuscarMedico(object sender, EventArgs e)
        {
            NegocioMedico Buscar = new NegocioMedico();
            ListadoOriginal = Buscar.ListaMedicos();

            try
            {
                if (TextBuscar.Text == "")
                {
                    ListaFiltrada = ListadoOriginal;
                }
                else
                {
                    ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscar.Text) || Y.LegajoMedico.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Nombre.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscar.Text.ToLower()));
                }
                gvBusqueda.DataSource = ListaFiltrada;
                gvBusqueda.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Click_BorrarListado(object sender, EventArgs e)
        {
            TextBuscar.Text = "";
            gvBusqueda.DataSource = ListaVacia;
            gvBusqueda.DataBind();
        }

        protected void BusquedaMedico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusqueda.Rows[index].Cells[1].Text;
            TextModDNI.Text = gvBusqueda.Rows[index].Cells[2].Text;
            TextModNombre.Text = gvBusqueda.Rows[index].Cells[3].Text;
            TextModApellido.Text = gvBusqueda.Rows[index].Cells[4].Text;
            TextModDomicilio.Text = gvBusqueda.Rows[index].Cells[5].Text;
            TextModFechaNacimiento.Text = gvBusqueda.Rows[index].Cells[6].Text;
        }

        protected void Click_AceptarModiMedico(object sender, EventArgs e)
        {
            NegocioMedico Modificar = new NegocioMedico();
            Medico MedicoMod = new Medico();

            try
            {

                MedicoMod.DNI = Convert.ToInt64(TextModDNI.Text);
                MedicoMod.Nombre = TextModMedicoNombre.Text;
                MedicoMod.Apellido = TextModMedicoApellido.Text;
                MedicoMod.Domicilio = TextModMedicoDomicilio.Text;
                MedicoMod.FechaNacimiento = DateTime.Parse(TextModMedicoFechaNacimiento.Text);

                Modificar.ModificarMedico(MedicoMod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
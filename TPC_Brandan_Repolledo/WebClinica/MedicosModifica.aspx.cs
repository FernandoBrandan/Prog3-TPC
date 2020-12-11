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
        public List<Especialidad> ListadoEspecialidades { get; set; }
        public List<Medico> ListadoOriginal { get; set; }
        public List<Medico> ListaFiltrada { get; set; }
        public List<Medico> ListaVacia { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico")
            {
                Response.Redirect("Menu.aspx");
            }

            if (!IsPostBack)
            {
                NegocioEspecialidad Carga = new NegocioEspecialidad();
                ListadoEspecialidades = Carga.ListaEspecialidades();
                ddlModMedico.DataSource = ListadoEspecialidades;
                ddlModMedico.DataTextField = "Nombre";
                ddlModMedico.DataValueField = "IdEspecialidad";
                ddlModMedico.DataBind();
                ddlModMedico.Items.Insert(0, "Seleccione");
            }
        }

        protected void Click_BuscarMedico(object sender, EventArgs e)
        {
            NegocioMedico Buscar = new NegocioMedico();
            ListadoOriginal = Buscar.ListaMedicos();

            try
            {
                if (TextMedicoBuscar.Text == "")
                {
                    ListaFiltrada = ListadoOriginal;
                }
                else
                {
                    ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextMedicoBuscar.Text) || Y.LegajoMedico.ToLower().Contains(TextMedicoBuscar.Text.ToLower()) || Y.Nombre.ToLower().Contains(TextMedicoBuscar.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextMedicoBuscar.Text.ToLower()));
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
            TextMedicoBuscar.Text = "";
            gvBusqueda.DataSource = ListaVacia;
            gvBusqueda.DataBind();
        }

        protected void BusquedaMedico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusqueda.Rows[index].Cells[1].Text;
            TextModMedicoDNI.Text = gvBusqueda.Rows[index].Cells[2].Text;
            TextModMedicoNombre.Text = gvBusqueda.Rows[index].Cells[3].Text;
            TextModMedicoApellido.Text = gvBusqueda.Rows[index].Cells[4].Text;
            TextModMedicoDomicilio.Text = gvBusqueda.Rows[index].Cells[5].Text;
            TextModMedicoFechaNacimiento.Text = gvBusqueda.Rows[index].Cells[6].Text;
        }

        protected void Click_AceptarModiMedico(object sender, EventArgs e)
        {
            NegocioMedico Modificar = new NegocioMedico();
            Medico MedicoMod = new Medico();

            try
            {
                MedicoMod.DNI = Convert.ToInt64(TextModMedicoDNI.Text);
                MedicoMod.Nombre = TextModMedicoNombre.Text;
                MedicoMod.Apellido = TextModMedicoApellido.Text;
                MedicoMod.Domicilio = TextModMedicoDomicilio.Text;
                MedicoMod.FechaNacimiento = DateTime.Parse(TextModMedicoFechaNacimiento.Text);

                MedicoMod.Especialidad = new Especialidad();

                MedicoMod.Especialidad.IdEspecialidad = long.Parse(ddlModMedico.SelectedItem.Value);
                Modificar.ModificarMedicoPersona(MedicoMod);
                Modificar.ModificarMedico(MedicoMod);
                if (Modificar.ModificarMedico(MedicoMod) || Modificar.ModificarMedicoPersona(MedicoMod))
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se ha actualizado correctamente los datos del médico')</script>");

                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Error al modificar')</script>");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
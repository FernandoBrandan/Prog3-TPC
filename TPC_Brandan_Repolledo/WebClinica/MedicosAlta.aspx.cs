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
    public partial class MedicosAlta : System.Web.UI.Page
    {

        public List<Especialidad> LisdadoEspecialidadess { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
                NegocioEspecialidad Carga1 = new NegocioEspecialidad();
                LisdadoEspecialidadess = Carga1.ListaEspecialidades();
                ddlAltaEspecialidad.DataSource = LisdadoEspecialidadess;
                ddlAltaEspecialidad.DataTextField = "Nombre";
                ddlAltaEspecialidad.DataValueField = "IdEspecialidad";
                ddlAltaEspecialidad.DataBind();
            }            
        }            

        public string CrearLegajo()
        {
            string Legajo;
            // Legajo = "Combinacion entre nombre apellido y dni";
            Legajo = "medic1ds23";              
            return Legajo;
        }

        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Medico nuevoMedico = new Medico();
            Especialidad seleccionaEsp = new Especialidad();
            NegocioMedico CargarMedico = new NegocioMedico();

            try
            {
                nuevaPersona.DNI = Convert.ToInt32(TextMedicoDNI.Text);
                nuevaPersona.Nombre = TextMedicoNombre.Text;
                nuevaPersona.Apellido = TextMedicoApellido.Text;
                nuevaPersona.Domicilio = TextMedicoDomicilio.Text;
                nuevaPersona.FechaNacimiento = DateTime.Parse(TextMedicoFechaNac.Text);
                if (RbGenero.SelectedItem.Value == "Male")
                {
                    nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                }
                else if (RbGenero.SelectedItem.Value == "Female")
                {
                    nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                }
                nuevaPersona.Estado = true;

                nuevoMedico.LegajoMedico = CrearLegajo();
                nuevoMedico.FechaIngreso = DateTime.Today.Date; 

                seleccionaEsp.IdEspecialidad = long.Parse(ddlAltaEspecialidad.SelectedItem.Value);

                CargarMedico.AgregarPersona(nuevaPersona);
                CargarMedico.AgregarMedico(nuevoMedico, nuevaPersona, seleccionaEsp);

                Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente el Medico')</script>");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
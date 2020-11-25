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
    public partial class PacientesAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public string crearLegajoPaciente(string Nombre, string Apellido)
        {
            string Legajo, dni, apellido, nombre;
            nombre = Nombre.Substring(0, 3);
            apellido = Apellido.Substring(0, 3);
            Legajo = nombre + apellido;
            return Legajo;
        }
                         
        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Paciente nuevoPaciente = new Paciente();
            NegocioPaciente CargaPacientes = new NegocioPaciente();

            try
            {
                nuevaPersona.DNI =  Convert.ToInt32(TextDNI.Text);
                nuevaPersona.Nombre = TextNombre.Text;
                nuevaPersona.Apellido = TextApellido.Text;
                nuevaPersona.Domicilio = TextDomicilio.Text;
                
                nuevaPersona.FechaNacimiento= DateTime.Parse(TextFechaNac.Text);

                if (RbGenero.SelectedItem.Value == "Male")
                {
                    nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                }
                else if (RbGenero.SelectedItem.Value == "Female")
                {
                    nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                }
                nuevaPersona.Estado = true;
                         
                nuevoPaciente.FechaInscripcion  = DateTime.Today.Date;
                nuevoPaciente.Email =TextEmail.Text;
                nuevoPaciente.CodigoPaciente = crearLegajoPaciente( nuevaPersona.Nombre, nuevaPersona.Apellido);

                CargaPacientes.AgregarPersona(nuevaPersona);
                CargaPacientes.AgregarPaciente(nuevoPaciente, nuevaPersona);

                Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente el Usuario')</script>");
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
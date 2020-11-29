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

        public string crearLegajoPaciente(long DNI,string Nombre, string Apellido)
        {
            string Legajo, dniString, apellido, nombre,dniActual;
            dniString= Convert.ToString(DNI);
            dniActual =dniString.Substring(0, 3);
            nombre = Nombre.Substring(0, 3);
            apellido = Apellido.Substring(0, 3);
            Legajo = nombre + apellido + dniActual;
            return Legajo;
        }
                         
        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Paciente nuevoPaciente = new Paciente();
            NegocioPaciente CargaPacientes = new NegocioPaciente();

            try
            {
                nuevaPersona.DNI =  Convert.ToInt32(TextAltaPacienteDNI.Text);
                nuevaPersona.Nombre = TextAltaPacienteNombre.Text;
                nuevaPersona.Apellido = TextAltaPacienteApellido.Text;
                nuevaPersona.Domicilio = TextAltaPacienteDomicilio.Text;
                
                nuevaPersona.FechaNacimiento= DateTime.Parse(TextAltaPacienteFechaNac.Text);

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
                nuevoPaciente.Email = TextAltaPacienteEmail.Text;
                nuevoPaciente.CodigoPaciente = crearLegajoPaciente( nuevaPersona.DNI, nuevaPersona.Nombre, nuevaPersona.Apellido);

                CargaPacientes.AgregarPersona(nuevaPersona);
                CargaPacientes.AgregarPaciente(nuevoPaciente, nuevaPersona);

                Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente al paciente ')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Le falta cargar algún dato ')</script>");
                throw ex;
            } 
        }
    }
}
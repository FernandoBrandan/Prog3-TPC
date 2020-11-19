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

        public string CrearLegajo()
        {
            string Legajo;
            // Legajo = "Combinacion entre nombre apellido y dni";
            Legajo = "NOMAP1";
            return Legajo;
        }
                         
        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Usuario nuevoUsuario = new Usuario();
            NegocioUsuario CargaUsuarios = new NegocioUsuario();

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
                         
                        nuevoUsuario.FechaIngreso = DateTime.Today.Date;
                        nuevoUsuario.LegajoUsuario = CrearLegajo();

                        CargaUsuarios.AgregarPersona(nuevaPersona);
                        CargaUsuarios.AgregarUsuario(nuevoUsuario, nuevaPersona);

                Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente el Usuario')</script>");
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
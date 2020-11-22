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
        protected void Page_Load(object sender, EventArgs e)
        {
        }
       

        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevoMedico = new Medico()


            try
            {
                nuevoMedico.DNI = Convert.ToInt32(TextDNI.Text);
                nuevoMedico.Nombre = TextNombre.Text;
                nuevoMedico.Apellido = TextApellido.Text;
                nuevoMedico.Domicilio = TextDomicilio.Text;
                nuevoMedico.FechaNacimiento = DateTime.Parse(TextFechaNac.Text);
                if (RbGenero.SelectedItem.Value == "Male")
                {
                    nuevoMedico.Genero = RbGenero.SelectedItem.Text;
                }
                else if (RbGenero.SelectedItem.Value == "Female")
                {
                    nuevoMedico.Genero = RbGenero.SelectedItem.Text;
                }
                nuevoMedico.Estado = true;

                nuevoMedico.FechaIngreso = DateTime.Today.Date;

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
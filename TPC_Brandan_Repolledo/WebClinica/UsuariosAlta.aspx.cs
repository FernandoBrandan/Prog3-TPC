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
    public partial class UsuariosAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string crearLegajoUsuario(long DNI, string Nombre, string Apellido)
        {
            string Legajo, dniString, apellido, nombre, dniActual;
            dniString = Convert.ToString(DNI);
            dniActual = dniString.Substring(0, 3);
            nombre = Nombre.Substring(0, 3);
            apellido = Apellido.Substring(0, 3);
            Legajo = nombre + apellido + dniActual;
            return Legajo;
        }

        protected void Click_AceptarAltaUsuario(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Usuario nuevoUsuario = new Usuario();
            NegocioUsuario CargaUsuarios = new NegocioUsuario();

            try
            {
                nuevaPersona.DNI = Convert.ToInt32(TextUsuarioDNI.Text);
                nuevaPersona.Nombre = TextUsuarioNombre.Text;
                nuevaPersona.Apellido = TextUsuarioApellido.Text;
                nuevaPersona.Domicilio = TextUsuarioDomicilio.Text;
                nuevaPersona.FechaNacimiento = DateTime.Parse(TextUsuarioFechaNac.Text);
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
                nuevoUsuario.LegajoUsuario = crearLegajoUsuario(nuevaPersona.DNI, nuevaPersona.Nombre, nuevaPersona.Apellido);

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
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
    public partial class EspecialidadesAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_AceptarAltaEspec(object sender, EventArgs e)
        {
            try
            {
                if (ValidarEspecialidad(TextEspecNombre.Text))
                {
                    Especialidad nuevaEsp = new Especialidad();
                    NegocioEspecialidad CargarEsp = new NegocioEspecialidad();

                    nuevaEsp.Nombre = TextEspecNombre.Text.ToUpper();
                    nuevaEsp.Descripcion = TextEspecDescripcion.Text;
                    CargarEsp.AgregarEspecialidad(nuevaEsp);
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente la especialidad')</script>");
                    Response.Redirect("EspecialidadesAlta.aspx");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('El nombre de la especialidad ya existe')</script>");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ValidarEspecialidad(string Nombre)
        {
            bool valido = true;
            NegocioEspecialidad valida = new NegocioEspecialidad();
            List<Especialidad> Listado = valida.ValidaEspecialidad();

            foreach (var item in Listado)
            {
                if (Nombre == item.Nombre)
                {
                    valido = false;
                }
            }
            return valido;
        }


    }
}
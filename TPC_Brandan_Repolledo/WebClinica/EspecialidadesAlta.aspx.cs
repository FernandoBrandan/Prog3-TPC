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
                Especialidad nuevaEsp = new Especialidad();
                NegocioEspecialidad CargarEsp = new NegocioEspecialidad();

                nuevaEsp.Nombre = TextEspecNombre.Text;
                nuevaEsp.Descripcion = TextEspecDescripcion.Text;

                CargarEsp.AgregarEspecialidad(nuevaEsp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
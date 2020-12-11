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
            string var = Session["Rol"].ToString();
            if(var == "Medico")
            {    
                Response.Redirect("Menu.aspx");
            }
        }   

        protected void Click_AceptarAltaEspec(object sender, EventArgs e)
        {
            Especialidad nuevaEsp = new Especialidad();
            NegocioEspecialidad CargarEsp = new NegocioEspecialidad();
            try
            {
                bool valido = ValidarEspecialidad(TextEspecNombre.Text.ToUpper());
                if(!valido)
                {
                    nuevaEsp.Nombre = TextEspecNombre.Text;
                    nuevaEsp.Descripcion = TextEspecDescripcion.Text;
                    nuevaEsp.Estado = true;
                    CargarEsp.AgregarEspecialidad(nuevaEsp);
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente la especialidad')</script>");
                    LimpiarTabla();
                    // Response.Redirect("EspecialidadesAlta.aspx");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('La especialidad ya existe, por favor intente nuevamente')</script>");
                    LimpiarTabla();
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
        public bool ValidarEspecialidad(string Nombre)
        {
            bool valido = false;
            NegocioEspecialidad valida = new NegocioEspecialidad();
            List<Especialidad> Listado = valida.ValidaEspecialidad();

            foreach (var item in Listado)
            {
                if (Nombre == item.Nombre)
                {
                    valido = true;
                }
            }
            return valido;
        }
        public void LimpiarTabla()
        {
            TextEspecNombre.Text = "";
            TextEspecDescripcion.Text = "";
            
        }

    }
}
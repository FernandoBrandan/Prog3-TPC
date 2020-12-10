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
    public partial class EspecialidadesModifica : System.Web.UI.Page
    {
        public List<Especialidad> ListadoEspecialidades { get; set; }
        public List<Especialidad> Comparacion { get; set; }
        long IdSeleccionado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioEspecialidad Carga = new NegocioEspecialidad();
                ListadoEspecialidades = Carga.ListaEspecialidades();
                ddlModEspecialidad.DataSource = ListadoEspecialidades;
                ddlModEspecialidad.DataTextField = "Nombre";
                ddlModEspecialidad.DataValueField = "IdEspecialidad";
                ddlModEspecialidad.DataBind();
                ddlModEspecialidad.Items.Insert(0, "Seleccione");
            }
        }
        
        protected void Click_ElegirEspecialidad(object sender, EventArgs e)
        {
            NegocioEspecialidad Comparar = new NegocioEspecialidad();
            Especialidad Filtro = new Especialidad();
            Comparacion = Comparar.ListaEspecialidades();

            Filtro = new Especialidad();
            Filtro.IdEspecialidad = long.Parse(ddlModEspecialidad.SelectedItem.Value);

            foreach (var item in Comparacion)
            {
                 if (item.IdEspecialidad == Filtro.IdEspecialidad)
                 { 
                     IdSeleccionado = item.IdEspecialidad;
                     TextEspecNombre.Text = item.Nombre;
                     TextEspecDescripcion.Text = item.Descripcion;
                 }
            } 
        }
        
        protected void Click_AceptaModifEspecialidad(object sender, EventArgs e)
        {
            Especialidad nuevaEspecilidad = new Especialidad();
            NegocioEspecialidad Carga = new NegocioEspecialidad();
            nuevaEspecilidad.IdEspecialidad = long.Parse(ddlModEspecialidad.SelectedItem.Value);
            nuevaEspecilidad.Nombre = TextEspecNombre.Text;
            nuevaEspecilidad.Descripcion = TextEspecDescripcion.Text;
            if(Carga.ModificarEspecialidad(nuevaEspecilidad))
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Se modifico correctamente la especialidad')</script>");
                LimpiarTabla();

            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('No se ha podido modificar, por favor intente nuevamente')</script>");
                LimpiarTabla();
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
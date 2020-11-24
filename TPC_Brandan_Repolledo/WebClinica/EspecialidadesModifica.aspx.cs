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
        public Especialidad Filtro { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioEspecialidad Carga = new NegocioEspecialidad();
            ListadoEspecialidades = Carga.ListaEspecialidades(); 
            ddlModEspecialidad.DataSource = ListadoEspecialidades;
            ddlModEspecialidad.DataTextField = "Nombre";    
            ddlModEspecialidad.DataValueField = "IdEspecialidad";   
            ddlModEspecialidad.DataBind();
        }

        protected void Click_SelecionaEspecialidad(object sender, EventArgs e)  
        {
            Filtro.IdEspecialidad = long.Parse(ddlModEspecialidad.SelectedItem.Value);

            TextEspecNombre.Text = Filtro.Nombre;
            TextEspecDescripcion.Text = Filtro.Descripcion;
        }
    }
}
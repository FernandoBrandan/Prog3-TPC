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
    public partial class EspecialidadesBaja : System.Web.UI.Page
    {
        public List<Especialidad> ListadoEspecialidades { get; set; }
        public List<Especialidad> Comparacion { get; set; }
        long IdSeleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }

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
                    TextBorrarEspecialidad.Text = item.Nombre;
  
                }
            }
        }
        protected void Click_AceptaBorrarEspecialidad(object sender, EventArgs e)
        { 
            try
            {
                bool var = Valida();
                if(var)
                {
                    Especialidad nuevaEspecilidad = new Especialidad();
                    NegocioEspecialidad Carga = new NegocioEspecialidad();
                    nuevaEspecilidad.IdEspecialidad = long.Parse(ddlModEspecialidad.SelectedItem.Value);
                    nuevaEspecilidad.Nombre = TextBorrarEspecialidad.Text;
                    if (Carga.BajaEspecialidad(nuevaEspecilidad))
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('La especialidad se ha borrado correctamente')</script>");
                        LimpiarTabla();
                    } 
                }
            }
            catch (Exception ex)
            { 
                Response.Write("<script LANGUAGE='JavaScript' >alert('No se ha podido borrar la especialidad, por favor intente nuevamente')</script>");
                throw ex;
            }       
        }

        public void LimpiarTabla()
        {
            TextBorrarEspecialidad.Text = "";
        }

        public bool Valida()
        {
            bool valido = true;

            if (Convert.ToInt32(ddlModEspecialidad.SelectedIndex) == 0)
            {
                ddlModEspecialidad.ForeColor = System.Drawing.Color.Red;
                ddlModEspecialidad.Items.Insert(0, "REQUERIDO");
                valido = false;
            }
             
            return valido;
        }
    }
}
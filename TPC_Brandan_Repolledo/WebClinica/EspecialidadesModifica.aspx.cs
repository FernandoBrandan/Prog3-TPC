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
            string var = Session["Rol"].ToString();
            if (var == "Medico")
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
                     TextEspecNombre.Text = item.Nombre;
                     TextEspecDescripcion.Text = item.Descripcion;
                 }
            } 
        }
        
        protected void Click_AceptaModifEspecialidad(object sender, EventArgs e)
        {
            bool var = Valida();
            if(var)
            {
                Especialidad nuevaEspecilidad = new Especialidad();
                NegocioEspecialidad Carga = new NegocioEspecialidad();
                nuevaEspecilidad.IdEspecialidad = long.Parse(ddlModEspecialidad.SelectedItem.Value);
                nuevaEspecilidad.Nombre = TextEspecNombre.Text;
                nuevaEspecilidad.Descripcion = TextEspecDescripcion.Text;
                if (Carga.ModificarEspecialidad(nuevaEspecilidad))
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

        public bool Valida()
        {
            bool valido = true;

            if (Convert.ToInt32(ddlModEspecialidad.SelectedIndex) == 0)
            { 
                ddlModEspecialidad.ForeColor = System.Drawing.Color.Red;
                ddlModEspecialidad.Items.Insert(0, "REQUERIDO");
                valido = false;
            }

            if (TextEspecNombre.Text == "" || TextEspecNombre.Text == "REQUERIDO")
            {
                TextEspecNombre.ForeColor = System.Drawing.Color.Red;
                TextEspecNombre.Text = "REQUERIDO";
                valido = false;
            }
            if (TextEspecDescripcion.Text == "" || TextEspecDescripcion.Text == "REQUERIDO")
            {
                TextEspecDescripcion.ForeColor = System.Drawing.Color.Red;
                TextEspecDescripcion.Text = "REQUERIDO";
                valido = false;
            }

            return valido;
        }

        protected void Click_CancelaModifEspecialidad(object sender, EventArgs e)
        {
            Response.Redirect("EspecialidadesModifica.aspx");

        }
    }
}
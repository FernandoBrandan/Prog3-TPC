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
    public partial class UsuariosModifica : System.Web.UI.Page
    {
        public List<Usuario> ListadoOriginal { get; set; }
        public List<Usuario> ListaFiltrada { get; set; }
        public List<Usuario> ListaVacia{ get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_BuscarUsuario(object sender, EventArgs e)
        {
             
            if (IsPostBack)
            {
                NegocioUsuario Buscar = new NegocioUsuario();
                ListadoOriginal = Buscar.ListarUsuarios();
                 
                gvBusqueda.DataSource = ListadoOriginal;
                gvBusqueda.DataBind();

                try
                {
                    if (TextBuscar.Text == "")
                    {
                        gvBusqueda.DataSource = ListadoOriginal;
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscar.Text) || Y.LegajoUsuario.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Nombre.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscar.Text.ToLower()));
                        gvBusqueda.DataSource = ListaFiltrada;
                    }
                    gvBusqueda.DataSource = ListaFiltrada;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void Click_BorrarListado(object sender, EventArgs e)
        {
            TextBuscar.Text = "";
            gvBusqueda.DataSource = ListaVacia;
            gvBusqueda.DataBind();
        }
    }
}
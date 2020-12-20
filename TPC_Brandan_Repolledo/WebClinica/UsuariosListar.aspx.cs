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
    public partial class UsuariosListar : System.Web.UI.Page
    {

        public List<Usuario> ListadoOriginal { get; set; }
        public List<Usuario> ListaFiltrada { get; set; }
        public List<Usuario> ListaVacia { get; set; }

        //public List <Paciente> ListaTotal { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                NegocioUsuario CargarBuscar = new NegocioUsuario();
                ListadoOriginal = CargarBuscar.ListaUsuarios2();
                gvBusquedaUsuario.DataSource = ListadoOriginal;
                gvBusquedaUsuario.DataBind();
            }

        }
        protected void Click_BusquedaUsuario(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                TextBuscarUsuario.Text = "";
                NegocioUsuario Buscar = new NegocioUsuario();
                ListadoOriginal = Buscar.ListaUsuarios2();

                try
                {
                    if (TextBuscarUsuario.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarUsuario.Text) || Y.Nombre.ToLower().Contains(TextBuscarUsuario.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarUsuario.Text.ToLower()));
                    }
                    gvBusquedaUsuario.DataSource = ListaFiltrada;
                    gvBusquedaUsuario.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        protected void ListaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaUsuario.Rows[index].Cells[2].Text;
            TextRecuperarUsuario.Text = gvBusquedaUsuario.Rows[index].Cells[2].Text;
        }
        protected void Click_AceptarRecuperarUsuario(object sender, EventArgs e)
        {
            Usuario recuperarUsuario = new Usuario();
            recuperarUsuario.DNI = long.Parse(TextRecuperarUsuario.Text);
            NegocioUsuario Borrar = new NegocioUsuario();
            Borrar.RecuperarUsuario(recuperarUsuario);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Se Recuperó al Usuario: " + recuperarUsuario.DNI + "')</script>");
            LimpiarTabla();
        }

        private void LimpiarTabla()
        {
            TextBuscarUsuario.Text = "";
            TextRecuperarUsuario.Text = "";
            gvBusquedaUsuario.DataSource = ListaVacia;
            gvBusquedaUsuario.DataBind();
        }
        protected void Click_LimpiarBusqueda(object sender, EventArgs e)
        {
            LimpiarTabla();
        }



    }
}
    
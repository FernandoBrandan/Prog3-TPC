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
                 
                try
                {
                    if (TextBuscar.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal; 
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscar.Text) || Y.LegajoUsuario.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Nombre.ToLower().Contains(TextBuscar.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscar.Text.ToLower()));
                    }
                    gvBusqueda.DataSource = ListaFiltrada;
                    gvBusqueda.DataBind();      
                    
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

        protected void BusquedaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusqueda.Rows[index].Cells[1].Text; 
            TextModDNI.Text = gvBusqueda.Rows[index].Cells[2].Text;
            TextModNombre.Text = gvBusqueda.Rows[index].Cells[3].Text;
            TextModApellido.Text = gvBusqueda.Rows[index].Cells[4].Text;
            TextModDomicilio.Text = gvBusqueda.Rows[index].Cells[5].Text;
            TextModFechaNacimiento.Text = gvBusqueda.Rows[index].Cells[6].Text;
        }

        protected void Click_AceptarModiUsuario(object sender, EventArgs e)
        {
            NegocioUsuario Modificar = new NegocioUsuario();
            Usuario UsuarioMod = new Usuario();

            try
            {

                UsuarioMod.DNI = Convert.ToInt64(TextModDNI.Text);
                UsuarioMod.Nombre = TextModNombre.Text;
                UsuarioMod.Apellido = TextModApellido.Text;
                UsuarioMod.Domicilio = TextModDomicilio.Text;
                UsuarioMod.FechaNacimiento = DateTime.Parse(TextModFechaNacimiento.Text);

                Modificar.ModificarUsuario(UsuarioMod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
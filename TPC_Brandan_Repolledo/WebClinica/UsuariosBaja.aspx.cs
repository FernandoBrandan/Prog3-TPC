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
    public partial class UsuariosBaja : System.Web.UI.Page
    {
        public List<Usuario> ListadoOriginal { get; set; }
        public List<Usuario> ListaFiltrada { get; set; }
        public List<Usuario> ListaVacia { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioUsuario CargarBuscar = new NegocioUsuario();
            ListadoOriginal = CargarBuscar.ListarUsuarios();
            gvBusqueda.DataSource = ListadoOriginal;
            gvBusqueda.DataBind();
        }

        protected void Click_BuscarBajaUsuario(object sender, EventArgs e)
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

        protected void BusquedaBajaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusqueda.Rows[index].Cells[1].Text;
            int DNI;
            DNI = 1;

            Response.Write("< script LANGUAGE = 'JavaScript' >  $('#confirm').click(function(){var bool= confirm('Seguro de eliminar el dato?'); if (bool) {alert('se elimino correctamente');}else{alert('cancelo la solicitud');}});</ script > ");

            BajaUsuario(DNI);

        }

        public void BajaUsuario(int DNI)
        {


        }
    }
}
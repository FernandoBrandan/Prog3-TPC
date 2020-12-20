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
    public partial class MedicosBaja : System.Web.UI.Page
    {
        public List<Medico> ListadoOriginal { get; set; }
        public List<Medico> ListaFiltrada { get; set; }
        public List<Medico> ListaVacia { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                NegocioMedico CargarBuscar = new NegocioMedico();
                ListadoOriginal = CargarBuscar.ListaMedicos();
                gvBusquedaMedico.DataSource = ListadoOriginal;
                gvBusquedaMedico.DataBind();
            }
        }
        protected void Click_BuscarBajaMedico(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                TextBorrarMedico.Text = "";
                NegocioMedico Buscar = new NegocioMedico();
                ListadoOriginal = Buscar.ListaMedicos();

                try
                {
                    if (TextBuscarMedico.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarMedico.Text) || Y.Nombre.ToLower().Contains(TextBuscarMedico.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarMedico.Text.ToLower()));
                    }
                    gvBusquedaMedico.DataSource = ListaFiltrada;
                    gvBusquedaMedico.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void BusquedaBajaMedico_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaMedico.Rows[index].Cells[1].Text;
            TextBorrarMedico.Text = gvBusquedaMedico.Rows[index].Cells[2].Text;

        }
        protected void Click_AceptarBorrarMedico(object sender, EventArgs e)
        {
            Medico bajaMedico = new Medico();
            bajaMedico.DNI = long.Parse(TextBorrarMedico.Text);
            NegocioMedico Borrar = new NegocioMedico();
            Borrar.BajaMedico(bajaMedico);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Se dio de baja al paciente: " + bajaMedico.DNI + "')</script>");
            LimpiarTabla();
        }
         

       public  void LimpiarTabla()
        {
            TextBorrarMedico.Text = "";
            TextBuscarMedico.Text = "";
            gvBusquedaMedico.DataSource = ListaVacia;
            gvBusquedaMedico.DataBind();
        }

        public virtual int CellSpacing { get; set; } // Le da espaciado a las celdas de grilla

        protected void Click_BorrarBusquedaMedico(object sender, EventArgs e)
        {
            LimpiarTabla();
        }
    }
}
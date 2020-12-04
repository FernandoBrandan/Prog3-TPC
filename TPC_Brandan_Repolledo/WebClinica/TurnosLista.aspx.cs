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
    public partial class TurnosLista : System.Web.UI.Page
    {
        public List<Turno> Listado { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioTurno ListarTurnos = new NegocioTurno();
                Listado = ListarTurnos.ListarTurnos(); 
                
                gvBusquedaTurnos.DataSource = Listado;
                gvBusquedaTurnos.DataBind();
            }
        }

        protected void ListadoTurnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string IdTurno = gvBusquedaTurnos.Rows[index].Cells[1].Text;
            Session["Turno"] = IdTurno;

            Response.Redirect("TurnosGestionMedicos.aspx");

        }
    }
}
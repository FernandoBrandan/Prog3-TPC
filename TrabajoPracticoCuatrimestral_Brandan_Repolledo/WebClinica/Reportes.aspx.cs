using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Dominio;
using Negocio;

namespace WebClinica
{
    public partial class Formulario_web3 : System.Web.UI.Page
    {
        public List<Persona> Listado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        { 
            try
            {
                NegocioUsuarios Listar = new NegocioUsuarios();
                Listado = Listar.ListarPersonas();
                gvReporte.DataSource = Listado;
                gvReporte.DataBind();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void gvReportes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}
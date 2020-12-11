using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace WebClinica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Click_IniciaSesion(object sender, EventArgs e)
        {                
            try
            {
                Session["USUARIO"] = txtUsuario.Text.ToUpper();
                Session["PASS"] = txtPassword.Text;
                bool valida = ValidaSesion();
                Response.Redirect("~/Menu.aspx");

                if (txtUsuario.Text != "" || txtPassword.Text != "")
                { 
                    if (valida)
                    { 
                        //buscar perfil
                        Response.Redirect("~/Menu.aspx");
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Usuario incorrecto')</script>");
                    }



                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        private bool ValidaSesion()
        {
            bool valido = false;
            string user = (string)(Session["USUARIO"]);
            string pass = (string)(Session["PASS"]);
            NegocioLogin Valida = new NegocioLogin();
            if (Valida.ValidarMedico(user, pass) == 1  )
            {
                valido = true;
            }

            if (  Valida.ValidarUsuario(user, pass) == 1)
            {
                valido = true;
            }
            return valido;
        }
    }
}
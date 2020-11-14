using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClinica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Click_IniciaSesion(object sender, EventArgs e)
        {
            /*
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;
            string userName = "Fer";
            string userPass = "1234";
            if (user.Equals(userName) && pass.Equals(userPass)
            {
                //Response.Redirect.MasterPageFile("");
            }*/

            Response.Redirect("~/Menu.aspx");
        }
    }
}
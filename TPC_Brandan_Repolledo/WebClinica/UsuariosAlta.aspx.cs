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
    public partial class UsuariosAlta : System.Web.UI.Page
    {
        public List<Perfil> ListaPerfiles { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }

            if (!IsPostBack)
            {
                NegocioLogin Carga = new NegocioLogin();
                ListaPerfiles = Carga.ListarPerfil();
                ddlUsuarioRol.DataSource = ListaPerfiles;
                ddlUsuarioRol.DataTextField = "Rol";
                ddlUsuarioRol.DataValueField = "IdPerfil";
                ddlUsuarioRol.DataBind();
                ddlUsuarioRol.Items.Insert(0, "Seleccione");
            }
        }

        public string crearLegajoUsuario(long DNI, string Nombre, string Apellido)
        {
            string Legajo, dniString, apellido, nombre, dniActual;
            dniString = Convert.ToString(DNI);
            dniActual = dniString.Substring(0, 3);
            nombre = Nombre.Substring(0, 3);
            apellido = Apellido.Substring(0, 3);
            Legajo = nombre + apellido + dniActual;
            return Legajo;
        }

        protected void Click_AceptarAltaUsuario(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Usuario nuevoUsuario = new Usuario();
            NegocioUsuario CargaUsuarios = new NegocioUsuario();

            try
            {
                bool var = Valida();
                if (var)
                {
                    nuevaPersona.DNI = Convert.ToInt32(TextUsuarioDNI.Text);
                    nuevaPersona.Nombre = TextUsuarioNombre.Text;
                    nuevaPersona.Apellido = TextUsuarioApellido.Text;
                    nuevaPersona.Domicilio = TextUsuarioDomicilio.Text;
                    nuevaPersona.FechaNacimiento = DateTime.Parse(TextUsuarioFechaNac.Text);
                    if (RbGenero.SelectedItem.Value == "Male")
                    {
                        nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                    }
                    else if (RbGenero.SelectedItem.Value == "Female")
                    {
                        nuevaPersona.Genero = RbGenero.SelectedItem.Text;
                    }
                    nuevaPersona.Estado = true;

                    nuevoUsuario.FechaIngreso = DateTime.Today.Date;
                    nuevoUsuario.LegajoUsuario = crearLegajoUsuario(nuevaPersona.DNI, nuevaPersona.Nombre, nuevaPersona.Apellido);

                    nuevoUsuario.Seguridad = new Seguridad();
                    nuevoUsuario.Seguridad.Contraseña = TxtPassUsuario.Text;
                    nuevoUsuario.Seguridad.UltimaConexion = DateTime.Today.Date;

                    nuevoUsuario.Perfil = new Perfil();
                    nuevoUsuario.Perfil.IdPerfil = long.Parse(ddlUsuarioRol.SelectedItem.Value);

                    CargaUsuarios.AgregarSeguridad(nuevoUsuario);
                    CargaUsuarios.AgregarPersona(nuevaPersona);
                    CargaUsuarios.AgregarUsuario(nuevoUsuario, nuevaPersona);

                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se cargo correctamente el Usuario')</script>");
                }             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Valida()
        {
            bool valido = true;

            if (Convert.ToInt32(ddlUsuarioRol.SelectedIndex) == 0)
            {
                ddlUsuarioRol.ForeColor = System.Drawing.Color.Red;
                ddlUsuarioRol.Items.Insert(0, "REQUERIDO");
                valido = false;
            } 
            return valido;
        }

        protected void Click_CancelarAltaUsuario(object sender, EventArgs e)
        {
            Response.Redirect("UsuariosAlta.aspx");

        }
    }
}
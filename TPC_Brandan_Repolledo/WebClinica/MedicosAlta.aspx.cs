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
    public partial class MedicosAlta : System.Web.UI.Page
    {
        public List<Perfil> ListaPerfiles { get; set; }

        public List<Especialidad> LisdadoEspecialidadess { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico")
            {
                Response.Redirect("Menu.aspx");
            }

            if (!IsPostBack)
            {
                NegocioEspecialidad Carga1 = new NegocioEspecialidad();
                LisdadoEspecialidadess = Carga1.ValidaEspecialidad(); // se cambia para que solo muestre las que no están borradas
                ddlAltaEspecialidad.DataSource = LisdadoEspecialidadess;
                ddlAltaEspecialidad.DataTextField = "Nombre";
                ddlAltaEspecialidad.DataValueField = "IdEspecialidad";
                ddlAltaEspecialidad.DataBind();
                ddlAltaEspecialidad.Items.Insert(0, "Seleccione");

                NegocioLogin CargaRol = new NegocioLogin();
                ListaPerfiles = CargaRol.ListarPerfil();
                ddlMedicoRol.DataSource = ListaPerfiles;
                ddlMedicoRol.DataTextField = "Rol";
                ddlMedicoRol.DataValueField = "IdPerfil";
                ddlMedicoRol.DataBind();
                ddlMedicoRol.Items.Insert(0, "Seleccione");
            }
        }

        public string crearLegajoMedico(long DNI, string Nombre, string Apellido)
        {
            string Legajo, dniString, apellido, nombre, dniActual;
            dniString = Convert.ToString(DNI);
            dniActual = dniString.Substring(0, 3);
            nombre = Nombre.Substring(0, 3);
            apellido = Apellido.Substring(0, 3);
            Legajo = nombre + apellido + dniActual;
            return Legajo;
        }

        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
             Persona nuevaPersona = new Persona();
             Especialidad seleccionaEsp = new Especialidad();
             Medico nuevoMedico = new Medico();
             NegocioMedico negocio = new NegocioMedico();

            try
            {
                //nuevaPersona.DNI = Convert.ToInt32(TextMedicoDNI.Text);

                // if (!ValidarPersona(nuevaPersona.DNI))
                //{

                //bool var = Valida();
                //if (var)
                //{
                    nuevoMedico.DNI =Convert.ToInt32(TextMedicoDNI.Text);
                //nuevoMedico.DNI = Convert.ToInt32(TextMedicoDNI.Text);
                    nuevoMedico.Nombre = TextMedicoNombre.Text;
                    nuevoMedico.Apellido = TextMedicoApellido.Text;

                    nuevoMedico.Domicilio = TextMedicoDomicilio.Text;
                    nuevoMedico.FechaNacimiento = DateTime.Parse(TextMedicoFechaNac.Text);
                        if (RbGenero.SelectedItem.Value == "Male")
                        {
                        nuevoMedico.Genero = RbGenero.SelectedItem.Text;
                        }
                        else if (RbGenero.SelectedItem.Value == "Female")
                        {
                        nuevoMedico.Genero = RbGenero.SelectedItem.Text;
                        }
                        nuevoMedico.Estado = true;
                       //nuevoMedico.Medico = new Medico();

                        nuevoMedico.LegajoMedico = crearLegajoMedico(nuevoMedico.DNI, nuevoMedico.Nombre, nuevoMedico.Apellido);
                        nuevoMedico.FechaIngreso = DateTime.Today.Date;
                        nuevoMedico.Seguridad = new Seguridad();
                        nuevoMedico.Seguridad.Contraseña = TxtPassMedico.Text;
                        nuevoMedico.Seguridad.UltimaConexion = DateTime.Today.Date;
                        nuevoMedico.Especialidad = new Especialidad();
                        nuevoMedico.Especialidad.IdEspecialidad = long.Parse(ddlAltaEspecialidad.SelectedItem.Value);
                        nuevoMedico.Perfil = new Perfil();
                        nuevoMedico.Perfil.IdPerfil = long.Parse(ddlMedicoRol.SelectedItem.Value);
                        negocio.AgregarMedico(nuevoMedico);
                        
                        /*CargarMedico.AgregarSeguridad(nuevoMedico);
                        CargarMedico.AgregarPersona(nuevaPersona);
                        CargarMedico.AgregarMedico(nuevoMedico, nuevaPersona, seleccionaEsp);*/
                       


                    Response.Write("<script LANGUAGE='JavaScript' >alert('Se ha cargado correctamente el Medico, Su Codigo de Legajo para  poder loguearse es: " + nuevoMedico.LegajoMedico + "')</script>");
                       // LimpiarTabla();
                   // }
                }//
               /* else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('DNI medico ya existente')</script>");
                }*/
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidarPersona(long DNI)
        {
            bool valido = false;

            NegocioPersona valida = new NegocioPersona();

            List<Persona> Listado = valida.ValidaDNI();

            foreach (var item in Listado)
            {
                if (DNI == item.DNI)
                {
                    valido = true;
                    return valido;
                }
            }
            return valido;
        }

        public bool Valida()
        {
            bool valido = true;

            if (Convert.ToInt32(ddlAltaEspecialidad.SelectedIndex) == 0)
            {
                ddlAltaEspecialidad.ForeColor = System.Drawing.Color.Red;
                ddlAltaEspecialidad.Items.Insert(0, "REQUERIDO");
                valido = false;
            }

            if (Convert.ToInt32(ddlMedicoRol.SelectedIndex) == 0)
            {
                ddlMedicoRol.ForeColor = System.Drawing.Color.Red;
                ddlMedicoRol.Items.Insert(0, "REQUERIDO");
                valido = false;
            }
            return valido;
        }

        protected void Click_CancelarAltaPaciente(object sender, EventArgs e)
        {
            Response.Redirect("MedicosAlta.aspx");
        }

        public void LimpiarTabla()
        {
            TextMedicoDNI.Text = "";
            TextMedicoNombre.Text = "";
            TextMedicoApellido.Text = "";
            TextMedicoDomicilio.Text = "";
            TextMedicoFechaNac.Text = "";

        }
    }
}
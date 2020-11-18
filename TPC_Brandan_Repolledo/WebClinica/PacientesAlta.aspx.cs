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
    public partial class PacientesAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* NegocioCategoria negocioCategoria = new NegocioCategoria();
             cbxCategoria.DataSource = negocioCategoria.ListarCategoria();
             NegocioMarca negocioMarca = new NegocioMarca();
             cbxMarca.DataSource = negocioMarca.ListarMarca();*/

            NegocioUsuario Genero = new NegocioUsuario();
            DDLGenero.DataSource = Genero.CargarGenero();


            try
            {
               /* cbxCategoria.ValueMember = "ID";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                cbxMarca.ValueMember = "ID";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.SelectedIndex = -1;


                DDLGenero.SelectedValue = "IdGenero";
                DDLGenero.MergeStyle*/

                bool articulo;
                if (Genero != null)
                {
                  /*  txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxCategoria.SelectedValue = articulo.Categoria.ID;
                    cbxMarca.SelectedValue = articulo.Marca.ID;
                    txtImagenURL.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString();*/
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string CrearLegajo()
        {
            string Legajo;
            Legajo = "Combinacion entre nombre apellido y dni";
            return Legajo;
        }

        protected void Click_AceptarAltaPaciente(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            Usuario nuevoUsuario = new Usuario();
            NegocioUsuario negocio = new NegocioUsuario();
            if(!IsPostBack)
            {            
                try
                {
                    if (nuevaPersona == null && nuevoUsuario == null)
                    {
                       // articulo = new Articulo();

                        nuevaPersona.DNI =  Convert.ToInt32(TextDNI.Text);
                        nuevaPersona.Nombre = TextNombre.Text;
                        nuevaPersona.Apellido = TextApellido.Text;
                        nuevaPersona.Domicilio = TextDomicilio.Text;
                        nuevaPersona.FechaNacimiento= Convert.ToDateTime(TextFechaNac);
                     /*   nuevaPersona.Genero = (Genero)DDLGenero.SelectedItem;*/
                        nuevaPersona.Estado = true;

                        nuevoUsuario.FechaIngreso = DateTime.Today.Date;
                        nuevoUsuario.LegajoUsuario = CrearLegajo();



                        if (nuevaPersona.Genero == null)
                        {
                          //  MessageBox.Show("Faltan elegir datos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Dispose();
                        }
                        else
                        {
                            if (nuevaPersona.Nombre == "" || nuevaPersona.Apellido == "" )
                            {
                               // MessageBox.Show("Faltan cargar datos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Dispose();
                            }
                            else
                            {
                               // negocio.Agregar(nuevo);
                                Dispose();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
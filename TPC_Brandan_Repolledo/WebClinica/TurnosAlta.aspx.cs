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
    public partial class TurnosAlta : System.Web.UI.Page
    {
        public List<Paciente> ListadoOriginal { get; set; }
        public List<Paciente> ListaFiltrada { get; set; }
        public List<Paciente> ListaVacia { get; set; }

        public List<Especialidad> CargaListadoEsp { get; set; }
        public List<Medico> CargaListadoMed { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            string var = Session["Rol"].ToString();
            if (var == "Medico")
            {
                Response.Redirect("Menu.aspx");
            }

            if (!IsPostBack)
            {
                NegocioEspecialidad ListaEspecialidad = new NegocioEspecialidad();
                CargaListadoEsp = ListaEspecialidad.ListaEspecialidades();
                ddlAltaTurnoEspecilidad.DataSource = CargaListadoEsp;
                ddlAltaTurnoEspecilidad.DataTextField = "Nombre";
                ddlAltaTurnoEspecilidad.DataValueField = "IdEspecialidad";
                ddlAltaTurnoEspecilidad.DataBind();
                ddlAltaTurnoEspecilidad.Items.Insert(0, "Seleccione");

                ddlAltaTurnoMedico.DataSource = CargaListadoMed;
                ddlAltaTurnoMedico.DataTextField = "Apellido";
                ddlAltaTurnoMedico.DataValueField = "LegajoMedico";
                ddlAltaTurnoMedico.DataBind();
                ddlAltaTurnoMedico.Items.Insert(0, "Seleccione");
            }
        }

        protected void Click_AceptarBuscaPacienteTurno(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                NegocioPaciente Buscar = new NegocioPaciente();
                ListadoOriginal = Buscar.ListaPaciente();
                try
                {
                    if (TextBusquedaPacienteTurno.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBusquedaPacienteTurno.Text) || Y.Nombre.ToLower().Contains(TextBusquedaPacienteTurno.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBusquedaPacienteTurno.Text.ToLower()));
                    }
                    gvBusquedaPaciente.DataSource = ListaFiltrada;
                    gvBusquedaPaciente.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void Click_BorrarBuscaPacienteTurno(object sender, EventArgs e)
        {
            TextBusquedaPacienteTurno.Text = "";
            gvBusquedaPaciente.DataSource = ListaVacia;
            gvBusquedaPaciente.DataBind();
        }


        protected void BusquedaPaciente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaPaciente.Rows[index].Cells[1].Text;
            TextBusquedaPacienteTurno.Text = gvBusquedaPaciente.Rows[index].Cells[1].Text;

            SeleccionaPaciente(TextBusquedaPacienteTurno.Text);
        }

        public void SeleccionaPaciente(string paciente)
        {
            LabelPacienteElegido.Text = paciente;
            TextBusquedaPacienteTurno.Text = "";
            gvBusquedaPaciente.DataSource = ListaVacia;
            gvBusquedaPaciente.DataBind();
        }

        protected void Click_SeleccionaFecha(object sender, EventArgs e)
        {
            TextFechaElegida.Text = Calendar1.SelectedDate.ToShortDateString();
            Click_ValidadFechas(sender, e);
        }

        protected void Click_SeleccionaEspecialidad(object sender, EventArgs e)
        {
            Especialidad Filtrado = new Especialidad();
            Filtrado.IdEspecialidad = long.Parse(ddlAltaTurnoEspecilidad.SelectedItem.Value);

            NegocioMedico Busca = new NegocioMedico();
            List<Medico> FiltroMedico = Busca.BuscaMedicos(Filtrado);

            ddlAltaTurnoMedico.DataSource = FiltroMedico;
            ddlAltaTurnoMedico.DataTextField = "Apellido";
            ddlAltaTurnoMedico.DataValueField = "LegajoMedico";
            ddlAltaTurnoMedico.DataBind();
            ddlAltaTurnoMedico.Items.Insert(0, "Seleccione");
        }

        protected void Click_ValidadFechas(object sender, EventArgs e)
        {
            if(!(TextFechaElegida.Text == "" || TextFechaElegida.Text == "REQUERIDO"))
            {
                DateTime FechaObtenida = DateTime.Parse(TextFechaElegida.Text);
                string VerificarFecha = FechaObtenida.ToShortDateString();

                NegocioDisponibilidad BuscarHorario = new NegocioDisponibilidad();
                List<Horario> FechasLibres = BuscarHorario.BuscaHorarios(FechaObtenida);

                ddlAltaTurnoHorario.DataSource = FechasLibres;
                ddlAltaTurnoHorario.DataTextField = "Descripcion";
                ddlAltaTurnoHorario.DataValueField = "IdHorario";
                ddlAltaTurnoHorario.DataBind();
                ddlAltaTurnoHorario.Items.Insert(0, "Seleccione");
            } 
        }

        protected void Click_AceptarAltaTurno(object sender, EventArgs e)
        {
            try
            {
        
                bool var = Validacion();
                if(var)
                {
                    Turno NuevoTurno = new Turno();
                    NuevoTurno.Paciente = new Paciente();
                    NuevoTurno.Paciente.CodigoPaciente = LabelPacienteElegido.Text;
                    NuevoTurno.Medico = new Medico();
                    NuevoTurno.Medico.LegajoMedico = ddlAltaTurnoMedico.SelectedItem.Value;

                    NuevoTurno.Motivo = TextMotivoTurno.Text;
                    NuevoTurno.Estado = "Pendiente";

                    Disponibilidad NuevoDispobilidad = new Disponibilidad();

                    NuevoDispobilidad.Fecha = Convert.ToDateTime(TextFechaElegida.Text);
                    NuevoDispobilidad.Horario = new Horario();
                    NuevoDispobilidad.Horario.IdHorario = long.Parse(ddlAltaTurnoHorario.SelectedItem.Value);
                    NuevoDispobilidad.Estado = "Activo";

                    NegocioDisponibilidad CargarDisp = new NegocioDisponibilidad();
                    NegocioTurno CargarTurno = new NegocioTurno();

                    CargarDisp.AgregarDisponibilidad(NuevoDispobilidad);
                    CargarTurno.AgregarTurno(NuevoTurno);
                    Response.Redirect("TurnosLista.aspx");
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public bool Validacion()
        {
            bool valido = true;

           /* if(LabelPacienteElegido.Text == "" || LabelPacienteElegido.Text == "REQUERIDO")
            {
                LabelPacienteElegido.ForeColor = System.Drawing.Color.Red;
                LabelPacienteElegido.Text = "REQUERIDO";
                valido = false;
            }

            if(TextFechaElegida.Text == "" || TextFechaElegida.Text == "REQUERIDO")
            {
                TextFechaElegida.ForeColor = System.Drawing.Color.Red;
                TextFechaElegida.Text = "REQUERIDO";
                valido = false;
            }

            if (Convert.ToInt32(ddlAltaTurnoMedico.SelectedIndex) == 0)
            {
                ddlAltaTurnoMedico.ForeColor = System.Drawing.Color.Red; 
                valido = false;
            }
            else
            {
                ddlAltaTurnoMedico.ForeColor = System.Drawing.Color.Black;
            }

            if (Convert.ToInt32(ddlAltaTurnoEspecilidad.SelectedIndex) == 0)
            {
                ddlAltaTurnoEspecilidad.ForeColor = System.Drawing.Color.Red; 
                valido = false;
            }
            else
            {
                ddlAltaTurnoEspecilidad.ForeColor = System.Drawing.Color.Black;
            }

            if (Convert.ToInt32(ddlAltaTurnoHorario.SelectedIndex) != 0)
            {
                selecionFecha.ForeColor = System.Drawing.Color.Red;
                ddlAltaTurnoHorario.ForeColor = System.Drawing.Color.Red;
                ddlAltaTurnoHorario.Items.Insert(0, "REQUERIDO");
                valido = false;
            }  */
            return valido;
        }

        protected void Click_CancelarAltaTurno(object sender, EventArgs e)
        {
            Response.Redirect("TurnosAlta.aspx");

        }
    }
}
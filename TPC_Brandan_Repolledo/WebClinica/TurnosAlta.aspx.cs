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
         
        public List<Disponibilidad> Comparacion { get; set; } 

        public List<Especialidad> CargaListadoEsp { get; set; }

        public List<Horario> FiltraHorarios { get; set; }
        public List<Horario> ListaHorarios { get; set; } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioEspecialidad ListaEspecialidad = new NegocioEspecialidad();
                CargaListadoEsp = ListaEspecialidad.ListaEspecialidades();
                ddlAltaTurnoEspecilidad.DataSource = CargaListadoEsp;
                ddlAltaTurnoEspecilidad.DataTextField = "Nombre";
                ddlAltaTurnoEspecilidad.DataValueField = "IdEspecialidad";
                ddlAltaTurnoEspecilidad.DataBind();
                ddlAltaTurnoEspecilidad.Items.Insert(0, "Seleccione");
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
            DateTime FechaObtenida= DateTime.Parse(TextFechaElegida.Text);
            NegocioDisponibilidad BuscarFecha = new NegocioDisponibilidad();
            NegocioDisponibilidad BuscarHorario = new NegocioDisponibilidad();
             
            string VerificarFecha = FechaObtenida.ToShortDateString(); 
            List<Disponibilidad> FechasLibres = BuscarFecha.BuscaFechas(VerificarFecha); 

            foreach (var item in FechasLibres)
            {
                 FiltraHorarios = BuscarHorario.BuscaHorarios(item.Horario.IdHorario);   
            } 

            ddlAltaTurnoHorario.DataSource = FiltraHorarios;
            ddlAltaTurnoHorario.DataTextField = "Descripcion";
            ddlAltaTurnoHorario.DataValueField = "IdHorario";
            ddlAltaTurnoHorario.DataBind();
            ddlAltaTurnoHorario.Items.Insert(0, "Seleccione");
        }

        protected void Click_AceptarAltaTurno(object sender, EventArgs e)
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


        }
    }
}
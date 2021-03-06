﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebClinica
{
    public partial class PacientesBaja : System.Web.UI.Page
    {
        public List<Paciente> ListadoOriginal { get; set; }
        public List<Paciente> ListaFiltrada { get; set; }
        public List<Paciente> ListaVacia { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Session["Rol"].ToString();
            if (var == "Medico" || var == "Usuario")
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                NegocioPaciente CargarBuscar = new NegocioPaciente();
                ListadoOriginal = CargarBuscar.ListaPaciente();
                gvBusquedaPaciente.DataSource = ListadoOriginal;
                gvBusquedaPaciente.DataBind();
            }
        }


        protected void Click_BuscarBajaPaciente(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                TextBorrarPaciente.Text = "";
                NegocioPaciente Buscar = new NegocioPaciente();
                ListadoOriginal = Buscar.ListaPaciente();
                
                try
                {
                    if (TextBuscarPaciente.Text == "")
                    {
                        ListaFiltrada = ListadoOriginal;
                    }
                    else
                    {
                        ListaFiltrada = ListadoOriginal.FindAll(Y => Convert.ToString(Y.DNI).Contains(TextBuscarPaciente.Text) || Y.Nombre.ToLower().Contains(TextBuscarPaciente.Text.ToLower()) || Y.Apellido.ToLower().Contains(TextBuscarPaciente.Text.ToLower()));
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

        protected void BusquedaBajaPaciente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Legajo = gvBusquedaPaciente.Rows[index].Cells[1].Text;
            TextBorrarPaciente.Text = gvBusquedaPaciente.Rows[index].Cells[2].Text;

        }
        protected void Click_AceptarBorrarPaciente(object sender, EventArgs e)
        {
            Paciente bajaPaciente = new Paciente();
            bajaPaciente.DNI = long.Parse(TextBorrarPaciente.Text);
            NegocioPaciente Borrar = new NegocioPaciente();
            Borrar.BajaPaciente(bajaPaciente);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Se dio de baja al paciente: " + bajaPaciente.DNI + "')</script>");
            LimpiarTabla();
        }

        private void LimpiarTabla()
        {
            TextBorrarPaciente.Text = "";
            TextBuscarPaciente.Text = "";
            gvBusquedaPaciente.DataSource = ListaVacia;
            gvBusquedaPaciente.DataBind();
        }

        public virtual int CellSpacing { get; set; } // Le da espaciado a las celdas de grilla

        protected void Click_BorrarPacienteBaja(object sender, EventArgs e)
        {
            LimpiarTabla();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioTurno
    {
        public List<Turno> ListarTurnos()
        {
            List<Turno> ListarTurnos = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select IdTurno, Disponibilidad, Medico, Paciente, Motivo, Estado from Turno");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();

                    aux.IdTurno = datos.Lector.GetInt64(0);

                    aux.Disponibilidad = new Disponibilidad();
                    aux.Disponibilidad.IdDisponibilidad = datos.Lector.GetInt64(1);

                    aux.Medico = new Medico();
                    aux.Medico.LegajoMedico = datos.Lector.GetString(2);

                    aux.Paciente = new Paciente();
                    aux.Paciente.CodigoPaciente = datos.Lector.GetString(3);

                    aux.Estado = datos.Lector.GetString(4);
                    aux.Motivo = datos.Lector.GetString(5);

                    ListarTurnos.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarTurnos;
        }

        public void AgregarTurno(Turno nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Turno (Disponibilidad, Medico, Paciente, Motivo, Estado) values ((select MAX(IdDisponibilidad) from Disponibilidad), @Medico, @Paciente, @Motivo, @Estado )");

            datos.AgregarParametro("@Medico", nuevo.Medico.LegajoMedico);
            datos.AgregarParametro("@Paciente", nuevo.Paciente.CodigoPaciente);
            datos.AgregarParametro("@Motivo", nuevo.Motivo);
            datos.AgregarParametro("@Estado", nuevo.Estado);
            datos.EjecutarConsulta();

        }
    }
}

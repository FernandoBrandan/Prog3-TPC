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
                datos.SetearQuery("");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();

                    aux.IdTurno = datos.Lector.GetInt32(0);

                    aux.Disponibilidad = new Disponibilidad();
                    aux.Disponibilidad.IdDisponibilidad = datos.Lector.GetInt32(1);

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
    }
}

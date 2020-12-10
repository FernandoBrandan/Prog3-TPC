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
                datos.SetearQuery("select IdTurno, d.FechaTurno, h.descripcion , Medico, Paciente, Motivo, t.Estado from Turno as t inner join Disponibilidad as d on d.IdDisponibilidad = t.Disponibilidad inner join Horario as h on h.IdHorario = d.Horario where t.Estado != 'Cancelado' and t.Estado != 'Sin Atender' and t.Estado != 'Atendido' and t.Estado != 'Reprogramado'");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();

                    aux.IdTurno = datos.Lector.GetInt64(0);

                    aux.Disponibilidad = new Disponibilidad();
                    aux.Disponibilidad.Fecha = datos.Lector.GetDateTime(1);

                    aux.Disponibilidad.Horario = new Horario();
                    aux.Disponibilidad.Horario.Descripcion = datos.Lector.GetString(2);

                    aux.Medico = new Medico();
                    aux.Medico.LegajoMedico = datos.Lector.GetString(3);

                    aux.Paciente = new Paciente();
                    aux.Paciente.CodigoPaciente = datos.Lector.GetString(4);

                    aux.Estado = datos.Lector.GetString(5);
                    aux.Motivo = datos.Lector.GetString(6);

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

        public List<DetalleTurno> DetalleTurno(long turno)
        {
            List<DetalleTurno> DetalleTurno = new List<DetalleTurno>();
            AccesoDatos datos = new AccesoDatos();
            try
            { 
                datos.AgregarParametro("@Turno", turno);
                datos.SetearQuery("select per.DNI, per.Apellido, per.Nombre, t.Motivo from Turno as t inner join Paciente as p on p.CodigoPaciente=t.Paciente inner join Persona as per on per.DNI=p.DNI where t.IdTurno = @Turno");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    DetalleTurno aux = new DetalleTurno();
                    aux.IdTurno = datos.Lector.GetInt64(0);
                    aux.Apellido = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Motivo = datos.Lector.GetString(3);
                    DetalleTurno.Add(aux);
                }
            }
            catch (Exception ex)
	        {
		        throw ex;
	        }
            return DetalleTurno;
        }

        public void GestionarTurno(Turno nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update turno set Motivo=@Motivo , Estado=@Estado  where idTurno=@IdTurno"); 
            datos.AgregarParametro("@IdTurno", nuevo.IdTurno);
            datos.AgregarParametro("@Motivo", nuevo.Motivo);
            datos.AgregarParametro("@Estado", nuevo.Estado);
            datos.EjecutarConsulta();
        }
    }
}

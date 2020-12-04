using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioDisponibilidad
    {
        public List<Disponibilidad> ListarFechas()
        {
            List<Disponibilidad> ListarFechas = new List<Disponibilidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select IdDisponibilidad, Horario, FechaTurno, Estado from Disponibilidad");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Disponibilidad aux = new Disponibilidad();

                    aux.IdDisponibilidad = datos.Lector.GetInt64(0);
                    aux.Horario = new Horario();
                    aux.Horario.IdHorario = datos.Lector.GetInt64(1);
                    aux.Fecha = datos.Lector.GetDateTime(2);
                    aux.Estado = datos.Lector.GetString(3);

                    ListarFechas.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarFechas;
        }

        public List<Disponibilidad> BuscaFechas(string Fecha)
        {
            List<Disponibilidad> BuscaFechas = new List<Disponibilidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select IdDisponibilidad, Horario, FechaTurno, Estado from Disponibilidad where FechaTurno = @Fecha");
                datos.AgregarParametro("@Fecha", Fecha);
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Disponibilidad aux = new Disponibilidad();

                    aux.IdDisponibilidad = datos.Lector.GetInt64(0);
                    aux.Horario = new Horario(); 
                    aux.Horario.IdHorario = datos.Lector.GetInt64(1);
                    aux.Fecha = datos.Lector.GetDateTime(2);
                    aux.Estado = datos.Lector.GetString(3);

                    BuscaFechas.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return BuscaFechas;
        }

        public List<Horario> ListarHorarios()
        {
            List<Horario> ListarHorarios = new List<Horario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select IdHorario, Descripcion from Horario");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Horario aux = new Horario();

                    aux.IdHorario = datos.Lector.GetInt64(0);
                    aux.Descripcion = datos.Lector.GetString(3);

                    ListarHorarios.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarHorarios;
        }

        public List<Horario> BuscaHorarios(long fecha)
        {
            List<Horario> ListarHorarios = new List<Horario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.AgregarParametro("@Horario", fecha);
                datos.SetearQuery("select IdHorario, Descripcion from Horario where IdHorario != @Horario");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Horario aux = new Horario();

                    aux.IdHorario = datos.Lector.GetInt64(0);
                    aux.Descripcion = datos.Lector.GetString(1);

                    ListarHorarios.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarHorarios;
        }

        public void AgregarDisponibilidad(Disponibilidad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Disponibilidad(Horario, FechaTurno, Estado) values (@Horario, @FechaTurno, @Estado)");
            datos.AgregarParametro("@Horario", nuevo.Horario.IdHorario);
            datos.AgregarParametro("@FechaTurno", nuevo.Fecha);
            datos.AgregarParametro("@Estado", nuevo.Estado);
            datos.EjecutarConsulta();

        }
    }
}

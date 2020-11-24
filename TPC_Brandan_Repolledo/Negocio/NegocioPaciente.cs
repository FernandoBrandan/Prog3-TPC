using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioPaciente
    {
        public List<Paciente> ListaPaciente()
        {
            List<Paciente> ListaPaciente = new List<Paciente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select ");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();

                    aux.CodigoPaciente = datos.Lector.GetString(0); 
                    // aux.Especialidad = datos.Lector.GetString(3);
                    // me parece que me falta un dato.
                    ListaPaciente.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaPaciente;
        }

        public void AgregarPersona(Persona nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Persona (DNI,Nombre,Apellido,Domicilio,FechaNacimiento,Genero,Estado) values (@DNI,@Nombre,@Apellido,@Domicilio,@FechaNacimiento,@Genero,@Estado);");
            datos.AgregarParametro("@DNI", nuevo.DNI);
            datos.AgregarParametro("@Nombre", nuevo.Nombre);
            datos.AgregarParametro("@Apellido", nuevo.Apellido);
            datos.AgregarParametro("@Domicilio", nuevo.Domicilio);
            datos.AgregarParametro("@FechaNacimiento", nuevo.FechaNacimiento);
            datos.AgregarParametro("@Genero", nuevo.Genero);
            datos.AgregarParametro("@Estado", nuevo.Estado);
            datos.EjecutarConsulta();

        }

        public void AgregarPaciente(Paciente nuevo, Persona Persona, Especialidad idEsp)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Medico (LegajoMedico,DNI,FechaIngreso,Especialidad) values (@LegajoMedico, @DNI, @FechaIngreso, @Especialidad);");
            datos.AgregarParametro("@LegajoMedico", nuevo.CodigoPaciente);

            datos.EjecutarConsulta();
        }

        public void ModificarPaciente(Paciente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update Medico set DNI=@DNI, Especialidad=@Especialidad where DNI = @DNI");
            datos.AgregarParametro("@Especialidad", nuevo.CodigoPaciente);
            datos.EjecutarConsulta();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioEspecialidad
    {
        /* public List<Especialidad> ListaEspecialidad()
         {
             List<Especialidad> ListaEspecialidad = new List<Especialidad>();
             AccesoDatos datos = new AccesoDatos();
             try
             {
                 datos.SetearQuery("select LegajoMedico, DNI, FechaIngreso, Especialidad from Medico as M inner join Usuario as u on u.DNI=M.DNI");
                 datos.EjecutarConsulta();
                 while (datos.Lector.Read())
                 {
                     Especialidad aux = new Especialidad();

                     aux.LegajoMedico = datos.Lector.GetString(0);
                     aux.FechaIngreso = datos.Lector.GetDateTime(1);
                     // aux.Especialidad = datos.Lector.GetString(3);
                     // me parece que me falta un dato.
                     ListaEspecialidad.Add(aux);
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             return ListaEspecialidad;
         }

         public List<Especialidad> ListaEspecialidades()
         {
             List<Especialidad> ListaEspecialidades = new List<Especialidad>();
             AccesoDatos datos = new AccesoDatos();
             try
             {
                 datos.SetearQuery("select IdEspecialidad, Nombre, Descripcion from Especialidad");
                 datos.EjecutarConsulta();
                 while (datos.Lector.Read())
                 {
                     Especialidad aux = new Especialidad();
                     aux.IdEspecialidad = datos.Lector.GetInt64(0);
                     aux.Nombre = datos.Lector.GetString(1);
                     aux.Descripcion = datos.Lector.GetString(2);
                     ListaEspecialidades.Add(aux);
                 }
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             return ListaEspecialidades;
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

         public void AgregarMedico(Medico nuevo, Persona Persona, Especialidad idEsp)
         {
             AccesoDatos datos = new AccesoDatos();
             datos.SetearQuery("insert into Medico (LegajoMedico,DNI,FechaIngreso,Especialidad) values (@LegajoMedico, @DNI, @FechaIngreso, @Especialidad);");
             datos.AgregarParametro("@LegajoMedico", nuevo.LegajoMedico);
             datos.AgregarParametro("@DNI", Persona.DNI);
             datos.AgregarParametro("@FechaIngreso", nuevo.FechaIngreso);
             datos.AgregarParametro("@Especialidad", idEsp.IdEspecialidad);
             datos.EjecutarConsulta();
         }

         public void ModificarMedico(Medico nuevo)
         {
             AccesoDatos datos = new AccesoDatos();
             datos.SetearQuery("update Medico set DNI=@DNI, Especialidad=@Especialidad where DNI = @DNI");
             datos.AgregarParametro("@Especialidad", nuevo.Especialidad);
             datos.EjecutarConsulta();
         }

     }*/
    }
}

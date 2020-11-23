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

         public void AgregarEspecialidad(Especialidad nuevo)
         {
             AccesoDatos datos = new AccesoDatos();
             datos.SetearQuery("insert into Especialidad (IdEspecialidad, Nombre, Descripcion) values (@IdEspecialidad, @Nombre, @Descripcion);");
             datos.AgregarParametro("@IdEspecialidad", nuevo.IdEspecialidad);
             datos.AgregarParametro("@Nombre", nuevo.Nombre);
             datos.AgregarParametro("@Descripcion", nuevo.Descripcion);
             datos.EjecutarConsulta();

         }


         public void ModificarEspecialidad(Especialidad nuevo)
         {
             AccesoDatos datos = new AccesoDatos();
             datos.SetearQuery("update Especialidad set DNI=@DNI, Especialidad=@Especialidad where DNI = @DNI");
            datos.AgregarParametro("@IdEspecialidad", nuevo.IdEspecialidad);
            datos.AgregarParametro("@Nombre", nuevo.Nombre);
            datos.AgregarParametro("@Descripcion", nuevo.Descripcion);
            datos.EjecutarConsulta();
         }

     }
    }
}

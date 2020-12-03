using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            datos.SetearQuery("insert into Especialidad (Nombre, Descripcion) values (@Nombre, @Descripcion);");
            datos.AgregarParametro("@Nombre", nuevo.Nombre);
            datos.AgregarParametro("@Descripcion", nuevo.Descripcion);
            datos.EjecutarConsulta();

        }


        public bool ModificarEspecialidad(Especialidad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update Especialidad set Nombre=@Nombre, Descripcion=@Descripcion where IdEspecialidad = @IdEspecialidad");
            datos.AgregarParametro("@IdEspecialidad", nuevo.IdEspecialidad);
            datos.AgregarParametro("@Nombre", nuevo.Nombre);
            datos.AgregarParametro("@Descripcion", nuevo.Descripcion);
            datos.EjecutarConsulta();
            return true;
        }
        public void BajaEspecialidad(Especialidad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update Especialidad set estado = 0 where IdEspecialidad = @IdEspecialidad");
            datos.AgregarParametro("@IdEspecialidad", nuevo.IdEspecialidad);
            datos.EjecutarConsulta();
        }
    }
}

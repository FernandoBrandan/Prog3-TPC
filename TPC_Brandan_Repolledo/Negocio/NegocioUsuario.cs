using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioUsuario
    {
        public List<Persona> ListarPersonas()
        {
            List<Persona> ListarPersonas = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select Nombre from persona");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                    aux.Nombre = datos.Lector.GetString(0);
                    //  aux.Apellido = datos.Lector.GetString(2);
                    //  aux.Domicilio = datos.Lector.GetString(3);
                    //  aux.FechaNacimiento = datos.Lector.GetDateTime(4);
                    //    aux.Genero = datos.Lector.GetString(4);
                    //  aux.Estado = datos.Lector.GetBoolean(6);

                    ListarPersonas.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarPersonas;
        }
    }
}

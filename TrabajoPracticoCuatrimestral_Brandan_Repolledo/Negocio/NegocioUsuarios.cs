using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioUsuarios
    {
        public List<Persona> ListarPersonas()
        {
            Persona aux;
            List<Persona> ListarPersonas = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.SetearQuery("select DNI, Nombre, Apellido, Domicilio, FechaNacimiento, Genero, Estado from Persona");
                datos.SetearQuery("select DNI, Nombre, Apellido, Domicilio, Genero from Persona");
                //datos.SetearQuery("select * from Persona");
                datos.EjecutarConsulta();

                while(datos.Lector.Read())
                {
                    aux = new Persona();
                    aux.DNI = datos.Lector.GetInt32(0);
                    aux.Nombre = datos.Lector.GetString(1);
                    aux.Apellido = datos.Lector.GetString(2);
                    aux.Domicilio = datos.Lector.GetString(3);
                //    aux.FechaNacimiento = datos.Lector.GetDateTime(4);
                    aux.Genero = datos.Lector.GetString(4);
               //     aux.Estado = datos.Lector.GetBoolean(6);

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

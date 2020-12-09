using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioPersona
    { 
        public List<Persona> ValidaDNI()
        {
            List<Persona> ValidaDNI = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select DNi Estado from Persona");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                    aux.DNI = datos.Lector.GetInt64(0);
                    ValidaDNI.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ValidaDNI;
        }
    }
}

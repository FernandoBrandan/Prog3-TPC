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

        public void AgregarPersona(Persona nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Persona (DNI) values (@DNI);");
            datos.AgregarParametro("@DNI", nuevo.DNI);
            datos.EjecutarConsulta();

        }

        public void AgregarUsuario(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Usuario (LegajoUsuario) values (@LegajoUsuario);");
            datos.AgregarParametro("@LegajoUsuario", nuevo.LegajoUsuario);
            datos.EjecutarConsulta();
        }

        public List<Persona> CargarGenero()
        {
            List<Persona> ListaGenero = new List<Persona>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select genero from persona");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                  /*  aux.Genero = datos.Lector.GetString(0);*/

                    ListaGenero.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaGenero;
        }

    }
}

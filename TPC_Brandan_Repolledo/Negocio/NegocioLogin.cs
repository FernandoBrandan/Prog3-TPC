using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioLogin
    {          
        public List<Perfil> ListarPerfil()
        {
            List<Perfil> ListarPerfil = new List<Perfil>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select IdPerfil, Rol from Perfil");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Perfil aux = new Perfil();
                    aux.IdPerfil = datos.Lector.GetInt64(0);
                    aux.Rol = datos.Lector.GetString(1);
                    ListarPerfil.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListarPerfil;
        }  
    }
}

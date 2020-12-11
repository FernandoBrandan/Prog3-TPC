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
        int existe;

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

        public int ValidarMedico(string user, string pass)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select COUNT(1) from Persona as p inner join Medico as m on m.DNI=p.DNI inner join Seguridad as s on s.IdSeguridad=m.Seguridad where s.Contraseña = @PASS and upper(m.LegajoMedico) = upper(@USER)");
                datos.AgregarParametro("@USER", user);
                datos.AgregarParametro("@PASS", pass);
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    existe = datos.Lector.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }

        public int ValidarUsuario(string user, string pass)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select COUNT(1) from Persona as p inner join Usuario as u on u.DNI=p.DNI inner join Seguridad as s on s.IdSeguridad=u.Seguridad where s.Contraseña = @PASS and upper(u.LegajoUsuario) = upper(@USER)");
                datos.AgregarParametro("@USER", user);
                datos.AgregarParametro("@PASS", pass);
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    existe = datos.Lector.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }

        public int ValidaAdmin(string user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select p.IdPerfil from  Usuario as u , Perfil as p where u.LegajoUsuario = @USER and u.Perfil=p.IdPerfil");
                datos.AgregarParametro("@USER", user); 
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    long var = datos.Lector.GetInt64(0);
                    existe = Convert.ToInt32(var);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }
    }
}

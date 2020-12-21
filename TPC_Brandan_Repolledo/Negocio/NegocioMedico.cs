using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioMedico
    {
            public List<Medico> ListaMedicos()
            {
                List<Medico> ListaMedicos = new List<Medico>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.SetearQuery("select m.DNI, Nombre, Apellido, Domicilio, FechaNacimiento, Genero, Estado, LegajoMedico from persona as p inner join Medico as m on m.DNI=p.DNI");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Medico aux = new Medico();
                        aux.Estado = (bool)datos.Lector["ESTADO"];
                        if (aux.Estado == true)
                        {
                            aux.DNI = datos.Lector.GetInt64(0);
                            aux.Nombre = datos.Lector.GetString(1);
                            aux.Apellido = datos.Lector.GetString(2);
                            aux.Domicilio = datos.Lector.GetString(3);
                            aux.FechaNacimiento = datos.Lector.GetDateTime(4);
                            aux.Genero = datos.Lector.GetString(5);
                            aux.Estado = datos.Lector.GetBoolean(6);
                            aux.LegajoMedico = datos.Lector.GetString(7);
                            ListaMedicos.Add(aux);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return ListaMedicos;
            }

            public List<Medico> BuscaMedicos(Especialidad filtrado)
            {
                List<Medico> BuscaMedicos = new List<Medico>();
                AccesoDatos datos = new AccesoDatos();
                try
                {

                    datos.AgregarParametro("@IdEspecialidad", filtrado.IdEspecialidad);
                    datos.SetearQuery("select m.DNI, p.Nombre, Apellido, Domicilio, FechaNacimiento, Genero, Estado, LegajoMedico from persona as p inner join Medico as m on m.DNI = p.DNI where Especialidad = @IdEspecialidad");
                    datos.EjecutarConsulta();
                    while (datos.Lector.Read())
                    {
                        Medico aux = new Medico();
                        aux.DNI = datos.Lector.GetInt64(0);
                        aux.Nombre = datos.Lector.GetString(1);
                        aux.Apellido = datos.Lector.GetString(2);
                        aux.Domicilio = datos.Lector.GetString(3);
                        aux.FechaNacimiento = datos.Lector.GetDateTime(4);
                        aux.Genero = datos.Lector.GetString(5);
                        aux.Estado = datos.Lector.GetBoolean(6);
                        aux.LegajoMedico = datos.Lector.GetString(7);
                        BuscaMedicos.Add(aux);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return BuscaMedicos;
            }

        public List<Medico> ListaMedicos2()
        {
            List<Medico> ListaMedicos2 = new List<Medico>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select m.DNI, Nombre, Apellido, Domicilio, FechaNacimiento, Genero, Estado, LegajoMedico from persona as p inner join Medico as m on m.DNI=p.DNI");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Medico aux = new Medico();
                    aux.Estado = (bool)datos.Lector["ESTADO"];
                    if (aux.Estado == true)
                    {
                        aux.DNI = datos.Lector.GetInt64(0);
                        aux.Nombre = datos.Lector.GetString(1);
                        aux.Apellido = datos.Lector.GetString(2);
                        aux.Domicilio = datos.Lector.GetString(3);
                        aux.FechaNacimiento = datos.Lector.GetDateTime(4);
                        aux.Genero = datos.Lector.GetString(5);
                        aux.Estado = datos.Lector.GetBoolean(6);
                        aux.LegajoMedico = datos.Lector.GetString(7);
                        ListaMedicos2.Add(aux);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaMedicos2;
        }

        public void AgregarMedico(Medico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearSP("sp_Agregar_Medico2");
            datos.Comando.Parameters.Clear();
            datos.Comando.Parameters.AddWithValue("@LegajoMedico", nuevo.LegajoMedico);
            datos.Comando.Parameters.AddWithValue("@DNI", nuevo.DNI);
            datos.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
            datos.Comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
            datos.Comando.Parameters.AddWithValue("@Domicilio", nuevo.Domicilio);
            datos.Comando.Parameters.AddWithValue("@FechaNacimiento", nuevo.FechaNacimiento);
            datos.Comando.Parameters.AddWithValue("@Genero", nuevo.Genero);
            datos.Comando.Parameters.AddWithValue("@Estado", nuevo.Estado);
            datos.Comando.Parameters.AddWithValue("@FechaIngreso", nuevo.FechaIngreso);
            datos.Comando.Parameters.AddWithValue("@IDEspecialidad", nuevo.Especialidad.IdEspecialidad);
            datos.Comando.Parameters.AddWithValue("@Pass", nuevo.Seguridad.Contraseña);
            datos.Comando.Parameters.AddWithValue("@UltConexion", nuevo.Seguridad.UltimaConexion);
            datos.Comando.Parameters.AddWithValue("@Perfil", nuevo.Perfil.IdPerfil);
            datos.ejecutarAccion(); // por los procedure
        } 
            public void AgregarSeguridad(Medico nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearQuery("insert into Seguridad (Contraseña, UltimaConexion) values (@Pass, @UltConexion)");
                datos.AgregarParametro("@Pass", nuevo.Seguridad.Contraseña);
                datos.AgregarParametro("@UltConexion", nuevo.Seguridad.UltimaConexion);
                datos.EjecutarConsulta();
            }



            public void AgregarPersona(Persona nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                //datos.SetearQuery("insert into Persona (DNI,Nombre,Apellido,Domicilio,FechaNacimiento,Genero,Estado,Seguridad) values (@DNI,@Nombre,@Apellido,@Domicilio,@FechaNacimiento,@Genero,@Estado, @seguridad);");
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
                datos.SetearQuery("insert into Medico (LegajoMedico,DNI,FechaIngreso,Especialidad,Seguridad,Perfil) values (@LegajoMedico, @DNI, @FechaIngreso, @Especialidad, (select MAX(IdSeguridad) from Seguridad), @Perfil);");
                datos.AgregarParametro("@LegajoMedico", nuevo.LegajoMedico);
                datos.AgregarParametro("@DNI", Persona.DNI);
                datos.AgregarParametro("@FechaIngreso", nuevo.FechaIngreso);
                datos.AgregarParametro("@Especialidad", idEsp.IdEspecialidad);
                datos.AgregarParametro("@Perfil", nuevo.Perfil.IdPerfil);
                datos.EjecutarConsulta();
            }

            public bool ModificarMedicoPersona(Medico nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearQuery("update persona set DNI=@DNI, Nombre=@Nombre, Apellido=@Apellido, Domicilio=@Domicilio where DNI = @DNI");
                datos.AgregarParametro("@DNI", nuevo.DNI);
                datos.AgregarParametro("@Nombre", nuevo.Nombre);
                datos.AgregarParametro("@Apellido", nuevo.Apellido);
                datos.AgregarParametro("@Domicilio", nuevo.Domicilio);
                datos.EjecutarConsulta();
                return true;
            }

            public bool ModificarMedico(Medico nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearQuery("update Medico set Especialidad=@Especialidad where DNI = @DNI");
                datos.AgregarParametro("@DNI", nuevo.DNI);
                datos.AgregarParametro("@Especialidad", nuevo.Especialidad.IdEspecialidad);
                datos.EjecutarConsulta();
                return true;
            }
            public void BajaMedico(Medico nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearQuery("update persona set estado = 0 where DNI = @DNI");
                datos.AgregarParametro("@DNI", nuevo.DNI);
                datos.EjecutarConsulta();
            }
            public void RecuperarMedico(Medico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update persona set estado = 1 where DNI = @DNI");
            datos.AgregarParametro("@DNI", nuevo.DNI);
            datos.EjecutarConsulta();
        }

    }
}

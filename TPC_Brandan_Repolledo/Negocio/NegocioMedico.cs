using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class NegocioMedico
    {

        public List<Medico> ListaMedicos()
        {
            List<Medico> ListaMedicos = new List<Medico>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select LegajoMedico,DNI,FechaIngreso,Especialidad  from Medico as M  inner join Usuario as u on u.DNI=M.DNI");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Medico aux = new Medico();

                    aux.LegajoMedico = datos.Lector.GetString(0);
                    aux.FechaIngreso = datos.Lector.GetDateTime(1);
                    aux.DNI= datos.Lector.GetString(2);
                    aux.Especialidad = datos.Lector.GetString(3);
                    // me parece que me falta un dato.
                    ListaMedicos.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaMedicos;
        }

        public void AgregarMedico(Persona nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Medico (LegajoMedico,DNI,FechaIngreso,Especialidad) values (@LegajoMedico, @DNI, @FechaIngreso, @Especialidad);");
            datos.AgregarParametro("@LegajoMedico", nuevo.DNI);
            datos.AgregarParametro("@DNI", nuevo.Nombre);
            datos.AgregarParametro("@FechaIngreso", nuevo.FechaIngreso);
            datos.AgregarParametro("@Especialidad", nuevo.Domicilio);
            datos.EjecutarConsulta();

        }

        public void AgregarUsuario(Medico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("insert into Medico (LegajoMedico,DNI,FechaIngreso,Especialidad) values (@LegajoMedico, @DNI, @FechaIngreso, @Especialidad);");
            datos.AgregarParametro("@LegajoMedico", nuevo.LegajoMedico);
            datos.AgregarParametro("@DNI", nuevo.DNI);
            datos.AgregarParametro("@FechaIngreso", nuevo.FechaIngreso);
            datos.AgregarParametro("@Especialidad", nuevo.Especialidad);
            datos.EjecutarConsulta();
        }

        public void ModificarUsuario(Medico nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearQuery("update Medico set DNI=@DNI, Especialidad=@Especialidad where DNI = @DNI");
            datos.AgregarParametro("@Especialidad", nuevo.Especialidad);
            datos.EjecutarConsulta();
        }
    }
}

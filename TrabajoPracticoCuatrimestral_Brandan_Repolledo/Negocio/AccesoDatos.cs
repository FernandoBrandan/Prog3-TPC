using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Negocio
{
    public class AccesoDatos
    {
        public SqlConnection Conexion { get; set; }
        public SqlDataReader Lector { get; set; }
        public SqlCommand Comando { get; set; }

        public AccesoDatos()
        {
            Conexion = new SqlConnection("data source= DESKTOP-PRA4SKB\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security=sspi"); 
       //     Conexion = new SqlConnection("data source= LAPTOP-PUO76A7L\\MSSQLSERVERR; initial catalog= CATALOGO_DB; integrated security=sspi"); //Maite
            Comando = new SqlCommand();
            Comando.Connection = Conexion;
        }

        public void SetearQuery(string Consulta) 
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }

        public void AgregarParametro(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }

        public void EjecutarConsulta()
        {
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CerraConexion()
        {
            Conexion.Close();
        }
    }
}

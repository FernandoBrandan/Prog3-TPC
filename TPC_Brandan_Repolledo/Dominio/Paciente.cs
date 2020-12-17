using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente : Persona
    {
        public string CodigoPaciente { get; set; }

        public DateTime FechaInscripcion { get; set; }
        public Seguridad Seguridad { get; set; }

        public string Email { get; set; }
        public override string ToString()
        {
            string var = Apellido + Nombre;
            // string var = this.Apellido + ", " + this.Nombre; no funciona
            // string var = LegajoMedico; Funciona bien
            return var;
        }

    }
}

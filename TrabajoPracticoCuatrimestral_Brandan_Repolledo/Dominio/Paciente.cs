using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Paciente : Persona
    {
        public int CodigoPaciente { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public string Email { get; set; }
    }
}

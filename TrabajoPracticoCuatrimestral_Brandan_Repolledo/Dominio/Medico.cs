using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Medico : Persona
    {
        public int LegajoMedico { get; set; }

        public DateTime FechaIngreso  { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico : Persona
    {
        public string LegajoMedico { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}

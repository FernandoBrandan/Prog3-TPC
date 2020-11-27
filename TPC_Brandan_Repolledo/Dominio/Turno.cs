using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }

        public int Disponibilidad { get; set; }

        public int Medico { get; set; }

        public int Paciente { get; set; }

        public bool Estado { get; set; }

        public string Motivo { get; set; }
    }
}

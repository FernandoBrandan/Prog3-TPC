using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disponibilidad
    {
        public long IdDisponibilidad { get; set; }

        public Horario Horario { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; }
       // public bool Estado { get; set; }
    }
}

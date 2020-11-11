using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class FichaMedica
    {
        public int IdFicha { get; set; }

        public Turno Turno { get; set; }

        public string Diagnostico{ get; set; }
    }
}

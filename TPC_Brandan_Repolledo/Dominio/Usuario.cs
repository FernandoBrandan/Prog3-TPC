using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : Persona
    {
        public string LegajoUsuario { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Seguridad Seguridad { get; set; }

        public Perfil Perfil { get; set; }
    }
}

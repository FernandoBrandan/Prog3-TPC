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

        public override string ToString()
        { 
            string var = Apellido + ", " + Nombre;
            // string var = this.Apellido + ", " + this.Nombre; no funciona
            // string var = LegajoMedico; Funciona bien
            return var;
        } 
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Seguridad
    {
        public long IdSeguridad { get; set; }

        public string Contraseña { get; set; }

        public DateTime UltimaConexion { get; set; }
    }
}

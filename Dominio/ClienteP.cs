﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteP : Cliente
    {
        public Contacto Datos { get; set; }

        public override string ToString()
        {
            return Datos.Nombre + " " + Datos.Apellido;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Clave { get; set; }
    }
}
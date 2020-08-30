using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWeb.Models
{
    public class Producto
    {
        public int Id  { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
    }
}
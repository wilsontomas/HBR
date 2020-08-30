using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaWeb.Models
{
    public class VMProductoCategorias
    {
        public Producto producto { get; set; }

        public List<Categoria> categorias { get; set; }
    }
}
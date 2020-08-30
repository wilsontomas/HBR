using PracticaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;

namespace PracticaWeb.Clases
{
    public class MetodosCategoria:DBConexion
    {
        public List<Categoria> ObtenerCategorias()
        {
            var categorias = this.Conection.Query<Categoria>("Mostrar_Categoria", new {}, commandType: CommandType.StoredProcedure).ToList();
            return categorias;
        }
    }
}
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

        public List<Producto> ObtenerProductoPorCategori(int IdCategoria)
        {
            var productos = this.Conection.Query<Producto>("Buscar_Producto_Categoria", new { @IdC = IdCategoria }, commandType: CommandType.StoredProcedure).ToList();
            return productos;
        }

        public void EliminarCategoria(int IdCategoria)
        {
            this.Conection.Execute("Eliminar_Categoria", new { @IdC = IdCategoria }, commandType: CommandType.StoredProcedure);          
        }

        public void AgregarCategoria(string Nombre)
        {
            this.Conection.Execute("Crear_Categoria", new { @NombreC = Nombre }, commandType: CommandType.StoredProcedure);
        }

        public Categoria BuscarCategoria(int Id)
        {
           var categoria = this.Conection.Query<Categoria>("Buscar_Categoria", new { @IdC = Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return categoria;
        }

        public void EditarCategoria(int Id, string Nombre)
        {
            this.Conection.Execute("Editar_Categoria", new { @IdC = Id, @NombreC = Nombre }, commandType: CommandType.StoredProcedure);          
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticaWeb.Models;
using Dapper;
using System.Data;

namespace PracticaWeb.Clases
{
    public class MetodosProducto:DBConexion
    {
        public List<ProductoCategoria> ObtenerProductos()
        {
            var ListaProductos = this.Conection.Query<ProductoCategoria>("Mostrar_Productos_Categoria",new { }, commandType: CommandType.StoredProcedure).ToList();
            if (ListaProductos.Count > 0) { return ListaProductos; } else { return null; }
        }

        public Producto BuscarProducto(int Id)
        {
            var producto = this.Conection.QueryFirstOrDefault<Producto>("Buscar_Producto", new { @IdProducto=Id }, commandType: CommandType.StoredProcedure);
            if (producto != null)
            {
                return producto;
            }
            else { return null; }
        }

        public bool EliminarProducto(int Id)
        {
            var rows = this.Conection.Execute("Eliminar_Producto", new { @IdP = Id }, commandType: CommandType.StoredProcedure);
            if(rows > 0) { return true; } else { return false; }
        }

        public bool EditarProducto(Producto producto)
        {
            var rows = this.Conection.Execute("Editar_Producto", new { @IdP = producto.Id, @NombreP= producto.Nombre, @CategoriaP = producto.IdCategoria }, commandType: CommandType.StoredProcedure);
            if (rows > 0) { return true; } else { return false; }
        }

        public bool CrearProducto(string nombre, int categoria)
        {
            var rows = this.Conection.Execute("Crear_Producto", new { @NombreP = nombre, @CategoriaP = categoria }, commandType: CommandType.StoredProcedure);
            if (rows > 0) { return true; } else { return false; }
        }
    }

}
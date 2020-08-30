using PracticaWeb.Clases;
using PracticaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWeb.Controllers
{
    [Authorize]
    public class ProductoController : Controller
    {
        // GET: Producto
        private MetodosProducto metodos = new MetodosProducto();
        public ActionResult ListarProducto()
        {
            var ListaProductos = metodos.ObtenerProductos();
            return View(ListaProductos);
        }

        public ActionResult EditarProducto(int Id)
        {
            var metodoscategorias = new MetodosCategoria();
            VMProductoCategorias Vm = new VMProductoCategorias();
            Vm.producto = metodos.BuscarProducto(Id);
            Vm.categorias = metodoscategorias.ObtenerCategorias();
         
                 return View(Vm);
         
        }
        [HttpPost]
        public ActionResult EditarProductoAccion(Producto producto)
        {
            metodos.EditarProducto(producto);
            return RedirectToAction("ListarProducto");
        }
        public ActionResult CrearProducto(string mensaje="")
        {
            ViewBag.Mensaje = mensaje;

            var metodosCategoria = new MetodosCategoria();
            var ListaCategoria = metodosCategoria.ObtenerCategorias();
            return View(ListaCategoria);
        }
        [HttpPost]
        public ActionResult CrearProductoAccion(Producto producto)
        {
            if(producto.Nombre != "")
            {
                if(metodos.CrearProducto(producto.Nombre, producto.IdCategoria))
                {
                    return RedirectToAction("ListarProducto");
                }
                else { return RedirectToAction("CrearProducto", new { mensaje = "Problemas al crear el producto." });}              
            }
            else
            {
                return RedirectToAction("CrearProducto",new { mensaje="Los campos deben estar llenos."});
            }
           
        }
        public ActionResult EliminarProducto(int Id)
        {
            metodos.EliminarProducto(Id);
            return RedirectToAction("ListarProducto");
        }
    }
}
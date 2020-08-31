using PracticaWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWeb.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private MetodosCategoria metodos = new MetodosCategoria();
        // GET: Categoria
        public ActionResult ListarCategoria()
        {
            var ListaCategorias = metodos.ObtenerCategorias();
            return View(ListaCategorias);
        }

        public ActionResult EditarCategoria(int IdCategoria)
        {
            var categoria = metodos.BuscarCategoria(IdCategoria);
            return View(categoria);
        }
        [HttpPost]
        public ActionResult EditarCategoriaAccion(int Id, string nombre)
        {
            metodos.EditarCategoria(Id,nombre);
          return RedirectToAction("ListarCategoria");
        }
        public ActionResult CrearCategoria()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult CrearCategoriaAccion(string NombreCategoria)
        {
            if (!string.IsNullOrEmpty(NombreCategoria))
            {
                metodos.AgregarCategoria(NombreCategoria);
            }

            return RedirectToAction("ListarCategoria");
        }

        public ActionResult EliminarCategoria(int IdCategoria)
        {
            metodos.EliminarCategoria(IdCategoria);
            return RedirectToAction("ListarCategoria");
        }

        public ActionResult FiltroCategoria(int IdCategoria)
        {
            var ListaProductos = metodos.ObtenerProductoPorCategori(IdCategoria);
            return View(ListaProductos);
        }
    }
}
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
        // GET: Categoria
        public ActionResult ListarCategoria()
        {
            return View();
        }

        public ActionResult EditarCategoria()
        {
            return View();
        }

        public ActionResult CrearCategoria()
        {
            return View();
        }

        public ActionResult EliminarCategoria()
        {
            return RedirectToAction("ListarProducto");
        }
    }
}
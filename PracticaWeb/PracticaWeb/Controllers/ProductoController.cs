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
       
        public ActionResult ListarProducto()
        {
            return View();
        }

        public ActionResult EditarProducto()
        {
            return View();
        }

        public ActionResult CrearProducto()
        {
            return View();
        }

        public ActionResult EliminarProducto()
        {
            return RedirectToAction("ListarProducto");
        }
    }
}
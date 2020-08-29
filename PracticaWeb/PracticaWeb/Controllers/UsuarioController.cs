using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PracticaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Login(string mensaje="")
        {
            ViewBag.Mensaje = mensaje;
            return View();
        }
        [HttpPost]
        public ActionResult IniciarSesion(string NombreUsuario, string Clave)
        {
           
            string user = "wilson"; string pass = "123";

            if(!String.IsNullOrEmpty(NombreUsuario) || !String.IsNullOrEmpty(Clave))
            {
              
                if(NombreUsuario==user && Clave == pass)
                {
                    FormsAuthentication.SetAuthCookie(NombreUsuario,true);
                    return RedirectToAction("Perfil");
                }
                else
                {
                    // return Login("Datos incorrectos.");
                    return RedirectToAction("Login","Usuario",new { mensaje ="Datos incorrectos" });
                }
            }
            else
            {
                 return RedirectToAction("Login", "Usuario", new { mensaje = "Favor llenar los datos" });
            }

           // return RedirectToAction("Perfil");
           // return Login();
        }

        public ActionResult Registrarse()
        {
            return View();
        }
        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult EditarPerfil()
        {
            return RedirectToAction("Perfil");
        }
        [Authorize]
        public ActionResult Cerrar()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
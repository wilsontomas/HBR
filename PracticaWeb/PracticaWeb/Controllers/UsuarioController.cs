using PracticaWeb.Clases;
using PracticaWeb.Models;
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
        private MetodosUsuario metodos = new MetodosUsuario();
        // GET: Usuario
        public ActionResult Login(string mensaje="")
        {
            ViewBag.Mensaje = mensaje;
            return View();
        }
        [HttpPost]
        public ActionResult IniciarSesion(string NombreUsuario, string Clave)
        {
        
            if(!String.IsNullOrEmpty(NombreUsuario) || !String.IsNullOrEmpty(Clave))
            {
              
                if(metodos.ValidarUsuario(NombreUsuario,Clave))
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

        public ActionResult Registrarse(string mensaje="")
        {
            ViewBag.Mensaje = mensaje;
            return View();
        }
        [HttpPost]
        public ActionResult Registrarse(Usuario usuario)
        {
            if (usuario ==null)
            {
                return RedirectToAction("Registrarse", "Usuario", new { mensaje = "Los datos estan vacios." });
            }
            else
            {
                if (!metodos.VerificarUsuario(usuario.NombreUsuario))
                {
                    //return RedirectToAction("Registrarse", "Usuario", new { mensaje = "Se puede logear" });
                    if (metodos.RegistrarUsuario(usuario))
                    {
                        FormsAuthentication.SetAuthCookie(usuario.NombreUsuario, true);
                        return RedirectToAction("Perfil");
                    }
                    else
                    {
                        return RedirectToAction("Registrarse", "Usuario", new { mensaje = "Ha ocurrido un error al insertar" });
                    }
                }
                else
                {
                    return RedirectToAction("Registrarse", "Usuario", new { mensaje = "El usuario ya existe." });
                }
            }
           
        }
        public ActionResult Perfil(string mensaje="")
        {
            ViewBag.Mensaje = mensaje;
            //System.Web.HttpContext.Current.User.Identity.Name;
            var DatoUsuario = metodos.ObtenerUsuario(User.Identity.Name);

            return View(DatoUsuario);
        }

        [HttpPost]
        public ActionResult EditarPerfil(int Id, string Nombre, string Apellido)
        {
            if (!String.IsNullOrEmpty(Nombre) || !String.IsNullOrEmpty(Apellido))
            {
                metodos.EditarPerfil(Id, Nombre, Apellido);                
                return RedirectToAction("Perfil");               
            }
            else
            {
                return RedirectToAction("Perfil", "Usuario", new { mensaje = "Los campos deben estar llenos." });
              
            }
           
        }
        [Authorize]
        public ActionResult Cerrar()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
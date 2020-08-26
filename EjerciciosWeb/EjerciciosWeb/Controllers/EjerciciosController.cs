using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EjerciciosWeb.Ejercicios;
using Microsoft.AspNetCore.Cors;
using EjerciciosWebXML.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EjerciciosWeb.Controllers
{
    
    [EnableCors("MyCors")]
    [Route("api/Ejercicios")]
    public class EjerciciosController : Controller
    {
        //[Produces("application/json", "application/xml")]
        private Ejercicio metodo = new Ejercicio();

        [Produces("application/xml")]
        [HttpGet("Ejercicio1")]
        public object Practica1(int numero1, int numero2)
        {
           
            return metodo.Practica1(numero1, numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio2")]
        public object Practica2(int numero1, int numero2)
        {
            return metodo.Practica2(numero1,numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio3")]
        public object Practica3(int numero1, int numero2)
        {
            return metodo.Practica3(numero1, numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio4")]
        public object Practica4(int numero1,int numero2)
        {
            return metodo.Practica4(numero1, numero2);
           
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio5")]
        public object Practica5(string letra)
        {
            return metodo.Practica5(letra);

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio6")]
        public object Practica6(int numero1, int numero2)
        {
            return metodo.Practica6(numero1, numero2);

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio7")]
        public object Practic7(int numero)
        {
            return metodo.Practica7(numero);

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio8")]
        public object Practic8()
        {
            return metodo.Practica8();

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio9")]
        public object Practic9()
        {
            return metodo.Practica9();

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio10")]
        public object Practic10()
        {
            return metodo.Practica10();

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio11")]
        public object Practic11()
        {
            return metodo.Practica11();

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio12")]
        public object Practic12()
        {
            return metodo.Practica12();

        }
        [Produces("application/json")]
        [HttpGet("Ejercicio13")]
        public object Practic13()
        {
            return metodo.Practica13();

        }
        [Produces("application/json")]
        [HttpGet("Ejercicio14")]
        public object Practic14()
        {
            return metodo.Practica14();

        }

        [Produces("application/json")]
        [HttpGet("Ejercicio15")]
        public object Practic15(int[] arreglo)
        {
            return metodo.Practica15(arreglo);

        }

        [Produces("application/json")]
        [HttpGet("Ejercicio16")]
        public object Practic16()
        {
            return metodo.Practica16();

        }
        [Produces("application/json")]
        [HttpGet("Ejercicio17")]
        public object Practic17()
        {
            return metodo.Practica17();

        }

        [Produces("application/json")]
        [HttpGet("Ejercicio18")]
        public object Practic18()
        {
            return metodo.Practica18();

        }
        [Produces("application/json")]
        [HttpGet("Ejercicio19")]
        public object Practic19()
        {
            return metodo.Practica19();

        }
        [Produces("application/json")]
        [HttpPost("Ejercicio20")]
        public object Practic20(List<Paises> Paises)
        {
           // return metodo.Practica20(paises);
            return "hola mundo";
        }
        // GET: api/<controller>
        [Produces("application/xml")]
        [HttpGet]
        public object Get()
        {
          
            return new string[] { "wilson", "tomas" };

        }


        //[Produces("application/json")]

    }
}

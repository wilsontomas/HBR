using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EjerciciosWeb.Ejercicios;
using Microsoft.AspNetCore.Cors;
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
        [HttpGet("Ejercicio1/{numero1}/{numero2}")]
        public object Practica1(int numero1, int numero2)
        {
           
            return metodo.Practica1(numero1, numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio2/{numero1}/{numero2}")]
        public object Practica2(int numero1, int numero2)
        {
            return metodo.Practica2(numero1,numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio3/{numero1}/{numero2}")]
        public object Practica3(int numero1, int numero2)
        {
            return metodo.Practica3(numero1, numero2);
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio4/{numero1}/{numero2}")]
        public object Practica4(int numero1,int numero2)
        {
            return metodo.Practica4(numero1, numero2);
           
        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio5/{letra}")]
        public object Practica5(string letra)
        {
            return metodo.Practica5(letra);

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio6/{numero1}/{numero2}")]
        public object Practica6(int numero1, int numero2)
        {
            return metodo.Practica6(numero1, numero2);

        }
        [Produces("application/xml")]
        [HttpGet("Ejercicio7/{numero}")]
        public object Practic7(int numero)
        {
            return metodo.Practica7(numero);

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

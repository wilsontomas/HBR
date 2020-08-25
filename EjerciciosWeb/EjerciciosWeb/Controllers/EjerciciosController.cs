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
        private Ejercicio metodo = new Ejercicio();
        [HttpGet("Ejercicio1")]
        public string Practica1(int numero1, int numero2)
        {           
           
            return metodo.Practica1(numero1, numero2);
        }
        [HttpGet("Ejercicio2")]
        public string Practica2(int numero1, int numero2)
        {
            return metodo.Practica2(numero1,numero2);
        }
        [HttpGet("Ejercicio3")]
        public string Practica3(int numero1, int numero2)
        {
            return metodo.Practica3(numero1, numero2);
        }
        [HttpGet("Ejercicio4")]
        public string Practica4(int numero1,int numero2)
        {
            return metodo.Practica4(numero1, numero2);
           
        }

        [HttpGet("Ejercicio5")]
        public string Practica5(string letra)
        {
            return metodo.Practica5(letra);

        }

        [HttpGet("Ejercicio6")]
        public string Practica6(int numero1, int numero2)
        {
            return metodo.Practica6(numero1, numero2);

        }
        [HttpGet("Ejercicio7")]
        public string Practic76(int numero)
        {
            return metodo.Practica7(numero);

        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "wilson", "tomas" };
        }

    }
}

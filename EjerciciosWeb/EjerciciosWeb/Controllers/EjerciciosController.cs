﻿using System;
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
        [HttpGet("Ejercicio1")]
        public string Practica1(int numero1, int numero2)
        {           
            var metodo = new Ejercicio1();
            return metodo.PrimerEjercicio(numero1, numero2);
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "wilson", "tomas" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

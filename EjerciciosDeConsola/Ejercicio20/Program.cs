using Ejercicio20.Models;
using System;
using System.Collections.Generic;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar paises");
            List<Paises> lista = new List<Paises>();
            for (int x=0;x<4;x++)
            {
                var pais = new Paises();
                Console.WriteLine("Ingresa el nombre");
                pais.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresar Temperatura1");
                pais.Temperatura1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar Temperatura2");
                pais.Temperatura2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar Temperatura3");
                pais.Temperatura3 = int.Parse(Console.ReadLine());
                lista.Add(pais);
            }
            var metodos = new Metodos();
            metodos.ImprimirPaises(lista);
        }
    }
}

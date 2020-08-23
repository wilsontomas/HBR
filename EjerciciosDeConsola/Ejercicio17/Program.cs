using System;
using System.Linq;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paises = new string[5];

            for (int x=0;x<5;x++)
            {
                Console.WriteLine($"Ingrese el nombre del pais numero: {x+1}");
                paises[x] = Console.ReadLine();
            }
            Console.WriteLine("El orden alfabetico de los paises es: ");
            Array.Sort(paises);
            foreach (var item in paises)
            {
                Console.WriteLine(item);
            }
           


        }
    }
}

using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            string[] paises = new string[5];
            int[] habitantes = new int[5];
            int numero;
            for(int x= 0; x < 5; x++){
                Console.WriteLine($"Escribe el nombre del pais {x+1}");
                paises[x] = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de habitantes");
                var cantidad = Console.ReadLine();
                if (!int.TryParse(cantidad, out numero)) { Console.WriteLine("No es un numero"); exit = false; break; }
                habitantes[x] = int.Parse(cantidad);
            }
            if (exit) {
                Array.Sort(paises, habitantes);
                Console.WriteLine("Paises por orden alfabetico");
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine($"Pais: {paises[x]}, habitantes: {habitantes[x]}");
                }

                Array.Sort(habitantes, paises);
                Array.Reverse(habitantes);
                Array.Reverse(paises);
                Console.WriteLine("Ordenado por numero de habitantes");
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine($"Habitantes: {habitantes[x]}, Pais: {paises[x]}");
                }
            }
        }
    }
}

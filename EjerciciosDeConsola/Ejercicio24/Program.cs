using System;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
              string[][] arreglo = new string[2][];    
              arreglo[0] = new string[2];
              arreglo[1] = new string[2];
        
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Fila numero: {i + 1}");
                for (int x = 0; x < 2; x++)
                {
                    Console.WriteLine($"introduce el valor de la columna numero: {x + 1}");
                    arreglo[i][x] = Console.ReadLine();
                }
            }
            Console.WriteLine("Matriz");
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Console.Write(arreglo[i][x] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}

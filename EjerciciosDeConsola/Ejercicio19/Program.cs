using System;
using Ejercicio19;
namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] arreglo = new string[2][];
           
            Console.WriteLine("Ingresar valores");

            for (int fila=0; fila<2;fila++)
            {
                arreglo[fila] = new string[5];
                Console.WriteLine($"Ingrese los valores de la fila: {fila+1}");
                for (int col=0; col<5;col++) {
                    Console.WriteLine($"Ingrese los valores de la columna: {col + 1}");
                    arreglo[fila][col] = Console.ReadLine();
                }
            }
            Ejercicio19.Metodos.Imprimir(arreglo);
        }
    }
}

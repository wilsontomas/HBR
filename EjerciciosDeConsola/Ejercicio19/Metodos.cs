using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio19
{
   public static class Metodos
    {
       
       //public static bool IsNumeric(this string text) => double.TryParse(text, out _);
       public static void Imprimir(string[][] arreglo)
        {
            for (int fila=0;fila<arreglo.Length;fila++)
            {
                for (int col=0; col<5;col++)
                {
                    Console.Write( arreglo[fila][col]+ "|"); //

                }
                Console.WriteLine("");
            }
        }
    }
}

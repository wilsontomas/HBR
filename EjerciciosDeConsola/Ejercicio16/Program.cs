using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = {25000,32000,63000,25500,24000 };
            Array.Sort(arreglo);

            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}

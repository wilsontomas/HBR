using System;
using System.Linq;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo ={ 2, 2, 3, 5, 7, 8, 10 };
            int menor = 20;
            int SeRepite = 0;

           foreach(var item in arreglo)
            {
                if(item < menor) { menor = item; }
            }
            foreach (var item in arreglo) { if (item == menor) { SeRepite++; } }
            Console.WriteLine($"El menor es {menor} y se encuentra en el arreglo {SeRepite} veces");
            
        }
    }
}

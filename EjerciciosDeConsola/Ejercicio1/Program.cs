using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool exit = true;
            int number = 0;
            int result, resto;
            do {
                Console.WriteLine("Ingrese el primer numero");
               var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }
                Console.WriteLine("Ingrese el segundo numero");
               var y = Console.ReadLine();
                if (!int.TryParse(y, out number)) { Console.WriteLine("No es un numero"); continue; }

                
                result = int.Parse(x) / int.Parse(y);
                resto = int.Parse(x) % int.Parse(y);
                Console.WriteLine($"La divicion es {result} y el resto es {resto}");
                break;


            } while (exit);
           
           
        }
    }
}

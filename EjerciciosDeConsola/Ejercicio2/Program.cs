using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool exit = true;
            int number = 0;
            int resto;
            do
            {
                Console.WriteLine("Saber si el primero es multiplo del segundo");
                Console.WriteLine("Ingrese el primer numero");
                var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }
                Console.WriteLine("Ingrese el segundo numero");
                var y = Console.ReadLine();
                if (!int.TryParse(y, out number)) { Console.WriteLine("No es un numero"); continue; }
      
                resto = int.Parse(x) % int.Parse(y);
                if(resto == 0) { Console.WriteLine($"{x} es multiplo de {y}"); } else { Console.WriteLine("No es multiplo"); }
                
                break;


            } while (exit);

        }
    }
}

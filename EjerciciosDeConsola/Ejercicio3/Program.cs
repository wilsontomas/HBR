using System;

namespace Ejercicio3
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
                Console.WriteLine("Multiplicacion de dos numeros");
                Console.WriteLine("Ingrese el primer numero");
                var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }
                if(int.Parse(x) == 0) { Console.WriteLine("La multiplicacion de un numero por 0 es cero"); break; }
                Console.WriteLine("Ingrese el segundo numero");
                var y = Console.ReadLine();
                if (!int.TryParse(y, out number)) { Console.WriteLine("No es un numero"); continue; }

                resto = int.Parse(x) * int.Parse(y);
                Console.WriteLine($"El resultado es: {resto}");

                break;


            } while (exit);
        }
    }
}

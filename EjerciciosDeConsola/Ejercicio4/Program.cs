using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool exit = true;
            int number = 0;
            int result;
            do
            {
                Console.WriteLine("Divicion entre 2 numeros");
                Console.WriteLine("Ingrese el primer numero");
                var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }
                
                Console.WriteLine("Ingrese el segundo numero");
                var y = Console.ReadLine();
                if (!int.TryParse(y, out number)) { Console.WriteLine("No es un numero"); continue; }
                if (int.Parse(y) == 0) { Console.WriteLine("No se puede dividir entre cero"); break; }

                result = int.Parse(x) / int.Parse(y);
                Console.WriteLine($"El resultado es: {result}");

                break;


            } while (exit);
        }
    }
}

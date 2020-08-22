using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            int number = 0;

            do
            {
                Console.WriteLine("Valor absoluto");
                Console.WriteLine("Ingrese el numero");
                var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }

                var numero = int.Parse(x);
                if(numero > 0)
                {
                    Console.WriteLine($"El valor absoluto es {numero}");
                }
                else
                {
                    Console.WriteLine($"El valor absoluto es {Math.Abs(numero)}");
                }
                break;


            } while (exit);
        }
    }
}

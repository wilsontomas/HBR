using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            int number = 0;
            
            do
            {
                Console.WriteLine("Verificar si el numero es positivo");
                Console.WriteLine("Ingrese el primer numero");
                var x = Console.ReadLine();
                if (!int.TryParse(x, out number)) { Console.WriteLine("No es un numero"); continue; }

                Console.WriteLine("Ingrese el segundo numero");
                var y = Console.ReadLine();
                if (!int.TryParse(y, out number)) { Console.WriteLine("No es un numero"); continue; }

                if (int.Parse(x) < 0 && int.Parse(y) >0)
                {
                    Console.WriteLine($"Uno de los numeros es positivo");
                }else if (int.Parse(x) > 0 && int.Parse(y) < 0) {
                    Console.WriteLine($"Uno de los numeros es positivo");
                }else if (int.Parse(x) > 0 && int.Parse(y) > 0) {
                    Console.WriteLine($"Ambos numeros son positivos");
                }else { Console.WriteLine($"Nunguno de los numeros es positivos"); }
               
                break;


            } while (exit);
        }
    }
}

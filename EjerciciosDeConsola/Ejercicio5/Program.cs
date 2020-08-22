using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            char caracter='a';

            do
            {
                Console.WriteLine("Introduce una nueva letra");
                var letra = Console.ReadLine();
                if (!char.TryParse(letra, out caracter)) { Console.WriteLine("No es una sola letra"); continue; }
                caracter = char.Parse(letra);
                if(caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                {
                    Console.WriteLine("Es una vocal");
                }
                else
                {
                    Console.WriteLine("No es una vocal");
                    continue;
                }
               
                break;
            } while (exit);
        }
    }
}

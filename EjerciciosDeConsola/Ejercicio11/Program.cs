using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 26;

            do {
                if (x % 2 == 0) { Console.WriteLine(x); }
                x--;
            } while (x>=10);
        }
    }
}

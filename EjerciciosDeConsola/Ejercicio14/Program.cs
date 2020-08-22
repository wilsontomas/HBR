using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 50)
            {
                if(x % 3 == 0)
                {
                  Console.WriteLine(x);
                }
                x++;
            }
        }
    }
}

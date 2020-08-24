using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empleados = new string[3];
            string[][] Dias = new string[3][];
            int Faltas=100000;
            
            string nombre = "";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introdusca el nombre del empleado.");
                empleados[i] = Console.ReadLine();
                Console.WriteLine($"Cuantos dias falto el empleado: {empleados[i]}");
                var valor = int.Parse(Console.ReadLine());
                Dias[i] = new string[valor];
            }
            Console.WriteLine("Datos de los empleaados");
            
            for (int x = 0; x < 3; x++)
            {
              
                Console.WriteLine($"{empleados[x]} ha faltado {Dias[x].Length} dias.");
                if(Dias[x].Length < Faltas) { Faltas = Dias[x].Length; nombre = empleados[x]; }
            }

            Console.WriteLine($"El empleado con menos faltas es: {nombre}");
        }
    }
}

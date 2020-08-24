using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio24
{
    class Metodos
    {
        public string[][] arreglo = new string[3][];

        public Metodos() {
              arreglo[0] = new string[3];
              arreglo[1] = new string[3];
              arreglo[2] = new string[3];
        }

        public void LlenarArreglo()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Fila numero: {i + 1}");
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine($"introduce el valor de la columna numero: {x + 1}");
                    arreglo[i][x] = Console.ReadLine();
                }
            }
            mostrarArreglo();
        }
            
        public void mostrarArreglo()
        {
            Console.WriteLine("Matriz");
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(arreglo[i][x] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Vertices");
            for (int i = 0; i < 3; i+=2)
            {
                for (int x = 0; x < 3; x +=2)
                {
                   
                    Console.Write(arreglo[i][x] + " ");
                }
                Console.WriteLine("");
            }

        }

    }
}

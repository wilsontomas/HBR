using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio23
{
   public class Metodos
    {
      public string[][] arreglo = new string[2][];

        public Metodos()
        {
            arreglo[0] = new string[2];
            arreglo[1] = new string[2];
        }

        public void LlenarArreglo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Fila numero: {i + 1}");
                for (int x = 0; x < 2; x++)
                {
                    Console.WriteLine($"introduce el valor de la columna numero: {x + 1}");
                    this.arreglo[i][x] = Console.ReadLine();
                }
            }
            mostrarArreglo();
        }

        public void mostrarArreglo()
        {   Console.WriteLine("Arreglo sin invertir.");
            for (int i = 0; i < 2; i++)
            {             
                for (int x = 0; x < 2; x++)
                {
                    Console.Write(this.arreglo[i][x]+" ");                  
                }
                    Console.WriteLine("");
            }

            //intercambio
            var anterior = arreglo[1];


            arreglo[1] = arreglo[0];
            arreglo[0] = anterior;


            Console.WriteLine("Arreglo invertido.");
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Console.Write(this.arreglo[i][x] + " ");
                }
                Console.WriteLine("");
            }
        }

    }
}

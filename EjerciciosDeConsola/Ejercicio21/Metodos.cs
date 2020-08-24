using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio21
{
    class Metodos
    {
        public string[][] matris { get; set; }
        public Metodos()
        {
            matris = new string[5][];
           
            for(int i=0; i < 5; i++)
            {
                matris[i] = new string[i+1];
            }
        }
       
        public void llenarMatris()
        {
            int cont = 1;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Fila numero: {i + 1} ");
                for(int x=0; x < cont; x++)
                {
                    Console.WriteLine($"columna numero: {x + 1} ");
                    matris[i][x] = Console.ReadLine();
                }
                cont++;
            }
        }

        public void MostrarMatris()
        {
            int cont = 1;
            Console.WriteLine("Estructura de la matris");
            for (int i = 0; i < 5; i++)
            {
               
                for (int x = 0; x < cont; x++)
                {
                    Console.Write($"{matris[i][x]} ");                  
                }
                Console.WriteLine(" ");
                cont++;
            }
        }
    }
}

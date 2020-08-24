using Ejercicio20.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio20
{
    class Metodos
    {

         public void ImprimirPaises(List<Paises> lista)
        {
            Console.WriteLine("Lista de paises");
            foreach (var item in lista)
            { var tempMedia = (item.Temperatura1 + item.Temperatura2 + item.Temperatura3) / 3;
                Console.Write($"Nombre: {item.Nombre} , Temp1: {item.Temperatura1}, Temp2: {item.Temperatura2}, Temp3: {item.Temperatura3}, Temperatura media: {tempMedia} ");
                Console.WriteLine("");
            }

            Console.WriteLine($"El pais con la temperatura mas alta es: {PaisConTempMayor(lista)}");
        }

        public string PaisConTempMayor(List<Paises> lista)
        {
            int cantidadMax = 0;
            int cantidadActual = 0;
            string pais ="";
            foreach(var item in lista)
            {

                cantidadMax = Math.Max(item.Temperatura1, Math.Max(item.Temperatura2, item.Temperatura3));
                if (cantidadActual < cantidadMax) { cantidadActual = cantidadMax; pais = item.Nombre; }
            }
            return pais;
        }
    }
}

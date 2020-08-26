using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosWeb.Ejercicios
{
    public class Ejercicio
    {
     
        public string Practica1(int x, int y)
        {
                int result, resto;
                result = x / y;
                resto = x % y;
              
            return $"La divicion es {result} y el resto es {resto}";      
        }

        public string Practica2(int x, int y)
        {
            int resto = 0;

            resto = x % y;
            if (resto == 0) { return $"{x} es multiplo de {y}"; } else {
                return $"{x} no es multiplo de {y}";
            }  
        }

        public string Practica3(int numero1, int numero2)
        {
            if (numero1 == 0) { return "El producto de un numero multiplicado por cero es cero."; } else {
                return $"El producto es {numero1 * numero2}";
            }
        }

        public string Practica4(int numero1, int numero2)
        {
            if(numero2 == 0) { return "No se puede dividir entre cero"; } else
            {
                return $"La division es: {numero1 / numero2}";
            }
        }

        public string Practica5(string letra)
        {
            char caracter = 'a';
            if (!char.TryParse(letra, out caracter)) { return "No es una sola letra"; }
            caracter = char.Parse(letra);
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                return"Es una vocal";
            }
            else
            {
               return "No es una vocal";
             
            }
        }

        public string Practica6(int numero1,int numero2)
        {
           string respuesta = "";
            if(numero1>=0 && numero2 >= 0)
            {
                respuesta = "Los dos numero son positivos";
            }else if (numero1 < 0 && numero2 < 0)
            {
                respuesta = "Ninguno de los numeros es positivo";
            }else if (numero1 > 0 && numero2 < 0)
            {
                respuesta = "Uno de los numeros es positivo";
            }else if(numero1 < 0 && numero2 > 0){
                respuesta = "Uno de los numeros es positivo";
            }
            return respuesta;
        }

        public string Practica7(int numero)
        {
            if(numero < 0) { numero = Math.Abs(numero); }
            return $"El valor absoluto es: {numero}";
        }

        public int[] Practica8()
        {
            int contador = 0;
            int[] arreglo = new int[10];
            while (contador<10)
            {
                arreglo[contador] = contador + 1;
                contador++;
            }
            return arreglo;
        }
        
        public int[] Practica9()
        {
            int contador = 0;
            int numero = 26;
            int[] arreglo = new int[9];
            while (numero !=8)
            {
                arreglo[contador] = numero;
                numero -= 2;
                contador++;
            }
            return arreglo;
        }

        public int[] Practica10()
        {
            int[] arreglo = new int[10];
            int contador = 0;
            do {
                arreglo[contador] = contador + 1;
                contador++;
            } while (contador<10);

            return arreglo;
        }

        public int[] Practica11()
        {
            int contador = 0;
            int numero = 26;
            int[] arreglo = new int[9];

            do
            {
                arreglo[contador] = numero;
                numero -= 2;
                contador++;
            } while (numero !=8);
            return arreglo;
        }

        public int[] Practica12()
        {
            int numero = 15;
            int contador = 0;
            int[] arreglo = new int[11];
            while (contador <= 10)
            {
                arreglo[contador] = numero;
                numero--;
                contador++;
            }

            return arreglo;
        }

        public int[] Practica13()
        {
            int numero = 0;
            int[] arreglo = new int[8];
            for(int i = 0; i < 8; i++)
            {
                numero += 2;
                arreglo[i] = numero;
            }
            return arreglo;
        }

        public List<int> Practica14()
        {
            List<int> arreglo = new List<int>();
            for(int x = 0; x < 50; x++)
            {
                if (x % 3 == 0)
                {
                    arreglo.Add(x);
                }              
            }
            return arreglo;
        }

        public string Practica15(int[] arreglo)
        {
            int menor = arreglo[0];          
            int SeRepite = 0;

            foreach (var item in arreglo)
            {
                if (item < menor) { menor = item; }
            }
            foreach (var item in arreglo) { if (item == menor) { SeRepite++; } }

            string mensaje = $"El numero menor es {menor} y se repite {SeRepite} veces";

            return mensaje;
        }

        public int[] Practica16()
        {
            int[] arreglo = new int[5] {12000,15000,25000,35000,42220 };
            Array.Sort(arreglo);
            return arreglo;
        }

        public string[] Practica17()
        {
            string[] arreglo = new string[5] { "Dominicana","Peru","Argentina","Venezuela","Brasil"};
            Array.Sort(arreglo);

            return arreglo;
        }
    }
}

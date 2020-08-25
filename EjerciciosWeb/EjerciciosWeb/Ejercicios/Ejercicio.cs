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
          
    }
}

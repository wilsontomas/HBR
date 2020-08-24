using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosWeb.Ejercicios
{
    public class Ejercicio1
    {
      
      

        public string PrimerEjercicio(int x, int y)
        {
                int result, resto;
                result = x / y;
                resto = x % y;
              
            return $"La divicion es {result} y el resto es {resto}";      
        }
          
    }
}

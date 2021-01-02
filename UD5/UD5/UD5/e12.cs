using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
        /*Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y
        sacar la media.*/
    class e12
    {
        
        public void exe12()
        {

            int[] num = new int[10];
            int suma = 0;
            double media = 0;
            for (int i = 0; i < num.Length; i++)

            {
                num[i] = i + 1;
                suma += num[i];
                
            }
            media = suma / num.Length;
            Console.WriteLine("La suma de todas las posiciones otorgan un total de {0}", media);
        }
    }
}

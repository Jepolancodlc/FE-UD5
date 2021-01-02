using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class e11
    { /* Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y
sacar la suma total.*/
        public void exe11()
        {

            int[] num = new int[10];
            int suma = 0;

            for (int i = 0; i < num.Length; i++)

            {
                num[i] = i + 1;
                suma += num[i];
            }

            Console.WriteLine("La suma de todas las posiciones otorgan un total de {0}", suma);
        }
    }
}

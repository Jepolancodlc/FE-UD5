using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    /* Crear un array de números con la longitud que quieras e introducir en cada
     el valor su posición. Muestra el contenido.*/
    class e8
    {

        public void exe8()
        {
            int[] n = new int[10];

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = i + 1;
                Console.WriteLine("Posicion {0} = {1}",i, n[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    /*Crear un array de numeros con la longitud que quieras y pedir al usuario que en
     elemento inserte un numero. Muestra el contenido. */

    class e9

    {
        int[] n = new int[6];
        public void exe9()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Intrdozuca el numero que ocupara la posicion {0}", i);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n.Length; i++)
            {
               Console.WriteLine(n[i]);
            }

 
        }
    }
}

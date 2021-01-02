using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{  
    /*Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra
    por consola el índice y el valor al que corresponde.Haz dos métodos, uno para rellenar
    valores y otro para mostrar.*/

    class e17
    {
        int[] n = new int[10];

        public void exe17()
        {
            llenarArray();
            mostrarArray();
            
        }

        void llenarArray()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Intrdozuca el numero que ocupara la posicion {0}", i);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        void mostrarArray()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

        }

    }
}

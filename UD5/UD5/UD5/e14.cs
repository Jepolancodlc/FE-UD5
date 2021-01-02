using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UD5
{   /* Dado el anterior array, pedir al usuario un numero e indicarle si existe en el array*/
    class e14
    { 
        

        public void exe14()
        {
            Console.WriteLine("Introduzca el tamañodel array: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < num.Length; i++)

            {
                num[i] = rnd.Next(1,10);
             
            }
            Console.WriteLine("Introduzca el numero para comprobar si existe en el array:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (num.Contains(y))
            {
                Console.WriteLine("El array SI contiene el numero {0}", y);
            }
            else
            {
                Console.WriteLine("El array NO contiene el numero {0}", y);
            }
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{   /*Rellenar un array de longitud pedida por el usuario con números aleatorios
        entre 1 y 10 */
    class e13
    { 
        

        public void exe13()
        {
            Console.WriteLine("Introduzca el tamañodel array: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < num.Length; i++)

            {
                num[i] = rnd.Next(1,10);
             
            }
         
        }
    }
}

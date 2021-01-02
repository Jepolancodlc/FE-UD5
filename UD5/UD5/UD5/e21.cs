using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    /*Crea un array de números de un tamaño pasado por teclado, el array contendrá
números aleatorios entre 1 y 300 y mostrar aquellos números que acaben en un dígito que
nosotros le indiquemos por teclado (debes controlar que se introduce un numero correcto),
estos deben guardarse en un nuevo array.
Por ejemplo, en un array de 10 posiciones e indicamos mostrar los números acabados en 5,
podría salir 155, 25, etc.*/
    class e21
    {
        int[] array1;
        int[] array2;
        int dig=0;
        int lastdigit;

        public void exe21()
        {

            Console.Write("Indique el tamaño del array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique el utlimo digito");
            dig = Convert.ToInt32(Console.ReadLine());
            array1 = new int[num];
            rellenar(1,300);
            mostrar();
            ;
        }

        int rellenar(int a, int z) //Rellena el arrays con numeros aleatorios
        {
            bool p = false;
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                p = false;
                while (!p)
                {
                    array1[i] = rnd.Next(a, z);
                    p = esPrimo(array1[i]);
                }
            }
            return a;
        }


        bool esPrimo(int num) 
        {

            lastdigit = Math.Abs(dig) % 10;

            if (dig == lastdigit)
            {
                 return false;
            }
            else
            {
                return true;
            }
            
        }
        void mostrar()
        {

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }
        }
        }
}

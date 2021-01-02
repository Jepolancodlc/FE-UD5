using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{   /*Crea dos arrays de números con una posición pasado por teclado.
    Uno de ellos estará rellenado con números aleatorios y el otro apuntara al array anterior,
    después crea un nuevo array con el primer array (usa de nuevo new con el primer array) con
    el mismo tamaño que se ha pasado por teclado, rellenalo de nuevo con números aleatorios.
    Después, crea un método que tenga como parámetros, los dos arrays y devuelva uno nuevo
    con la multiplicación de la posición 0 del array1 con el del array2 y así sucesivamente. Por
    último, muestra el contenido de cada array.*/

    class e20
    {
        int[] arra1;
        int[] arra2;
        int[] arra3;
        public void exe20()
        {
            Console.Write("Indique el tamaño del array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            arra1 = new int[num];
            llenarArray1(1, 100);
            arra2 = arra1;
            arra1 = new int[num];
            llenarArray1(1, 100);
            arra3 = Mult(arra1, arra2);
            mostrarArray();

        }

        int llenarArray1(int a, int b) 
        {
            Random rnd = new Random();
            for (int i = 0; i < arra1.Length; i++)
            {
                arra1[i] = rnd.Next(a, b);
            }

            return a;
        }
        int[] Mult(int[] a, int[] b)
        {
            Random rnd = new Random();
            arra3 = new int[arra1.Length];
            for (int i = 0; i < arra1.Length; i++)
            {
                arra3[i] = arra1[i] * arra2[i];
            }
            return arra3;
        }

        void mostrarArray()
        {
            Console.WriteLine("Array 1");
            for (int i = 0; i < arra1.Length; i++)
            {
                Console.Write("|"+arra1[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Array 2");
            for (int i = 0; i < arra2.Length; i++)
            {
                Console.Write("|"+arra2[i]);
            }
            Console.WriteLine(""); 
            Console.WriteLine("Array 3");
            for (int i = 0; i < arra3.Length; i++)
            {
                Console.Write("|"+arra3[i]);
            }
        }
    }
}

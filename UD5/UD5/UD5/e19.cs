using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UD5
{ 
    /*Crea un array de números de un tamaño pasado por teclado, el array contendrá
    números aleatorios primos entre los números deseados, por último nos indicar cual es el
    mayor de todos.
    Haz un método para comprobar que el número aleatorio es primo, puedes hacer todos lo
    métodos que necesites.*/
    class e19
    {
        int[] array; 
        public void exe19()
        {

            Console.Write("Indique el tamaño del array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIndique el min del rango: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIndique el numero max del rango: ");
            int max = Convert.ToInt32(Console.ReadLine());
            array = new int[num];
            rellenar(min, max);
            mostrar();
        }


        int rellenar(int a, int z) //Rellena el arrays con numeros aleatorios
        {
            bool p = false;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                p = false;
                while (!p)
                {
                    array[i] = rnd.Next(a, z);
                    p = esPrimo(array[i]);
                }
            }
                return a;
        }

       
        bool esPrimo(int num) //Metodo que indica si el numero es Primo
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        void mostrar()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

        int maxValue = array.Max();
        Console.WriteLine("\nEl valor max del array es: {0}", maxValue);
        }
    }
}


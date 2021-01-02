using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{  
    /*Crea un array de números donde le indicamos por teclado el tamaño del array,
    rellenaremos el array con números aleatorios entre 0 y 9, al final muestra por pantalla el
    valor de cada posición y la suma de todos los valores. Haz un método para rellenar el array
    (que tenga como parámetros los números entre los que tenga que generar), para mostrar el
    contenido y la suma del array y un método privado para generar número aleatorio */
    class e18
    {
        int[] array;
        public void exe18()
        {
            Console.Write("Indique el tamaño del array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            array = new int[num];
            llenarArray(0, 9);
            mostrarsumarArray();
        }

         int llenarArray(int a, int b) //LLena el array con numeros aleatorios, Allin
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(a, b);
            }

            return a;
        }
        void mostrarsumarArray()
        {
            int suma = 0;
            //Suma contendio del array
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            //Muestra 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine("\nLa suma total del array es: {0}", suma);
        }

    }
}

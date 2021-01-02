using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{    /*Crea una aplicación de consola que nos genere una cantidad de números enteros
    aleatorios que nosotros le pasaremos por teclado. Crea un método donde pasamos como
    parámetros entre que números queremos que los genere, podemos pedirlas por teclado
    antes de generar los números. Este método devolverá un número entero aleatorio. Muestra
    estos números por pantalla.*/

    public class e2

    {
        int num1, num2;

        public void exe2()
        {
            int[] numeros = new int[CantidadNum()];

            Console.WriteLine("Numero de inicio del rango");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de fin del rango");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Imprime por consola
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = RandomNum();
                Console.Write(" | "+numeros[i]);
            }
        }

        //Genera la cantidad de numeros
        public int CantidadNum()   
        {
            Console.WriteLine("Cuantos numeros quiere generar");
            int cantNum = Convert.ToInt32(Console.ReadLine());
            return cantNum;
        }

        //Genera los numeros aleatorios y el rango de estos
        public int RandomNum()
        {
            Random rnd = new Random();
            int nRand = rnd.Next(num1, num2);
            return nRand;

        }

    }
}

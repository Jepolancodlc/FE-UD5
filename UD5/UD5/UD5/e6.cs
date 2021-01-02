using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    /*Crea una aplicación de consola que nos cuente el número de cifras de un número entero
    positivo (hay que controlarlo) pedido por teclado. Crea un método que realice esta acción,
    pasando el número por parámetro, devolverá el número de cifras.*/
    class e6
    {
        int num=0;
        string numToString;

        public void exe6 ()
          
        {
            Console.WriteLine("Introduzca un numero:");
            num = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Se utiliza el Math.Abs para controlar valores negativos
            numToString = Convert.ToString(num);
            contar(num);
            Console.WriteLine("El numero de cifras de {0} es {1}", num, contar(num));
        }
        
        public int contar(int i)
        {
            i = 0;
            while (i < numToString.Length)
            {
                i++;
            }
            return i;
        }
    }
}

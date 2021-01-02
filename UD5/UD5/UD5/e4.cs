using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{  
    /*Crea una aplicación de consola que nos calcule el factorial de un número pedido por
    teclado, lo realizara mediante un método al que le pasamos el número como parámetro.
    Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno.Por
    ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.*/

    class e4
    {
        int factorial = 1;

        public void exe4()
        {
            Console.WriteLine("Introduzca un numero para calcular el factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            a(num);
            Console.WriteLine("El factorial de {0} es {1}",num,factorial);
        }
        
        int a(int n)
        {
            for (; n != 0; n--)
            {
                factorial = factorial * n;
            }
            return n;
        }
       
    }
}

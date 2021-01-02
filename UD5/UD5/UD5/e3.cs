using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{       
    /*Crea una aplicación de consola que nos pida un número por teclado y con un método se
        lo pasamos por parámetro para que nos indique si es o no un número primo, debe devolver
        true si es primo sino false.
        Un número primo es aquel solo puede dividirse entre 1 y si mismo. Por ejemplo: 25 no es
        primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.*/
    class e3

    {
      
        int num;

        public void exe3()
        {
            Console.Write("Escriba un numero para saber si es primo: ");
            num = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine( a());
        }

        bool a()
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

        
    }
}

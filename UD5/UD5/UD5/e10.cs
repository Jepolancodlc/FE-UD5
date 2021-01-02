using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{ 
    /* Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y
sacar la suma total.*/
    class e10
    {
        public void exe10()
        {
            Console.WriteLine("Introduce un numero para multiplicara");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                int result = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, result);
            }
        }
    }
}

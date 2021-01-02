using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{   
    /*Crea una aplicación de consola que nos convierta un número en base decimal a binario.
    Esto lo realizara un método al que le pasaremos el numero como parámetro, devolverá un
    String con el numero convertido a binario. Para convertir un numero decimal a binario,
    debemos dividir entre 2 el numero y el resultado de esa división se divide entre 2 de nuevo
    hasta que no se pueda dividir mas, el resto que obtengamos de cada división formara el
    numero binario, de abajo a arriba*/

    class e5
    {
        public void exe5()
        {
            Console.WriteLine("Introduzca un numero para convertir a binario:");
            int num = Convert.ToInt32(Console.ReadLine());
            string binario = Convert.ToString(num, 2).PadLeft(8,'0');
            Console.WriteLine(binario);
        }
    }
}

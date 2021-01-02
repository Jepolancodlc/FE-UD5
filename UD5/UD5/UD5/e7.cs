using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    /* Crea un aplicación de consola que nos convierta una cantidad de euros introducida por
    teclado a otra moneda, estas pueden ser a dolares, yenes o libras.El método tendrá como
    parámetros, la cantidad de euros y la moneda a pasar que sera una cadena, este no
    devolverá ningún valor, mostrara un mensaje indicando el cambio (void).*/
    class e7
    { 
        public void exe7(double cantidad, string moneda)
        {
            Console.WriteLine("Introduzca la cantidad a cambiar:");
             cantidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A que divisa quiere cambiar: \n[libra] [yen] [dolar]");
             moneda = Console.ReadLine().ToLower();

            switch (moneda)
            {
                case "yen":
                    cantidad = cantidad * 129.852;
                    Console.WriteLine("Cambio completo, el total es {0}Y", cantidad);
                    break;
                case "libra":
                    cantidad = cantidad * 0.86;
                    Console.WriteLine("Cambio completo, el total es {0}l", cantidad);
                    break;
                case "dolar":
                    cantidad = cantidad * 1.28611;
                    Console.WriteLine("Cambio completo, el total es {0}$", cantidad);
                    break;
                default:
                    break;
            }
        }
    }
}

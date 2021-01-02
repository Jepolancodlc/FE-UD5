using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{       /*1) Crea una aplicación de consola que nos calcule el área de un circulo, cuadrado o
        triangulo.Pediremos que figura queremos calcular su área y según lo introducido pedirá los
        valores necesarios para calcular el área.Crea un método por cada figura para calcular cada 
        área, este devolverá un número real.Muestra el resultado por pantalla.*/

    class e1
    {
        double total = 0;
        public void exe1()

        {
           
            Console.WriteLine("De que figura desea saber el area? \n [circulo] [triangulo] [cuadrado]");
            string figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "triangulo": triangulo(0,0); Console.WriteLine("El area del triangulo es de {0}", total);
                    break;
                case "cuadrado":
                    cuadrado(0,0); Console.WriteLine("El area del cuadrado es de {0}", total);
                    break;
                case "circulo":
                    circulo(0); Console.WriteLine("El area del circulo es de {0}", total);
                    break;
                default:
                    break;
            }
        }
        
        private double circulo(double radio)
        {
            Console.WriteLine("Introduzca el radio:");
            radio= Convert.ToDouble(Console.ReadLine());
            total= Math.Pow(radio, 2) * Math.PI;
            return total;
        
        }

        private double triangulo(double b, double a)
        {
            Console.WriteLine("Introduzca la base del triangulo:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la altura del triangulo:");
            a = Convert.ToDouble(Console.ReadLine());
            total = (a*b)/2;
            return total;
        }

        private double cuadrado(double b, double a)
        {
            Console.WriteLine("Introduzca el lado 1 del cuadrado:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el lado 2 del cuadrado:");
            a = Convert.ToDouble(Console.ReadLine());
            total = a * b;
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UD5
{
    //Indicar si un array de números es capicua.Es capicua cuando coincide el
    //primero y el ultimo elemento, el segundo y el penúltimo y así sucesivamente
    class e16
    {
        public void exe16()
        {
            int[] a = { 1, 4, 6, 6, 1 };
            int[] b = a.Reverse().ToArray(); 
            string aST = string.Join("", a);
            string bST = string.Join("", b);


            if (aST == bST)
            {
                Console.WriteLine("CAPICÚA!!!!");
            }
            else
            {
                Console.WriteLine("Me temo que no es capicua :C");
            }
        }
    }
}
   
    

 

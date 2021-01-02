using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UD5
{ //) Invertir los valores de un array y meterlos en otro array.
    class e15
    {
        public void exe15()
        {
            int[] a= { 1, 2, 3, };
            int[] b = a.Reverse().ToArray();

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("Array A= {0} |", a[i]);
                Console.WriteLine(" Array B= {0}", b[i]);
            }
        }
    }
}

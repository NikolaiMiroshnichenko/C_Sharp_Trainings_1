using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task's code is:
             
            int a = 1;
            int b = 256;
            byte c = (byte)(a + b);

            Console.WriteLine(c);*/

            int a = 1;
            int b = 256;
            var c = (a + b);

            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}

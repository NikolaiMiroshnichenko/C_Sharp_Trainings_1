using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 1;
            Console.WriteLine(a++); 
            TASK: change output 1 -> 2
             */

            int a = 1;
            Console.WriteLine(++a);

            /*int a = 1;
            int b = 2;
            Console.WriteLine(++a * b++);
            TASK: change output 4 -> 6
            some value names changed for place in one project with task 43
            */

            int aa = 1;
            int b = 2;
            Console.WriteLine(++aa * ++b);

            /* int b = 5 / 2;
             Console.WriteLine(b);
             TASK: change output 2 -> 2,5
             some value names changed for place in one project with task 43
             */

            double bb = 5.0/2.0;
            Console.WriteLine(bb);

            Console.ReadKey();

        }
    }
}

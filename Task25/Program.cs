using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Task code is: 

               int a = 5;
               object obj = a;
               a++;
               Console.WriteLine(obj);*/


            int a = 5;
            a++;
            object obj = a;
            Console.WriteLine(obj);

            Console.ReadKey();

        }
    }
}

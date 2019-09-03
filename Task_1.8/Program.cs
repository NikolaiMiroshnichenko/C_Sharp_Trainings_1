using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float f = float.Parse(Console.ReadLine());
                Console.WriteLine("float is " + f);
            }
            catch (FormatException e)
            {
            }




            Console.ReadKey();
        }
    }
}

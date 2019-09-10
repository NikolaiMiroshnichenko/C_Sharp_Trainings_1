using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            try
            {
                int Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Age is " + Age);
            }
            catch (FormatException e)
            {
            }
            
            Console.ReadKey();
            float number = 1.3f;
        }
    }
}

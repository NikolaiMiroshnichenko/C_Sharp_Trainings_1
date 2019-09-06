using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            Console.WriteLine("Input 3 numbers");

            for (int i = 0; i < 5; i++)
            {

                Console.Write("element - {0} : ", i);
                if (int.TryParse(Console.ReadLine(), out nums[i]))
                {
                }
                else
                {
                    Console.WriteLine("Wrong input element № " + i);
                    i--;
                }
            }

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + nums[i];
            }
            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();
        }
    }
}

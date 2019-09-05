using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            Console.WriteLine("Input 3 numbers");
            int i;
            int temp;
            for (i = 0; i < 5; i++)
            {

                try

                {
                    Console.Write("element - {0} : ", i);
                    nums[i] = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Wrong input element № " + i);
                    i--;
                }

            }

            Console.WriteLine("Unsorted nums");
            foreach (int n in nums)

            {
                Console.WriteLine(n);
            }
            
            for (int j = 0; j < nums.Length ; j++)
            {
                for (int h = 0; h < nums.Length - 1; h++)
                {
                    if (nums[h] > nums[h + 1])
                    {
                        temp = nums[h + 1];
                        nums[h + 1] = nums[h];
                        nums[h] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted nums");

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}

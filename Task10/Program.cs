using System;

namespace Task_1._10
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] nums = new int[3];

            Console.WriteLine("Input 3 numbers");
            int i;
            for (i = 0; i < 3; i++)
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
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(nums);
            Console.WriteLine("Reversed Array : ");
            foreach (int v in nums)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }

}

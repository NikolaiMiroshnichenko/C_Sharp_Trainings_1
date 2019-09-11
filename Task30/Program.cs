using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = { 1, 2, 3, 4 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
             }              */
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                
            }

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}


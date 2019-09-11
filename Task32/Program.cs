using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            numbers[0] = 1;
            numbers[1] =34;
            numbers[2] = 2;
            numbers[3] = 56;
            numbers[4] = 9;
            numbers[5] = 13;
            numbers[6] = 22;
            numbers[7] = 31;
            numbers[8] = 45;
            numbers[9] = 58;

            int even=0;
            int uneven=0;

            foreach(int i in numbers)
            {
                if((i%2) == 0)
                {
                    even++;
                }
            }
            foreach (int i in numbers)
            {
                if ((i % 2) == 1)
                {
                    uneven++;
                }
            }
            Console.WriteLine(even);
            Console.WriteLine(uneven);
            Console.ReadKey();
        }
    }
}

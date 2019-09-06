using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " element is: ");
                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                }
                else
                {
                    Console.WriteLine("Wrong input element № " + i);
                    i--;
                }
            }

            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            int mathMiddle = sum / arr.Length;
            Console.WriteLine(sum);

            Console.WriteLine("Arithmetic average is: " + mathMiddle);

            Console.ReadKey();
        }
    }
}

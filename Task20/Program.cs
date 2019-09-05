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
            int i;
            int sum = 0;
            int mathMiddle;
            for (i = 0; i < 5; i++)
            {
                Console.Write(i + " element is: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

            for (i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            mathMiddle = sum / arr.Length;
            Console.WriteLine(sum);

            Console.WriteLine("Arithmetic average is: " + mathMiddle);

            Console.ReadKey();
        }
    }
}

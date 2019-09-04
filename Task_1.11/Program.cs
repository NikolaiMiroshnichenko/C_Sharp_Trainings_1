using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int i;
            for (i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine(arr[k]);
            }

            Console.ReadKey();
        }
    }
}

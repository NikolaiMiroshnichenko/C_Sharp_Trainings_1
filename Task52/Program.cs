using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            try
            {
                array[5] = 3;
            }
            catch
            {
                Console.WriteLine("IndexOutOfRangeException was catched");
                Console.ReadKey();
            }
        }
    }
}

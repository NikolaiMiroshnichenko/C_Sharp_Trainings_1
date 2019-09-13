using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter numbers for Square root");

            int.TryParse(Console.ReadLine(), out int z);
            squareRoot(z, out double sqr);
            Console.WriteLine("result of divide is: " + sqr);

            Console.ReadKey();
        }
        static void squareRoot(int z, out double sqr)
        {
            sqr = Math.Round(Math.Sqrt(z),3);
            
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        enum AlienRace : int
        {
            Sektoid = 1,
            Sektopod,
            Etherial,
            Floater,
            Muton
        }
                static void Main(string[] args)
        {
            Console.WriteLine("Enter number of xenos race (1-5)");

            int.TryParse(Console.ReadLine(), out int n);

            if ((n > 0) & n < 6)
            {
                AlienRace alr = (AlienRace)n;
                Console.WriteLine(alr);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            Console.ReadKey();

        }

    }
}

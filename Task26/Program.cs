using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
{
    class Program
    {
        enum DayOfWeek : int
        {
            Mondey  = 1,
            Thuesday,
            Wendsday,
            Thursday,
            Friday,
            Saturday,
            SUnday
        }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DayOfWeek.Friday);

            int.TryParse(Console.ReadLine(), out  int numberOfDays);
            if (Enum.IsDefined(typeof(DayOfWeek), numberOfDays))
            {
                DayOfWeek enm = (DayOfWeek)numberOfDays;
                Console.WriteLine(enm);
            }
            else Console.WriteLine("Wrong number of day");


            Console.ReadKey();
        }
    }
}


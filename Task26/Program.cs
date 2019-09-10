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
            Mondey,
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
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task55
{
    class Program
    {
        struct Vector1
        {
            public float x;
        }

        static void vectorCalculate(float point1, float point2, out float distance)
        {
            distance = point1 - point2;
        }

        static void Main(string[] args)
        {
            Vector1 point1 = new Vector1();
            point1.x = 1.5f;
            Vector1 point2 = new Vector1();
            point2.x = 3.2f;
            List<Vector1> list = new List<Vector1>();
            for (int i=0; i<100001; i++)
            {
                list.Add(point1);
            }
            vectorCalculate(point1.x, point2.x, out float distance);

            Console.WriteLine(distance);

            Console.ReadKey();
        }
    }
}

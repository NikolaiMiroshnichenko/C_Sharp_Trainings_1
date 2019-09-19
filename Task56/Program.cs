using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task56
{
    class Program
    {
        struct Vector2
        {
            public float X;
            public float Y;
            
        }
        static void calculateVector(float point1coordinateX, float point1coordinateY, float point2coordinateX, float point2coordinateY, out float distanceX, out float distanceY)
        {
            distanceX = point1coordinateX - point2coordinateX;
            distanceY = point1coordinateY - point2coordinateY;
        }

        static void Main(string[] args)
        {
            Vector2 point1 = new Vector2 { X = 1.1f, Y = 1.1f };
            Vector2 point2 = new Vector2 { X = 2.4f, Y = 2.4f };
            calculateVector(point1.X, point1.Y, point2.X, point2.Y, out float dX, out float dY)
;          Console.WriteLine($"{dX} {dY}");

            Console.ReadKey();
        }
    }
}

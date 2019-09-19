using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task58
{
    class Program
    {
        struct Vector3
        {
            public float X;
            public float Y;
            public float Z;
        }

        static void calculateDistance(float x1, float y1, float z1, float x2, float y2, float z2, out float dX, out float dY, out float dZ)
        {
            dX = x2 - x1;
            dY = y2 - y1;
            dZ = z2 - z1;
        }
        static void Main(string[] args)
        {
            Vector3 point1 = new Vector3 { X = 1.1f, Y = 1.1f, Z = 1.1f };
            Vector3 point2 = new Vector3 { X = 2.4f, Y = 2.4f, Z = 2.4f };
            calculateDistance(point1.X, point1.Y, point1.Z, point2.X, point2.Y, point2.Z, out float dX, out float dY, out float dZ);

            Console.WriteLine($"{dX} {dY} {dZ}");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task61
{

    class Program
    {
        class Vector1
        {
            public float x { get; set; }
            public Vector1(float x)
            {
                this.x = x;
            }
        }
        struct Vector2
        {
            public float x { get; set; }
            public float y { get; set; }
            public Vector2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Vector3
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        static void calculateVector1(float x1, float x2, out float d1)
        {
            d1 = x2 - x1;
        }
        static void calculateVector2(float x1, float x2, float y1, float y2, out float d1, out float d2)
        {
            d1 = x2 - x1;
            d2 = y2 - y1;
        }
        static void calculateVector3(float x1, float x2, float y1, float y2, float z1, float z2, out float dX, out float dY, out float dZ)
        {
            dX = x2 - x1;
            dY = y2 - y1;
            dZ = z2 - z1;
        }
        static void Main(string[] args)
        {
            Vector1 vector1_1 = new Vector1(1.1f);
            Vector1 vector1_2 = new Vector1(3.5f);
            calculateVector1(vector1_2.x, vector1_1.x, out float res1_X);

            List<Vector1> list = new List<Vector1>();
            for (int i = 0; i < 100001; i++)
            {
                list.Add(vector1_1);
            }
            list = null;
            Console.ReadLine();
           
            Vector2 vector2_1 = new Vector2(1.1f, 1.1f);
            Vector2 vector2_2 = new Vector2(2.7f, 2.7f);
            calculateVector2(vector2_1.x, vector2_2.x, vector2_1.y, vector2_2.y, out float res1_x, out float res2_y);


            Vector3 vector3_1 = new Vector3(1.1f, 1.1f, 1.1f);
            Vector3 vector3_2 = new Vector3(2.4f, 2.4f, 2.4f);
            calculateVector3(vector3_1.x, vector3_2.x, vector3_1.y, vector3_2.y, vector3_1.z, vector3_2.z, out float res3_X, out float res3_Y, out float res3_Z);

            Console.WriteLine($"{res3_X}, {res3_Y}, {res3_Z}");

            Console.ReadKey();
        }
    }
}

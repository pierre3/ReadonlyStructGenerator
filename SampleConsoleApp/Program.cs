using System;
using System.Collections.Generic;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(100, 200);
            var p2 = new Point() { X = 22, Y = 33 };
            Console.WriteLine($"p1= {p1}");
            Console.WriteLine($"p2= {p2}");
            Console.WriteLine($"----");
            var c1 = new Color(64, 128, 80, 255);
            var c2 = new Color(c1.A, c1.B, c1.G, c1.R);
            var c3 = new Color(c2.R, c2.G, c2.B, c2.A);
            Console.WriteLine($"c1= {c1}");
            Console.WriteLine($"c2= {c2}");
            Console.WriteLine($"(c1 == c2) = {c1 == c2}");
            Console.WriteLine($"(c2 == c3) = {c2 == c3}");
            Console.WriteLine($"c1.GetHashCode() = {c1.GetHashCode()}");
            Console.WriteLine($"c2.GetHashCode() = {c2.GetHashCode()}");
            Console.WriteLine($"c3.GetHashCode() = {c3.GetHashCode()}");
            Console.WriteLine($"----");
            var v1 = new Vector3(234.5f, 111.2f, 345.6f);
            Console.WriteLine($"v1= {v1}");
            Console.WriteLine($"v1.Norm= {v1.Norm}");


            Console.WriteLine($"Press any key.");
            Console.Read();
        }
    }

    [ReadonlyStructGenerator.ReadonlyStruct]
    public partial struct Point
    {
        public System.Int32 X { get; init; }
        public System.Int32 Y { get; init; }
    }

    [ReadonlyStructGenerator.ReadonlyStruct]
    public partial struct Color
    {
        public byte R { get; init; }
        public byte G { get; init; }
        public byte B { get; init; }
        public byte A { get; init; }

    }

    [ReadonlyStructGenerator.ReadonlyStruct]
    public partial struct Vector3
    {
        public float X { get; init; }
        public float Y { get; init; }
        public float Z { get; init; }

        public float Norm { get; }

        public Vector3(float x, float y, float z)
        {
            (X, Y, Z) = (x, y, z);
            Norm = (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }
}

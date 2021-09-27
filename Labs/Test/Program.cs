using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double I = 10;
            double I2 = 15;
            Point point1 = new Point { X= 6, Y =2 };

            Point point2 = new Point { X = 2, Y = 6 };

            double range = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            Console.WriteLine(range);
        }
    }

    public struct Point
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}

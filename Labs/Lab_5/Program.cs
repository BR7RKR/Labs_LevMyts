using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберети задание 5 лабораторной работы (1-5)");
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер пять || задание один");


                    Console.Write("...\n...\n...\n...\n");


                    Console.WriteLine("Введите координаты первой точки: ");

                    Console.Write("X - ");
                    bool isX1 = double.TryParse(Console.ReadLine(), out double x1);
                    Console.Write("Y - ");
                    bool isY1 = double.TryParse(Console.ReadLine(), out double y1);


                    Console.WriteLine(" ");


                    Console.WriteLine("Введите координаты второй точки: ");

                    Console.Write("X - ");
                    bool isX2 = double.TryParse(Console.ReadLine(), out double x2);
                    Console.Write("Y - ");
                    bool isY2 = double.TryParse(Console.ReadLine(), out double y2);


                    if (isX1 == false || isY1 == false || isX2 == false || isY2 == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }


                    Point point1 = new Point { X = x1, Y = y1 };
                    Point point2 = new Point { X = x2, Y = y2 };

                    double range = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

                    Console.Write("...\n...\n...\n...\n");
                    Console.WriteLine($"Расстояние между точками = {range}");

                    break;
                default:
                    break;
            }
        }
    }
}

using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите задание 5 лабораторной работы (1-5)");
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторная работа номер пять || задание один");


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

                case ConsoleKey.D2:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторная работа номер пять || задание два");


                    Console.Write("...\n...\n...\n...\n");


                    Console.WriteLine("Введите координаты первой точки: ");

                    Console.Write("X - ");
                    bool isX1_ = double.TryParse(Console.ReadLine(), out double x1_);
                    Console.Write("Y - ");
                    bool isY1_ = double.TryParse(Console.ReadLine(), out double y1_);


                    Console.WriteLine(" ");


                    Console.WriteLine("Введите координаты второй точки: ");

                    Console.Write("X - ");
                    bool isX2_ = double.TryParse(Console.ReadLine(), out double x2_);
                    Console.Write("Y - ");
                    bool isY2_ = double.TryParse(Console.ReadLine(), out double y2_);


                    Console.WriteLine("Введите координаты третьей точки: ");

                    Console.Write("X - ");
                    bool isX3_ = double.TryParse(Console.ReadLine(), out double x3_);
                    Console.Write("Y - ");
                    bool isY3_ = double.TryParse(Console.ReadLine(), out double y3_);

                    if (isX1_ == false || isY1_ == false || isX2_ == false || isY2_ == false || isX3_ == false || isY3_ == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }


                    Point A = new Point { X = x1_, Y = y1_ };
                    Point B = new Point { X = x2_, Y = y2_ };
                    Point C = new Point { X = x3_, Y = y3_ };

                    double rangeAB = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
                    double rangeAC = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));
                    double sum = rangeAB + rangeAC;

                    Console.Write("...\n...\n...\n...\n");
                    Console.WriteLine($"AB = {rangeAB} || AC = {rangeAC} || Сумма = {sum}");

                    break;

                case ConsoleKey.D3:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторная работа номер пять || задание три");


                    Console.Write("...\n...\n...\n...\n");


                    Console.WriteLine("Введите координату X первой точки: ");

                    Console.Write("X - ");
                    bool isX1__ = double.TryParse(Console.ReadLine(), out double x1__);


                    Console.WriteLine(" ");


                    Console.WriteLine("Введите координату X второй точки: ");

                    Console.Write("X - ");
                    bool isX2__ = double.TryParse(Console.ReadLine(), out double x2__);


                    Console.WriteLine("Введите координату X третьей точки (она должна находиться между первой и второй!): ");


                    Console.Write("X - ");
                    bool isX3__ = double.TryParse(Console.ReadLine(), out double x3__);
                    //Проверяю
                    if (x3__ > x2__ && x3__ < x1__ || x3__ < x2__ && x3__ > x1__)
                    {

                        if (isX1__ == false || isX2__ == false || isX3__ == false)
                        {
                            throw new Exception("WrongNumberFormat");
                        }

                        Point A_ = new Point { X = x1__, Y = 0 };
                        Point B_ = new Point { X = x2__, Y = 0 };
                        Point C_ = new Point { X = x3__, Y = 0 };

                        double rangeAB_ = Math.Sqrt(Math.Pow(A_.X - B_.X, 2) + Math.Pow(A_.Y - B_.Y, 2));
                        double rangeAC_ = Math.Sqrt(Math.Pow(A_.X - C_.X, 2) + Math.Pow(A_.Y - C_.Y, 2));
                        double mult = rangeAB_ * rangeAC_;

                        Console.Write("...\n...\n...\n...\n");
                        Console.WriteLine($"Произведение длин отрезков = {mult}");
                    }
                    else
                    {
                        throw new Exception("WrongDotsPosition");
                    }
                    


                    break;

                default:
                    break;
            }
        }
    }
}

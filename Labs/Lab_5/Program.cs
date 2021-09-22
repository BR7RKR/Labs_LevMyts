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

                    //Проверяю, что формат вводных данных правильный
                    if (isX1 == false || isY1 == false || isX2 == false || isY2 == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    // Создаю новые точки
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
                    //Проверяю, что формат вводных данных правильный
                    if (isX1_ == false || isY1_ == false || isX2_ == false || isY2_ == false || isX3_ == false || isY3_ == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    //Cоздаю новые точки
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
                    //Проверяю, что точка C между A и B
                    if (x3__ > x2__ && x3__ < x1__ || x3__ < x2__ && x3__ > x1__)
                    {
                        //Проверяю, что формат вводных данных правильный
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

                case ConsoleKey.D4:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторная работа номер пять || задание четыре");


                    Console.Write("...\n...\n...\n...\n");


                    Console.WriteLine("Введите координату X вершины, которая не лежит на оси X: ");

                    Console.Write("X - ");
                    bool is_X1 = double.TryParse(Console.ReadLine(), out double x_1);



                    Console.WriteLine(" ");


                    Console.WriteLine("Введите координату Y вершины, которая лежит на оси X: ");

                    Console.Write("Y - ");
                    bool is_Y2 = double.TryParse(Console.ReadLine(), out double y_2);

                    //Проверяю, что формат вводных данных правильный
                    if (is_X1 == false || is_Y2 == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    // Создаю вершины
                    Point point_1 = new Point { X = x_1, Y = 0 };
                    Point point_2 = new Point { X = 0, Y = y_2 };

                    double perimetor = 2 * (x_1 + y_2);
                    double area = x_1 * y_2;

                    Console.Write("...\n...\n...\n...\n");
                    Console.WriteLine($"Площадь = {area} || Периметр = {perimetor}");
                    break;

                case ConsoleKey.D5:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторная работа номер пять || задание пять");


                    Console.Write("...\n...\n...\n...\n");


                    Console.WriteLine("Введите координаты первой вершины: ");

                    Console.Write("X - ");
                    bool is_X1_ = double.TryParse(Console.ReadLine(), out double x_1_);
                    Console.Write("Y - ");
                    bool is_Y1_ = double.TryParse(Console.ReadLine(), out double y_1_);


                    Console.WriteLine(" ");


                    Console.WriteLine("Введите координаты второй вершины: ");

                    Console.Write("X - ");
                    bool is_X2_ = double.TryParse(Console.ReadLine(), out double x_2_);
                    Console.Write("Y - ");
                    bool is_Y2_ = double.TryParse(Console.ReadLine(), out double y_2_);


                    Console.WriteLine("Введите координаты третьей вершины: ");

                    Console.Write("X - ");
                    bool is_X3_ = double.TryParse(Console.ReadLine(), out double x_3_);
                    Console.Write("Y - ");
                    bool is_Y3_ = double.TryParse(Console.ReadLine(), out double y_3_);
                    //Проверяю, что формат вводных данных правильный
                    if (is_X1_ == false || is_Y1_ == false || is_X2_ == false || is_Y2_ == false || is_X3_ == false || is_Y3_ == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    //Cоздаю новые точки
                    Point A__ = new Point { X = x_1_, Y = y_1_ };
                    Point B__ = new Point { X = x_2_, Y = y_2_ };
                    Point C__ = new Point { X = x_3_, Y = y_3_ };

                    double triangleAB = Math.Sqrt(Math.Pow(A__.X - B__.X, 2) + Math.Pow(A__.Y - B__.Y, 2));
                    double triangleAC = Math.Sqrt(Math.Pow(A__.X - C__.X, 2) + Math.Pow(A__.Y - C__.Y, 2));
                    double triangleBC = Math.Sqrt(Math.Pow(B__.X - C__.X, 2) + Math.Pow(B__.Y - C__.Y, 2));

                    double perimetorT = triangleAB + triangleAC + triangleBC;
                    double areaT = Math.Sqrt((perimetorT / 2) * (perimetorT / 2 - triangleAB) * (perimetorT / 2 - triangleAC) * (perimetorT / 2 - triangleBC));

                    Console.Write("...\n...\n...\n...\n");
                    Console.WriteLine($"Периметр = {perimetorT} || Площадь = {areaT}");

                    break;
                default:
                    break;
            }
        }
    }
}

using System;

namespace Lab_11
{

    class Program
    {
        //инициализирую собственные ошибки
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");
        //private static WrongNumberException WrongNumberTS = new WrongNumberException("WrongTriangleSide");
        private static object temp;

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 11");
            Console.WriteLine("Введите цифру от (1-6) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool isA = ulong.TryParse(Console.ReadLine(), out ulong A);
                    Console.Write("Введите число B - ");
                    bool isB = ulong.TryParse(Console.ReadLine(), out ulong B);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isA == false || isB == false)
                    {
                        throw WrongNumberEx;
                    }

                    if (A != B)
                    {
                        temp = Math.Max(A, B);
                        A = (ulong)temp;
                        B = (ulong)temp;
                    }
                    else if (A == B)
                    {
                        A = 0;
                        B = 0;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Новые значения A - {A} B - {B}");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D2:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool is2A = double.TryParse(Console.ReadLine(), out double _A);
                    Console.Write("Введите число B - ");
                    bool is2B = double.TryParse(Console.ReadLine(), out double _B);
                    Console.Write("Введите число C - ");
                    bool is2C = double.TryParse(Console.ReadLine(), out double _C);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is2A == false || is2B == false || is2C == false)
                    {
                        throw WrongNumberEx;
                    }

                    double max2Sum = _A + _B + _C - Math.Min(_A, Math.Min(_B, _C));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Сумма двух наибольших значений из трех - {max2Sum}");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D3:

                    Console.Write(" - задание \n");

                    Console.WriteLine("Введите координаты первой точки: ");
                    Console.Write("X - ");
                    bool isX1_ = double.TryParse(Console.ReadLine(), out double x1_);
                    Console.Write("Y - ");
                    bool isY1_ = double.TryParse(Console.ReadLine(), out double y1_);

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
                        throw WrongNumberEx;
                    }

                    //Cоздаю новые точки
                    Point pointA = new Point { X = x1_, Y = y1_ };
                    Point pointB = new Point { X = x2_, Y = y2_ };
                    Point pointC = new Point { X = x3_, Y = y3_ };

                    double rangeAB = Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
                    double rangeAC = Math.Sqrt(Math.Pow(pointA.X - pointC.X, 2) + Math.Pow(pointA.Y - pointC.Y, 2));

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (rangeAB > rangeAC)
                    {
                        Console.Write($"Ближайшая точка имеет координаты C({pointC.X} {pointC.Y}), ");
                    }
                    else
                    {
                        Console.Write($"Ближайшая точка имеет координаты B({pointB.X} {pointB.Y}), ");
                    }
                    Console.Write($"расстояние от нее до А - {Math.Min(rangeAB, rangeAC)} \n");
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");

                    Console.WriteLine("Введите координаты точки: ");
                    Console.Write("X - ");
                    bool isX = double.TryParse(Console.ReadLine(), out double x);
                    Console.Write("Y - ");
                    bool isY = double.TryParse(Console.ReadLine(), out double y);

                    //Проверяю, что формат вводных данных правильный
                    if (isX == false || isY == false || x == 0 || y == 0)
                    {
                        throw WrongNumberEx;
                    }

                    byte chetv = 0;
                    if (x > 0 && y > 0)
                    {
                        chetv = 1;
                    }
                    else if (x < 0 && y > 0)
                    {
                        chetv = 2;
                    }
                    else if (x < 0 && y < 0)
                    {
                        chetv = 3;
                    }
                    else if (x > 0 && y < 0)
                    {
                        chetv = 4;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Точка находится в {chetv} четверти");
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D5:

                    Console.Write(" - задание \n");

                    Console.Write("Введите целое число - ");
                    bool isNumb = long.TryParse(Console.ReadLine(), out long numb);

                    //Проверяю, что формат вводных данных правильный
                    if (isNumb == false)
                    {
                        throw WrongNumberEx;
                    }

                    if (numb < 0)
                    {
                        if (numb % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Отрицательное четное число");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Отрицательное нечетное число");
                            Console.ResetColor();
                        }
                    }
                    else if (numb > 0)
                    {
                        if (numb % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Положительное четное число");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Положительное нечетное число");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Нулевое число");
                        Console.ResetColor();
                    }


                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D6:

                    Console.Write(" - задание \n");

                    Console.Write("Введите целое число в диапазоне [1-999] - ");
                    bool isNmbr = int.TryParse(Console.ReadLine(), out int nmbr);

                    //Проверяю, что формат вводных данных правильный
                    if (isNmbr == false || nmbr > 999)
                    {
                        throw WrongNumberEx;
                    }

                    if (nmbr % 2 == 0)
                    {
                        if (nmbr > 99)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Четное трехзначное число");
                            Console.ResetColor();
                        }
                        else if (nmbr > 9 && nmbr < 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Четное двузначное число");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Четное однозначное число");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        if (nmbr > 99)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Нечетное трехзначное число");
                            Console.ResetColor();
                        }
                        else if (nmbr > 9 && nmbr < 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Нечетное двузначное число");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Нечетное однозначное число");
                            Console.ResetColor();
                        }
                    }

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                default:
                    break;
            }
        }
    }
}

using System;

namespace Lab_10
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");
        private static WrongNumberException WrongNumberTS = new WrongNumberException("WrongTriangleSide");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 10");
            Console.WriteLine("Введите цифру от (1-7) для выбора задачи: ");

            var keyYorN = Console.ReadKey().Key;
            switch (keyYorN)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool isA = double.TryParse(Console.ReadLine(), out double A);
                    Console.Write("Введите число B - ");
                    bool isB = double.TryParse(Console.ReadLine(), out double B);

                    if (isA == false || isB == false)
                    {
                        throw WrongNumberEx;
                    }

                    if (A > 2 && B <= 3)
                    {
                        Console.WriteLine("Высказывание о том, что A>2 и B≤3 верно!");
                    }
                    else
                    {
                        Console.WriteLine("Высказывание о том, что A>2 и B≤3 неверно!");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                case ConsoleKey.D2:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool is2A = double.TryParse(Console.ReadLine(), out double _A);
                    Console.Write("Введите число B - ");
                    bool is2B = double.TryParse(Console.ReadLine(), out double _B);
                    Console.Write("Введите число C - ");
                    bool is2C = double.TryParse(Console.ReadLine(), out double _C);

                    if (is2A == false || is2B == false || is2C == false)
                    {
                        throw WrongNumberEx;
                    }

                    if ((_A < _B) && (_B < _C))
                    {
                        Console.WriteLine("Высказывание о том, что A<B<C верно!");
                    }
                    else
                    {
                        Console.WriteLine("Высказывание о том, что A<B<C неверно!");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                case ConsoleKey.D3:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число - ");
                    bool isNumber = ulong.TryParse(Console.ReadLine(), out ulong num2);

                    if (isNumber == false)
                    {
                        throw WrongNumberEx;
                    }

                    if (num2 <= 99 && num2 >= 10 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Данное число является четным двузначным");
                    }
                    else
                    {
                        Console.WriteLine("Утверждение неверно");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число - ");
                    bool is3Number = ulong.TryParse(Console.ReadLine(), out ulong num3);

                    if (is3Number == false || num3 > 999 || num3 < 100)
                    {
                        throw WrongNumberEx;
                    }

                    if (((num3 / 100) > ((num3 / 10) % 10) && ((num3 / 10) % 10) > num3 % 10) || ((num3 / 100) < ((num3 / 10) % 10) && ((num3 / 10) % 10) < num3 % 10))
                    {
                        Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
                    }
                    else
                    {
                        Console.WriteLine("Утверждение неверно");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                case ConsoleKey.D5:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число - ");
                    bool is4Number = ulong.TryParse(Console.ReadLine(), out ulong num4);

                    if (is4Number == false || num4 > 9999 || num4 < 1000)
                    {
                        throw WrongNumberEx;
                    }

                    if ((num4 / 1000) == (num4 % 10) && ((num4 / 100) % 10) == ((num4 / 10) % 10))
                    { 
                        Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
                    }
                    else
                    {
                        Console.WriteLine("Утверждение неверно");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                case ConsoleKey.D6:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool is2a = ulong.TryParse(Console.ReadLine(), out ulong a);
                    Console.Write("Введите число B - ");
                    bool is2b = ulong.TryParse(Console.ReadLine(), out ulong b);
                    Console.Write("Введите число C - ");
                    bool is2c = ulong.TryParse(Console.ReadLine(), out ulong c);

                    if (is2a == false || is2b == false || is2c == false)
                    {
                        throw WrongNumberEx;
                    }
                    if (((a+b) <= c) || ((a + c) <= b) || ((b + c) <= a) || a == 0 || b == 0 || c == 0)
                    {
                        throw WrongNumberTS;
                    }

                    if (Math.Sqrt((double)(a * a + b * b)))
                    {
                        Console.WriteLine("Высказывание о том, что A<B<C верно!");
                    }
                    else
                    {
                        Console.WriteLine("Высказывание о том, что A<B<C неверно!");
                    }

                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;

                default:
                    break;
            }
        }
    }
}

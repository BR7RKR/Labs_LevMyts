using System;

namespace Lab_10
{
    class Program
    {
        //инициализирую собственные ошибки
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");
        private static WrongNumberException WrongNumberTS = new WrongNumberException("WrongTriangleSide");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 10");
            Console.WriteLine("Введите цифру от (1-7) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool isA = double.TryParse(Console.ReadLine(), out double A);
                    Console.Write("Введите число B - ");
                    bool isB = double.TryParse(Console.ReadLine(), out double B);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isA == false || isB == false)
                    {
                        throw WrongNumberEx;
                    }
                    //проверяю истинность высказывания
                    if (A > 2 && B <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Высказывание о том, что A>2 и B≤3 верно!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Высказывание о том, что A>2 и B≤3 неверно!");
                    }
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
                    //проверяю истинность высказывания
                    if ((_A < _B) && (_B < _C))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Высказывание о том, что A<B<C верно!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Высказывание о том, что A<B<C неверно!");
                    }
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
                    Console.Write("Введите число - ");
                    bool isNumber = ulong.TryParse(Console.ReadLine(), out ulong num2);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumber == false)
                    {
                        throw WrongNumberEx;
                    }
                    //проверяю истинность высказывания
                    if (num2 <= 99 && num2 >= 10 && num2 % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Данное число является четным двузначным");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Утверждение неверно");
                    }
                    Console.ResetColor(); // сбрасываю цвета консоли

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
                    Console.Write("Введите число - ");
                    bool is3Number = ulong.TryParse(Console.ReadLine(), out ulong num3);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is3Number == false || num3 > 999 || num3 < 100)
                    {
                        throw WrongNumberEx;
                    }
                    //проверяю истинность высказывания
                    if (((num3 / 100) > ((num3 / 10) % 10) && ((num3 / 10) % 10) > num3 % 10) || ((num3 / 100) < ((num3 / 10) % 10) && ((num3 / 10) % 10) < num3 % 10))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Утверждение неверно");
                    }
                    Console.ResetColor(); // сбрасываю цвета консоли

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
                    Console.Write("Введите число - ");
                    bool is4Number = ulong.TryParse(Console.ReadLine(), out ulong num4);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is4Number == false || num4 > 9999 || num4 < 1000)
                    {
                        throw WrongNumberEx;
                    }
                    //проверяю истинность высказывания
                    if ((num4 / 1000) == (num4 % 10) && ((num4 / 100) % 10) == ((num4 / 10) % 10))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Утверждение неверно");
                    }
                    Console.ResetColor(); // сбрасываю цвета консоли

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
                    Console.Write("Введите число A - ");
                    bool is2a = ulong.TryParse(Console.ReadLine(), out ulong a);
                    Console.Write("Введите число B - ");
                    bool is2b = ulong.TryParse(Console.ReadLine(), out ulong b);
                    Console.Write("Введите число C - ");
                    bool is2c = ulong.TryParse(Console.ReadLine(), out ulong c);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is2a == false || is2b == false || is2c == false)
                    {
                        throw WrongNumberEx;
                    }
                    if (((a+b) <= c) || ((a + c) <= b) || ((b + c) <= a) || a == 0 || b == 0 || c == 0)
                    {
                        throw WrongNumberTS;
                    }
                    //проверяю истинность высказывания
                    if ((a * a + b * b) == c * c || (c * c + b * b) == a * a || (a * a + c * c) == b * b)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Высказывание о том, что треугольник прямоугольный неверно!");
                    }
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Blue;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;

                case ConsoleKey.D7:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool is_a = ulong.TryParse(Console.ReadLine(), out ulong _a);
                    Console.Write("Введите число B - ");
                    bool is_b = ulong.TryParse(Console.ReadLine(), out ulong _b);
                    Console.Write("Введите число C - ");
                    bool is_c = ulong.TryParse(Console.ReadLine(), out ulong _c);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is_a == false || is_b == false || is_c == false)
                    {
                        throw WrongNumberEx;
                    }
                    //проверяю истинность высказывания
                    if (((_a + _b) <= _c) || ((_a + _c) <= _b) || ((_b + _c) <= _a) || _a == 0 || _b == 0 || _c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Треугольник НЕ существует");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Треугольник существует");
                    }
                    Console.ResetColor(); // сбрасываю цвета консоли
                
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

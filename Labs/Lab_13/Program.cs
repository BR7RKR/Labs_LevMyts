using System;

namespace Lab_13
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 12");
            Console.WriteLine("Введите цифру от (1-5) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите цену одного кг конфет - ");
                    bool is1Price = float.TryParse(Console.ReadLine(), out float price);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is1Price == false || price <= 0)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    for (float i = 0.1f; i <= 1.1; i += 0.1f)
                    {
                        Console.WriteLine($"{Math.Round(price * Math.Round(i, 1), 2)}");
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
                    Console.Write("Введите кол-во итераций N - ");
                    bool isN = int.TryParse(Console.ReadLine(), out int N);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isN == false || N <= 0)
                    {
                        throw WrongNumberEx;
                    }

                    double res = 1.1;
                    int k = 0;
                    for (double i = 1.2; k < N-1; i+=0.1)
                    {
                        k += 1;
                        res *= Math.Round(i, 1);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Ответ: {res}");
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
                    Console.Write("Введите число N - ");
                    bool isNb = ulong.TryParse(Console.ReadLine(), out ulong n);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNb == false)
                    {
                        throw WrongNumberEx;
                    }

                    ulong result = 0;
                    for (ulong i = 1; i <= (2*n - 1); i+=2)
                    {
                        result += i;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"N^2 {result}");
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
                    Console.Write("Введите число A - ");
                    bool isNmbrA = double.TryParse(Console.ReadLine(), out double A);
                    Console.Write("Введите число N - ");
                    bool isNmbr = ulong.TryParse(Console.ReadLine(), out ulong _n);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNmbr == false || isNmbrA == false)
                    {
                        throw WrongNumberEx;
                    }

                    double _res = 0;
                    if (A == 0)
                    {
                        _res = 0;
                    }
                    else
                    {
                        for (ulong i = 0; i <= _n; i++)
                        {
                            _res += Math.Pow(A, i);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Сумма - {_res}");
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

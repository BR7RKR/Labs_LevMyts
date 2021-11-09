using System;

namespace Lab_14
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 14");
            Console.WriteLine("Введите цифру от (1-6) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool isStartA = ulong.TryParse(Console.ReadLine(), out ulong startA);
                    Console.Write("Введите число B - ");
                    bool isEndB = ulong.TryParse(Console.ReadLine(), out ulong endB);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isStartA == false || isEndB == false || startA >= endB)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    for (ulong i = startA; i <= endB; i++)
                    {
                        for (ulong j = 0; j < i; j++)
                        {
                            Console.Write($" {i}");
                        }
                        Console.Write("\n");
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
                    Console.Write("Введите длинну большего отрезка - ");
                    bool isBigA = ulong.TryParse(Console.ReadLine(), out ulong bigA);
                    Console.Write("Введите длинну меньшего отрезка - ");
                    bool isSmallB = ulong.TryParse(Console.ReadLine(), out ulong smallB);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isBigA == false || isSmallB == false || bigA <= smallB)
                    {
                        throw WrongNumberEx;
                    }

                    ulong buf = 0;
                    for (ulong i = 0;  buf+smallB <= bigA  ; i++)
                    {
                        buf += smallB;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Оставшееся место - {bigA-buf}");
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
                    Console.Write("Введите целое число N - ");
                    bool isNumberN = ulong.TryParse(Console.ReadLine(), out ulong numberN);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumberN == false)
                    {
                        throw WrongNumberEx;
                    }

                    ulong buffer = 0;
                    ulong K = 0;
                    for (ulong i = 1; true ; i++)
                    {
                        if (buffer >= numberN)
                        {
                            K = i-1;
                            break;
                        }
                        else
                        {
                            buffer += i;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"K - {K}, сумма = {buffer}");
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
                    float contribution = 1000;
                    Console.Write("Введите процент - ");
                    bool isPercent = float.TryParse(Console.ReadLine(), out float percent);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isPercent == false || percent < 0 || percent > 25)
                    {
                        throw WrongNumberEx;
                    }

                    int months = 0;

                    for (int i = 0; contribution <= 1100; i++)
                    {
                        contribution *= (percent / 100 + 1);
                        months = i;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Число месяцев - {months+1}, итоговый размер вклада = {contribution}");
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
                    Console.Write("Введите число A - ");
                    bool isA = ulong.TryParse(Console.ReadLine(), out ulong A);
                    Console.Write("Введите число B - ");
                    bool isB = ulong.TryParse(Console.ReadLine(), out ulong B);

                    ulong temp;

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isA == false || isB == false)
                    {
                        throw WrongNumberEx;
                    }

                    for (ulong i = 0; A != B; i++)
                    {
                        temp = Math.Max(A, B) - Math.Min(A, B);
                        A = B;
                        B = temp;
                    }
                    temp = B;

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"НОД - {temp}");
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
                    Console.Write("Введите число Фибоначчи - ");
                    bool isN = ulong.TryParse(Console.ReadLine(), out ulong n);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isN == false || n <= 1)
                    {
                        throw WrongNumberEx;
                    }

                    ulong k = 2;
                    ulong n1 = 1;
                    ulong n2 = 1;
                    ulong n0 = 0;
                    while (n0 < n)
                    {
                        ++k;
                        n0 = n2 + n1;
                        n2 = n1;
                        n1 = n0;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Порядковый номер - {k}");
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

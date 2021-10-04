using System;

namespace Lab_9
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat"); //инициализирую экземпляр класса ошибок
        private static byte k = 0; //инициализирую поле, которое отвечает за счетчик дней в задаче 3 и 4

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 9");
            Console.WriteLine("Нажмите на клавишу 1-5 для перехода к нужному заданию");
            //Подключаю обработку клавиш
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите кол-во секунд, прошедших с начала суток - ");
                    bool isSeconds = ulong.TryParse(Console.ReadLine(), out ulong seconds);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isSeconds == false)
                    {
                        throw WrongNumberEx;
                    }

                    double minutes = Math.Floor((double)seconds / 60);
                    double secLeft = seconds - minutes * 60;

                    Console.WriteLine($"Ровно {secLeft} секунд прошло с начала последний минуты");
                    break;

                case ConsoleKey.D2:

                    Console.Write(" - задание \n");
                    Console.Write("Введите кол-во прошедших дней в этом году - ");
                    bool isDay = int.TryParse(Console.ReadLine(), out int day);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isDay == false || day>365 || day < 1)
                    {
                        throw WrongNumberEx;
                    }

                    if (day % 7 != 0)
                    {
                        for (int i = 0; i < day; i++)
                        {
                            if (k == 7)
                            {
                                k = 0;
                            }
                            k++;
                        }
                    }
                    Console.WriteLine($"Номер дня недели - {k}");
                    break;

                case ConsoleKey.D3:

                    Console.Write(" - задание \n");
                    Console.Write("Введите кол-во прошедших дней в этом году - ");
                    bool is_Day = int.TryParse(Console.ReadLine(), out int _day);
                    Console.Write("Введите номер первого дня в году - ");
                    bool isFDay = int.TryParse(Console.ReadLine(), out int fDay);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is_Day == false || isFDay == false || _day > 365 || _day < 1)
                    {
                        throw WrongNumberEx;
                    }

                    for (int i = 0; i < _day; i++)
                    {
                        if (k == 7)
                        {
                            k = 0;
                        }
                        k++;
                    }
                    if (fDay > 1)
                    {
                        fDay = k + (fDay - 1);
                        if (fDay > 7)
                        {
                            fDay -= 7;
                        } 
                    }
                    Console.WriteLine($"Номер дня недели - {fDay}");
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");
                    Console.Write("Введите высоту прямоугольника - ");
                    bool isA = int.TryParse(Console.ReadLine(), out int A);
                    Console.Write("Введите длинну прямоугольника - ");
                    bool isB = int.TryParse(Console.ReadLine(), out int B);
                    Console.Write("Введите сторону квадрата - ");
                    bool isC = int.TryParse(Console.ReadLine(), out int C);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isA == false || isB == false || isC == false || A<1 || B<1 || C<1)
                    {
                        throw WrongNumberEx;
                    }

                    int rArea = A * B;
                    int sArea = C * C;
                    if (sArea > rArea)
                    {
                        Console.WriteLine("Квадрат не поместится");
                    }
                    else
                    {
                        int squareCount = rArea / sArea;
                        int placeLeft = rArea - (squareCount * sArea);

                        Console.WriteLine($"Колличество квадратов - {squareCount} || Колличество свободного места {placeLeft}");
                    }
                    break;

                case ConsoleKey.D5:

                    Console.Write(" - задание \n");
                    Console.Write("Введите год - ");
                    bool isYear = int.TryParse(Console.ReadLine(), out int year);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (year < 1 || isYear == false)
                    {
                        throw WrongNumberEx;
                    }

                    int century = year / 100 + 1;

                    Console.WriteLine($"Столетие - {century}");
                    break;

                default:
                    break;
            }
        }
    }
}

using System;

namespace Lab_12
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");
        private static string[] days = new string[] { "null", "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцотое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое"};

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 12");
            Console.WriteLine("Введите цифру от (1-5) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите номер дня [1;31] - ");
                    bool isA = ulong.TryParse(Console.ReadLine(), out ulong A);
                    Console.Write("Введите номер месяца [1;12] - ");
                    bool isB = ulong.TryParse(Console.ReadLine(), out ulong B);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isA == false || isB == false)
                    {
                        throw WrongNumberEx;
                    }

                    if (A != B)//проверяю неравенство
                    {
                        temp = Math.Max(A, B);//заношу максимальное число в буферную переменную
                        A = temp;
                        B = temp;
                    }
                    else if (A == B)//проверяю равенство
                    {
                        A = 0;
                        B = 0;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
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

                default:
                    break;
            }
        }
    }
}

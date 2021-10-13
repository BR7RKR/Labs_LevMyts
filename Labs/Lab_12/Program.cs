using System;

namespace Lab_12
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
                    string[] days = new string[] { "null", "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцотое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое", "двадцать первое", "двадцать второе", "двадцать третье", "двадцать четвертое", "двадцать пятое", "двадцать шестое", "двадцать седьмое", "двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое" };
                    string[] months = new string[] { "null", "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                    Console.Write("Введите номер дня [1;31] - ");
                    bool isDay = byte.TryParse(Console.ReadLine(), out byte day);
                    Console.Write("Введите номер месяца [1;12] - ");
                    bool isMonth = byte.TryParse(Console.ReadLine(), out byte month);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isDay == false || isMonth == false || day > 31 || day < 1 || month > 12 || month < 1)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"{days[day]} {months[month]}");
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
                    string[] compasDir = new string[] { "С", "З", "Ю", "В"};
                    //string[] months = new string[] { "null", "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                    Console.Write("Введите исходное направление робота - ");
                    string start = Console.ReadLine();
                    Console.Write("Введите команду - ");
                    string command = Console.ReadLine();

                    if (compasDir.Any())//вызываю собственные ошибки при нарушении правил ввода
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"{days[day]} {months[month]}");
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

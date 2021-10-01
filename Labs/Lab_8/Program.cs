using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 8");
            Console.WriteLine("Нажмите на клавишу 1-6 для перехода к нужному заданию");
            //Подключаю обработку клавиш
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:


                    break;

                default:
                    break;
            }
        }
    }
}

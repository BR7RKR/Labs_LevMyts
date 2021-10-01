using System;

namespace Lab_8
{
    class Program
    {
        private static WrongNumberException _wrongNumberException = new WrongNumberException("WrongNumberFormat");
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 8");
            Console.WriteLine("Нажмите на клавишу 1-5 для перехода к нужному заданию");
            //Подключаю обработку клавиш
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите кол-во байт - ");
                    bool isNumber = float.TryParse(Console.ReadLine(), out float bYte);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumber == false || bYte <= 0)
                    {
                        throw _wrongNumberException;
                    }

                    ulong kBytes = (ulong)Math.Floor(bYte / 1024)+1;

                    Console.WriteLine($"Килобайт - {kBytes}");
                    break;

                case ConsoleKey.D2:

                    Console.Write(" - задание \n");
                    Console.Write("Введите длинну первого отрезка - ");
                    bool isFirstLS = ulong.TryParse(Console.ReadLine(), out ulong mainLineS);
                    Console.Write("Введите длинну второго отрезка - ");
                    bool isSecondLS = ulong.TryParse(Console.ReadLine(), out ulong secondLineS);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isFirstLS == false || isSecondLS == false || mainLineS <= secondLineS)
                    {
                        throw _wrongNumberException;
                    }

                    ulong amountOfLS = mainLineS / secondLineS;

                    Console.WriteLine($"Кол-во маленьких отрезков, которые поместятся на основном {amountOfLS}");
                    break;

                default:
                    break;
            }
        }
    }
}

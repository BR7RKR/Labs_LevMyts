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

                case ConsoleKey.D3:

                    Console.Write(" - задание \n");
                    Console.Write("Введите длинну первого отрезка - ");
                    bool isFirstLineS = ulong.TryParse(Console.ReadLine(), out ulong mainLine);
                    Console.Write("Введите длинну второго отрезка - ");
                    bool isSecondLineS = ulong.TryParse(Console.ReadLine(), out ulong secondLine);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isFirstLineS == false || isSecondLineS == false || mainLine <= secondLine)
                    {
                        throw _wrongNumberException;
                    }

                    ulong amountLS = mainLine / secondLine;
                    ulong freeSpace = mainLine - amountLS*secondLine;

                    Console.WriteLine($"Длина оставшегося места {freeSpace}");
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");
                    Console.Write("Введите двузначное число - ");
                    bool is_Number = int.TryParse(Console.ReadLine(), out int number);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is_Number == false || number<10 || number > 99)
                    {
                        throw _wrongNumberException;
                    }

                    int revNumber = (number % 10)*10 + (number / 10);

                    Console.WriteLine($"Перевернутое число - {revNumber}");
                    break;

                case ConsoleKey.D5:

                    Console.Write(" - задание \n");
                    Console.Write("Введите трехзначное число - ");
                    bool is3Number = int.TryParse(Console.ReadLine(), out int number3);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (is3Number == false || number3 < 100 || number3 > 999)
                    {
                        throw _wrongNumberException;
                    }

                    int rev3Number = (number3 % 100)*10 + (number3/100);

                    Console.WriteLine($"Перевернутое число - {rev3Number}");
                    break;

                default:
                    break;
            }
        }
    }
}

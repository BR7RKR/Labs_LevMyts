using System;

namespace Lab_16
{
    class Program
    {
        private static WrongNumberException _wrongNumberFormat = new WrongNumberException("WrongNumberFormat");
        
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 16");
            Console.WriteLine("Введите цифру от (1-5) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите размер массива - ");
                    bool isRange1 = ulong.TryParse(Console.ReadLine(), out ulong range1);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRange1 == false || range1 == 0)
                    {
                        throw _wrongNumberFormat;
                    }

                    ulong[] arr1 = new ulong[range1]; //формирую массив и выделяю память под range элементов.
                    for (ulong i = 0; i < range1; i++)
                    {
                        arr1[i] = 1 + i * 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan; //меняю цвет текста
                    foreach (var VARIABLE in arr1)
                    {
                        Console.Write($"{VARIABLE} ");
                    }
                    Console.Write("\n");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Yellow;  //меняю цвет фона текста
                    Console.ForegroundColor = ConsoleColor.Black; // меняю цвет фона текста
                    Console.WriteLine("Нажмите ENTER для продолжения");
                    Console.ResetColor(); //сбрасываю цвета консоли
                    Console.ReadLine(); // запрашиваю ввод
                    Console.Clear(); // очищаю консоль
                    Main(args); // перезапускаю программу
                    break;
                
                case ConsoleKey.D2:
                    
                    Console.Write(" - задание \n");
                    Console.Write("Введите размер массива - ");
                    bool isRange2 = ulong.TryParse(Console.ReadLine(), out ulong range2);
                    Console.Write("Введите первый элемент массива - ");
                    bool isFirstElement = double.TryParse(Console.ReadLine(), out double firstElement);
                    Console.Write("Введите знаменатель геометрической прогрессии - ");
                    bool isQ = double.TryParse(Console.ReadLine(), out double q);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRange2 == false || range2 == 1)
                    {
                        throw _wrongNumberFormat;
                    }

                    double[] arr2 = new double[range2]; //формирую массив и выделяю память под range элементов.
                    arr2[0] = firstElement; // заполняю первый элемент массива
                    for (ulong i = 1; i < range2; i++)
                    {
                        arr2[i] = firstElement * Math.Pow(q, i);
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan; //меняю цвет текста
                    foreach (var VARIABLE in arr2)
                    {
                        Console.Write($"{VARIABLE} ");
                    }
                    Console.Write("\n");
                    Console.ResetColor(); // сбрасываю цвета консоли

                    Console.BackgroundColor = ConsoleColor.Yellow;  //меняю цвет фона текста
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
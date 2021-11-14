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

                    ulong[] arr1 = new ulong[range1]; //формирую массив и выделяю память под range1 элементов.
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

                    double[] arr2 = new double[range2]; //формирую массив и выделяю память под range2 элементов.
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
                
                case ConsoleKey.D3:
                    
                    Console.Write(" - задание \n");
                    Console.Write("Введите размер массива - ");
                    bool isRange3 = ulong.TryParse(Console.ReadLine(), out ulong range3);
                    Console.Write("Введите первый элемент массива - ");
                    bool isFirstEl = double.TryParse(Console.ReadLine(), out double firstEl);
                    Console.Write("Введите первый элемент массива - ");
                    bool isSecondEl = double.TryParse(Console.ReadLine(), out double secondEl);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRange3 == false || range3 < 2)
                    {
                        throw _wrongNumberFormat;
                    }

                    double[] arr3 = new double[range3]; //формирую массив и выделяю память под range3 элементов.
                    arr3[0] = firstEl; // заполняю первый элемент массива
                    arr3[1] = secondEl; // заполняю второй элемент массива
                    arr3[2] = firstEl + secondEl; // заполняю третий элемент массива
                    for (ulong i = 3; i < range3; i++)
                    {
                        arr3[i] = arr3[i - 1] * 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan; //меняю цвет текста
                    foreach (var VARIABLE in arr3)
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
                
                case ConsoleKey.D4:
                    
                    Console.Write(" - задание \n");
                    Console.Write("Введите размер массива - ");
                    bool isRange4 = ulong.TryParse(Console.ReadLine(), out ulong range4);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRange4 == false)
                    {
                        throw _wrongNumberFormat;
                    }
                    
                    double[] arr4 = new double[range4]; //формирую массив и выделяю память под range4 элементов.

                    bool isVar; // создаю булевую переменную для хранения результата парсирования

                    Console.WriteLine("Заполните массив: ");
                    for (int i = 0; i < arr4.Length ; i++)
                    {
                        isVar = double.TryParse(Console.ReadLine(), out double variable);
                        
                        //вызываю собственные ошибки при нарушении правил ввода 
                        if (isVar == false)
                        {
                            throw _wrongNumberFormat;
                        }
                        
                        arr4[i] = variable;
                    }

                    ulong j = range4 - 1; //создаю дополнительный счетчик
                    Console.ForegroundColor = ConsoleColor.Cyan; //меняю цвет текста
                    for (ulong i = 0; i < range4; i++)
                    {
                        if (i % 2 == 0 )
                        {
                            Console.Write($"{arr4[i/2]} ");
                        }
                        else
                        {
                            Console.Write($"{arr4[j--]} ");
                        }
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
                
                case ConsoleKey.D5:
                    
                    Console.Write(" - задание \n");
                    Console.Write("Введите размер массива - ");
                    bool isRange5 = long.TryParse(Console.ReadLine(), out long range5);
                    
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRange5 == false || range5 < 1)
                    {
                        throw _wrongNumberFormat;
                    }
                    
                    double[] arr5 = new double[range5]; //формирую массив и выделяю память под range элементов.

                    Console.WriteLine("Заполните массив: ");
                    for (int i = 0; i < arr5.Length ; i++)
                    {
                        isVar = double.TryParse(Console.ReadLine(), out double variable);
                        
                        //вызываю собственные ошибки при нарушении правил ввода 
                        if (isVar == false)
                        {
                            throw _wrongNumberFormat;
                        }
                        
                        arr5[i] = variable;
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Cyan; //меняю цвет текста
                    for (long i = 0; i < range5; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write($"{arr5[i]} ");
                        }
                    }
                    for (long i = range5-1; i > -1; i--)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"{arr5[i]} ");
                        }
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
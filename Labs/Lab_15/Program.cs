using System;

namespace Lab_15
{
    class Program
    {
        private static WrongNumberException WrongNumberEx = new WrongNumberException("WrongNumberFormat");

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 15");
            Console.WriteLine("Введите цифру от (1-5) для выбора задачи: ");

            var key = Console.ReadKey().Key;
            switch (key)
            {

                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите первое число - ");
                    bool isNumber1 = double.TryParse(Console.ReadLine(), out double number1);
                    Console.Write("Введите второе число - ");
                    bool isNumber2 = float.TryParse(Console.ReadLine(), out float number2);
                    Console.Write("Введите третье число - ");
                    bool isNumber3 = decimal.TryParse(Console.ReadLine(), out decimal number3);
                    Console.Write("Введите четвертое число - ");
                    bool isNumber4 = double.TryParse(Console.ReadLine(), out double number4);
                    Console.Write("Введите пятое число - ");
                    bool isNumber5 = double.TryParse(Console.ReadLine(), out double number5);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumber1 == false || isNumber2 == false || isNumber3 == false || isNumber4 == false || isNumber5 == false)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine("Третьи степени всех пяти чисел: ");
                    Console.WriteLine(MethodsForLab15.Power3A(number1));
                    Console.WriteLine(MethodsForLab15.Power3A(number2));
                    Console.WriteLine(MethodsForLab15.Power3A(number3));
                    Console.WriteLine(MethodsForLab15.Power3A(number4));
                    Console.WriteLine(MethodsForLab15.Power3A(number5));
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
                    Console.Write("Введите первое число - ");
                    bool isNumberA = double.TryParse(Console.ReadLine(), out double numberA);
                    Console.Write("Введите второе число - ");
                    bool isNumberB = float.TryParse(Console.ReadLine(), out float numberB);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumberA == false || isNumberB == false)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Сумма двух возвращаемых значений = {MethodsForLab15.Sign(numberA) + MethodsForLab15.Sign(numberB)}");
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

                    Console.Write("Введите внутренний радиус - ");
                    bool isRS1 = double.TryParse(Console.ReadLine(), out double rS1);
                    Console.Write("Введите внешний радиус - ");
                    bool isRB1 = double.TryParse(Console.ReadLine(), out double rB1);

                    Console.Write("Введите внутренний радиус - ");
                    bool isRS2 = double.TryParse(Console.ReadLine(), out double rS2);
                    Console.Write("Введите внешний радиус - ");
                    bool isRB2 = double.TryParse(Console.ReadLine(), out double rB2);

                    Console.Write("Введите внутренний радиус - ");
                    bool isRS3 = float.TryParse(Console.ReadLine(), out float rS3);
                    Console.Write("Введите внешний радиус - ");
                    bool isRB3 = float.TryParse(Console.ReadLine(), out float rB3);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isRS1 == false || isRS2 == false || isRS3 == false || isRB1 == false || isRB2 == false || isRB3 == false || rS1 > rB1 || rS2 > rB2 || rS3 > rB3)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Площадь первого кольца = {MethodsForLab15.RingS(rS1, rB1)}");
                    Console.WriteLine($"Площадь второго кольца = {MethodsForLab15.RingS(rS2, rB2)}");
                    Console.WriteLine($"Площадь третьего кольца = {MethodsForLab15.RingS(rS3, rB3)}");
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

                    Console.WriteLine("Введите координаты первой точки: ");
                    Console.Write("X - ");
                    bool isX1_ = double.TryParse(Console.ReadLine(), out double x1_);
                    Console.Write("Y - ");
                    bool isY1_ = double.TryParse(Console.ReadLine(), out double y1_);

                    Console.WriteLine("Введите координаты второй точки: ");
                    Console.Write("X - ");
                    bool isX2_ = float.TryParse(Console.ReadLine(), out float x2_);
                    Console.Write("Y - ");
                    bool isY2_ = float.TryParse(Console.ReadLine(), out float y2_);

                    Console.WriteLine("Введите координаты третьей точки: ");
                    Console.Write("X - ");
                    bool isX3_ = decimal.TryParse(Console.ReadLine(), out decimal x3_);
                    Console.Write("Y - ");
                    bool isY3_ = decimal.TryParse(Console.ReadLine(), out decimal y3_);

                    //Проверяю, что формат вводных данных правильный
                    if (x1_ == 0 || x2_ == 0 || x3_ == 0 || y1_ == 0 || y2_ == 0 || y3_ == 0)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Четверть первой точки = {MethodsForLab15.Quarter(x1_, y1_)}");
                    Console.WriteLine($"Четверть второй точки = {MethodsForLab15.Quarter(x2_, y2_)}");
                    Console.WriteLine($"Четверть третьей точки = {MethodsForLab15.Quarter(x3_, y3_)}");
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
                    Console.Write("Введите число для вычисления двойного факториала - ");
                    bool isNumber = ulong.TryParse(Console.ReadLine(), out ulong number);

                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNumber == false)
                    {
                        throw WrongNumberEx;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;//меняю цвет текста
                    Console.WriteLine($"Двойной факториал = {MethodsForLab15.Fact2(number)}");
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

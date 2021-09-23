using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        //Инициализирую новый тип ошибок
        private static WrongNumberException _WrongNumberException = new WrongNumberException("WrongNumberFormat");

        private static int _A = 3;
        private static int _B = 5;
        private static int _C = 7;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Лабораторная работа номер 6");
            Console.WriteLine("Чтобы выбрать задачу нажмите на клавишу 1-7");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.WriteLine("");
                    Console.WriteLine($"A = {_A}, B = {_B}");

                    //Меняю переменные местами
                    _A += _B;
                    _B = _A - _B;
                    _A = _A - _B;
                    //

                    Console.WriteLine($"A = {_A}, B = {_B}");
                    break;

                case ConsoleKey.D2:

                    Console.WriteLine("");
                    Console.WriteLine($"A = {_A}, B = {_B} C = {_C}");

                    //Меняю переменные местами
                    _C += _A;
                    _A = _C - _A;
                    _C = _C - _A;
                    _B += _C;
                    _C = _B - _C;
                    _B = _B - _C;
                    //

                    Console.WriteLine($"A = {_A}, B = {_B} C = {_C}");
                    break;

                case ConsoleKey.D3:

                    Console.WriteLine("");
                    Console.WriteLine($"A = {_A}, B = {_B} C = {_C}");

                    //Меняю переменные местами
                    _B += _C;
                    _C = _B - _C;
                    _B = _B - _C;
                    _C += _A;
                    _A = _C - _A;
                    _C = _C - _A;
                    //

                    Console.WriteLine($"A = {_A}, B = {_B} C = {_C}");
                    break;

                case ConsoleKey.D4:

                    Console.WriteLine("");
                    Console.Write("Введите значение x - ");
                    bool isNumber = double.TryParse(Console.ReadLine(), out double x);

                    //Проверяю соответствие введенных данных формату
                    if (isNumber == false)
                    {
                        throw _WrongNumberException;
                    }

                    //Нахожу значение функции 
                    double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;

                    Console.WriteLine($"y = {y}");
                    break;

                case ConsoleKey.D5:

                    Console.WriteLine("");
                    Console.Write("Введите значение x - ");
                    bool isNumber1 = double.TryParse(Console.ReadLine(), out double x1);

                    //Проверяю соответствие введенных данных формату
                    if (isNumber1 == false)
                    {
                        throw _WrongNumberException;
                    }

                    //Нахожу значение функции
                    double y1 = 4 * Math.Pow((x1 - 3), 6) - 7 * Math.Pow((x1 - 3), 3) + 2;

                    Console.WriteLine($"y = {y1}");
                    break;

                case ConsoleKey.D6:

                    Console.WriteLine("");
                    Console.Write("Введите значение A - ");
                    bool isNumberA = double.TryParse(Console.ReadLine(), out double A);
                    double A8;

                    //Проверяю соответствие введенных данных формату
                    if (isNumberA == false)
                    {
                        throw _WrongNumberException;
                    }

                    //Вычисляю А в восьмой степени
                    A8 = A * A;
                    A8 *= A8;
                    A8 *= A8;

                    Console.WriteLine($"A^8 = {A8}");
                    break;

                case ConsoleKey.D7:

                    Console.WriteLine("");
                    Console.Write("Введите значение A - ");
                    bool isNumber_A = double.TryParse(Console.ReadLine(), out double A_7);
                    double A15_1;
                    double A15_2;

                    //Проверяю соответствие введенных данных формату
                    if (isNumber_A == false)
                    {
                        throw _WrongNumberException;
                    }

                    //Вычисляю А в пятнадцатой степени
                    A15_1 = A_7 * A_7;
                    A15_2 = A15_1 * A_7;
                    A15_2 = A15_2 * A15_1;
                    A15_2 = A15_2 * A15_2 * A15_2;

                    Console.WriteLine($"A^15 = {A15_2}");
                    break;

                default:
                    break;
            }
        }
    }
}

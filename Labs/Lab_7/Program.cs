using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        //Инициализирую новый тип ошибок
        private static WrongNumberException _wrongNumberException = new WrongNumberException("WrongNumberFormat");
        private static WrongNumberException _wrongRangeException = new WrongNumberException("WrongDegValue");
        private static WrongNumberException _wrongRangeEx = new WrongNumberException("WrongRadValue");
        //Инициализирую массу конфет в килограммах и цену за них
        private static float xKg = 25;
        private static float aRub = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа номер 7");
            Console.WriteLine("Нажмите на клавишу 1-6 для перехода к нужному заданию");

            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.WriteLine("");
                    Console.WriteLine("Задание 1");
                    Console.Write("Введите значение угла в градусах a - ");

                    bool isNumber = float.TryParse(Console.ReadLine(), out float aDeg);

                    if (isNumber == false)
                    {
                        throw _wrongNumberException;
                    }
                    if (aDeg >= 360 || aDeg <= 0)
                    {
                        throw _wrongRangeException;
                    }

                    float toRadRes = aDeg * (float)Math.PI / 180;

                    Console.WriteLine($"Угол в радианах будет равен = {toRadRes} rad");
                    break;

                case ConsoleKey.D2:

                    Console.WriteLine("");
                    Console.WriteLine("Задание 2");
                    Console.Write("Введите значение угла в радианах a (без Пи) - ");

                    bool is_Number = float.TryParse(Console.ReadLine(), out float aRad);

                    if (is_Number == false)
                    {
                        throw _wrongNumberException;
                    }
                    if (aRad >= (2 * Math.PI) || aRad <= 0)
                    {
                        throw _wrongRangeEx;
                    }

                    float toDegRes = aRad * 180 / (float)Math.PI;

                    Console.WriteLine($"Угол в градусах будет равен = {toDegRes}°");
                    break;

                case ConsoleKey.D3:

                    Console.WriteLine("");
                    Console.WriteLine("Задание 3");
                    Console.Write("Введите массу конфет в кг, которую вам надо купить Y - ");
                    bool isY = float.TryParse(Console.ReadLine(), out float Y);

                    if (isY == false)
                    {
                        throw _wrongNumberException;
                    }

                    float priceFor1Kg = aRub / xKg;
                    float priceForYKg = priceFor1Kg * Y;

                    Console.WriteLine($"Цена за 1 килограмм = {priceFor1Kg} руб || Цена за Y кг = {priceForYKg} кг");
                    break;

                default:
                    break;
            }
        }
    }
}

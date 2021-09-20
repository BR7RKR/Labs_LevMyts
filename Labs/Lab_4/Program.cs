using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберети задание 4 лабораторной работы (1-5)");
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер четыре || задание один");

                    Console.Write("...\n...\n...\n...\n");

                    Console.Write("Введите длинну прямоугольника - ");
                    bool isLenght = float.TryParse(Console.ReadLine(), out float length);

                    Console.WriteLine(" ");

                    Console.Write("Введите ширину прямоугольника - ");
                    bool isWidth = float.TryParse(Console.ReadLine(), out float width);

                    if (isLenght == false || isWidth == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    Rectangle rectangle = new Rectangle
                    {
                        length = length,
                        width = width
                    };

                    Console.Write("...\n...\n...\n...\n");

                    float square = rectangle.FindSquare();
                    float perimetor = rectangle.FindPerimitor();

                    Console.WriteLine($"Площадь = {square} / Периметр = {perimetor}");
                    break;

                case ConsoleKey.D2:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер четыре || задание два");

                    Console.Write("...\n...\n...\n...\n");

                    Console.Write("Введите диаметр окружности - ");
                    bool isDiametor = float.TryParse(Console.ReadLine(), out float diametor);

                    if (isDiametor == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    Circle circle = new Circle
                    {
                        diametor = diametor
                    };

                    Console.Write("...\n...\n...\n...\n");

                    float circleLength = circle.FindLength();

                    Console.WriteLine($"Длина окружности = {circleLength}");
                    break;

                case ConsoleKey.D3:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер четыре || задание три");

                    Console.Write("...\n...\n...\n...\n");

                    Console.Write("Введите первое число - ");
                    bool isFirstNumber = float.TryParse(Console.ReadLine(), out float firstNumber);

                    Console.Write("Введите второе число - ");
                    bool isSecondNumber = float.TryParse(Console.ReadLine(), out float secondNumber);

                    if (isFirstNumber == false || isSecondNumber == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }

                    Console.Write("...\n...\n...\n...\n");

                    float arithmeticMean = (firstNumber + secondNumber) / 2;

                    Console.WriteLine($"Среднее арифметическое = {arithmeticMean}");

                    break;

                case ConsoleKey.D4:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер четыре || задание три");

                    Console.Write("...\n...\n...\n...\n");

                    Console.Write("Введите первое число - ");
                    bool isFirstNumber_4 = double.TryParse(Console.ReadLine(), out double firstNumber_4);

                    Console.Write("Введите второе число - ");
                    bool isSecondNumber_4 = double.TryParse(Console.ReadLine(), out double secondNumber_4);

                    if (isFirstNumber_4 == false || isSecondNumber_4 == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }
                    if (firstNumber_4 == 0 || secondNumber_4 == 0)
                    {
                        throw new Exception("ZeroNumbers");
                    }

                    Console.Write("...\n...\n...\n...\n");

                    double sqSum = Math.Pow(firstNumber_4, 2) + Math.Pow(secondNumber_4,2);
                    double sqAntiSum = Math.Pow(firstNumber_4, 2) - Math.Pow(secondNumber_4, 2);
                    double sqMult = Math.Pow(firstNumber_4, 2) * Math.Pow(secondNumber_4, 2);
                    double sqReverseMult = Math.Pow(firstNumber_4, 2) / Math.Pow(secondNumber_4, 2);

                    Console.WriteLine($"Сумма квадратов чисел = {sqSum} \n Разность квадратов чисел = {sqAntiSum} \n Произведение квадратов чисел = {sqMult} \n Частное квадратов чисел = {sqReverseMult} \n");

                    break;

                case ConsoleKey.D5:

                    Console.WriteLine();
                    Console.WriteLine("Лабораторна работа номер четыре || задание три");

                    Console.Write("...\n...\n...\n...\n");

                    Console.Write("Введите первое число - ");
                    bool isFirstNumber_5 = double.TryParse(Console.ReadLine(), out double firstNumber_5);

                    Console.Write("Введите второе число - ");
                    bool isSecondNumber_5 = double.TryParse(Console.ReadLine(), out double secondNumber_5);

                    if (isFirstNumber_5 == false || isSecondNumber_5 == false)
                    {
                        throw new Exception("WrongNumberFormat");
                    }
                    if (firstNumber_5 == 0 || secondNumber_5 == 0)
                    {
                        throw new Exception("ZeroNumbers");
                    }

                    Console.Write("...\n...\n...\n...\n");

                    double modSum = Math.Abs(firstNumber_5) + Math.Abs(secondNumber_5);
                    double modAntiSum = Math.Abs(firstNumber_5) - Math.Abs(secondNumber_5);
                    double modMult = Math.Abs(firstNumber_5) * Math.Abs(secondNumber_5);
                    double modReverseMult = Math.Abs(firstNumber_5) / Math.Abs(secondNumber_5);

                    Console.WriteLine($"Сумма квадратов чисел = {modSum} \n Разность квадратов чисел = {modAntiSum} \n Произведение квадратов чисел = {modMult} \n Частное квадратов чисел = {modReverseMult} \n");

                    break;

                default:
                    break;
            }
        }
    }
}

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

                    break;
                default:
                    break;
            }
        }
    }
}

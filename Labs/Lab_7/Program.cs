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
            //Подключаю обработку клавиш
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:

                    Console.Write(" - задание \n");
                    Console.Write("Введите значение угла в градусах a - ");

                    bool isNumber = float.TryParse(Console.ReadLine(), out float aDeg);
                    //вызываю собственные ошибки при нарушении правил ввода 
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

                    Console.Write(" - задание \n");
                    Console.Write("Введите значение угла в радианах a (без Пи) - ");

                    bool is_Number = float.TryParse(Console.ReadLine(), out float aRad);
                    //вызываю собственные ошибки при нарушении правил ввода 
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

                    Console.Write(" - задание \n");
                    Console.Write("Введите массу конфет в кг, которую вам надо купить Y - ");
                    bool isY = float.TryParse(Console.ReadLine(), out float Y);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isY == false)
                    {
                        throw _wrongNumberException;
                    }

                    float priceFor1Kg = aRub / xKg;
                    float priceForYKg = priceFor1Kg * Y;

                    Console.WriteLine($"Цена за 1 килограмм = {priceFor1Kg} руб || Цена за Y кг = {priceForYKg} кг");
                    break;

                case ConsoleKey.D4:

                    Console.Write(" - задание \n");
                    Console.Write("Введите скорость первого автомобиля в км/ч - ");
                    bool isVel_1 = float.TryParse(Console.ReadLine(), out float V1);
                    Console.Write("Введите скорость второго автомобиля в км/ч - ");
                    bool isVel_2 = float.TryParse(Console.ReadLine(), out float V2);
                    Console.Write("Введите начальное расстоянеие между транспортами в км - ");
                    bool isRange = float.TryParse(Console.ReadLine(), out float S);
                    Console.Write("Введите время, через которое будет проведено следующее сканирование в часах - ");
                    bool isTime = float.TryParse(Console.ReadLine(), out float T);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isVel_1 == false || isVel_2 == false || isRange == false || isTime == false)
                    {
                        throw _wrongNumberException;
                    }

                    float newS = ((V1 + V2) * T) + S;

                    Console.WriteLine($"Расстояние через {T} часов будет = {newS} км/ч");
                    break;

                case ConsoleKey.D5:

                    Console.Write(" - задание \n");
                    Console.Write("Введите число A - ");
                    bool isNum_1 = double.TryParse(Console.ReadLine(), out double A);
                    Console.Write("Введите число B - ");
                    bool isNum_2 = double.TryParse(Console.ReadLine(), out double B);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNum_1 == false || isNum_2 == false || A == 0)
                    {
                        throw _wrongNumberException;
                    }
                    //Функция метода написана в его описании
                    double x = Matrix.Solve(A, B);

                    Console.WriteLine($"Корень уравнения = {x}");
                    break;

                case ConsoleKey.D6:

                    Console.Write(" - задание \n");

                    Console.Write("Введите число A1 - ");
                    bool isNum1 = double.TryParse(Console.ReadLine(), out double A1);
                    Console.Write("Введите число B1 - ");
                    bool isNum2 = double.TryParse(Console.ReadLine(), out double B1);
                    Console.Write("Введите число С1 - ");
                    bool isNumC1 = double.TryParse(Console.ReadLine(), out double C1);
                    Console.Write("Введите число A2 - ");

                    bool isNum3 = double.TryParse(Console.ReadLine(), out double A2);
                    Console.Write("Введите число B2 - ");
                    bool isNum4 = double.TryParse(Console.ReadLine(), out double B2);
                    Console.Write("Введите число С2 - ");
                    bool isNumC2 = double.TryParse(Console.ReadLine(), out double C2);
                    //вызываю собственные ошибки при нарушении правил ввода 
                    if (isNum1 == false || isNum2 == false || isNum3 == false || isNum4 == false || isNumC1 == false || isNumC2 == false )
                    {
                        throw _wrongNumberException;
                    }
                    //Функция метода написана в его описании
                    Matrix.SolveWrite(A1, B1, C1, A2, B2, C2);
                    break;

                default:
                    break;
            }
        }
    }
}

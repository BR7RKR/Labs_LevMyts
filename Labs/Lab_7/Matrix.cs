using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public static class Matrix
    {
        /// <summary>
        /// Возвращает корень линейного уравнения
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double Solve(double A, double B)
        {
            return (-B) / A;
        }
        /// <summary>
        /// Выводит корни уравнения или сообщает об их отсутствии
        /// </summary>
        /// <param name="A1"></param>
        /// <param name="B1"></param>
        /// <param name="C1"></param>
        /// <param name="A2"></param>
        /// <param name="B2"></param>
        /// <param name="C2"></param>
        public static void SolveWrite(double A1, double B1, double C1, double A2, double B2, double C2)
        {
            if (A1 == 0 && B1 == 0 && C1 == 0 && A2 == 0 && B2 == 0 && C2 == 0)
            {
                Console.WriteLine("Корни уравнения могут быть любыми действительными числами");
            }
            else if ((A1 == 0 && B1 == 0 && C1 == 0) || (A2 == 0 && B2 == 0 && C2 == 0))
            {
                Console.WriteLine("Система несовместна");
            }
            else
            {
                //Использую теорему Крамера для решения системы с двумя неизвестными
                double delta = A1 * B2 - A2 * B1;
                double deltaX = C1 * B2 - C2 * B1;
                double deltaY = A1 * C2 - A2 * C1;

                if (delta == 0 && deltaX == 0 && deltaY == 0)
                {
                    if (A1 != 0 || B1 != 0)
                    {
                        Console.WriteLine($"x = {C1} - {B1}y / {A1}, где Y любое действительное число");
                    }
                    else if (A2 != 0 || B2 != 0)
                    {
                        Console.WriteLine($"x = {C2} - {B2}y / {A2}, где Y любое действительное число");
                    }
                }
                else if (delta != 0 && (deltaX == 0 || deltaY == 0 || deltaX != 0 || deltaY != 0))
                {
                    double x = deltaX / delta;
                    double y = deltaY / delta;
                    Console.WriteLine($"Корни уравнения x, y = {x}, {y}");
                }
                else
                {
                    Console.WriteLine("Система несовместна");
                }
            }
        }
    }
}

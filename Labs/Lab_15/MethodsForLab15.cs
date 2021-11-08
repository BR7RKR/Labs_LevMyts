using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    public static class MethodsForLab15
    {
        //Сделал метод и 2 перегрузки к нему, чтобы принимать любые типы вещественных чисел
        public static double Power3A(in double inputNumber)
        {
            double outputNumber = inputNumber * inputNumber * inputNumber;
            return outputNumber;
        }
        public static float Power3A(in float inputNumber)
        {
            float outputNumber = inputNumber * inputNumber * inputNumber;
            return outputNumber;
        }
        public static decimal Power3A(in decimal inputNumber)
        {
            decimal outputNumber = inputNumber * inputNumber * inputNumber;
            return outputNumber;
        }

        //Сделал метод и 2 перегрузки к нему, чтобы принимать любые типы вещественных чисел
        public static int Sign(in double inputNumber)
        {
            if (inputNumber < 0)
            {
                return -1;
            }
            else if (inputNumber > 0 )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int Sign(in decimal inputNumber)
        {
            if (inputNumber < 0)
            {
                return -1;
            }
            else if (inputNumber > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int Sign(in float inputNumber)
        {
            if (inputNumber < 0)
            {
                return -1;
            }
            else if (inputNumber > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Сделал метод и 1 перегрузку к нему, чтобы принимать разные типы вещественных чисел
        public static double RingS(in double radius1, in double radius2)
        {
            var areaSmall = Math.PI * (Math.Min(radius1, radius2) * Math.Min(radius1, radius2));
            var areaBig = Math.PI * (Math.Max(radius1, radius2) * Math.Max(radius1, radius2));
            return areaBig - areaSmall;
        }
        public static double RingS(in float radius1, in float radius2)
        {
            var areaSmall = Math.PI * (Math.Min(radius1, radius2) * Math.Min(radius1, radius2));
            var areaBig = Math.PI * (Math.Max(radius1, radius2) * Math.Max(radius1, radius2));
            return areaBig - areaSmall;
        }

        //Сделал метод и 2 перегрузки к нему, чтобы принимать любые типы вещественных чисел
        public static byte Quarter(in float x, in float y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else 
            {
                return 2;
            }
        }
        public static byte Quarter(in double x, in double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }
        public static byte Quarter(in decimal x, in decimal y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        
        public static double Fact2(ulong number)
        {
            ulong res;
            if (number % 2 != 0)
            {
                res = 1;
                for (ulong i = 3; i <= number; i += 2)
                {
                    res *= i;
                }
            }
            else
            {
                res = 2;
                for (ulong i = 4; i <= number; i += 2)
                {
                    res *= i;
                }
            }
            return res;
        }
    }
}

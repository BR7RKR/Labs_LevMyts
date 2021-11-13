using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //перестановка местами двух элементов в массиве
            static void Swap(int[] array, int i, int j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            static void GnomeSort(int[] inArray)
            {
                int i = 1;
                int j = 2;
                while (i < inArray.Length)
                {
                    if (inArray[i - 1] <= inArray[i])
                    {
                        i = j;
                        j += 1;
                    }
                    else
                    {
                        Swap(inArray, i - 1, i);
                        i -= 1;
                        if (i == 0)
                        {
                            i = j;
                            j += 1;
                        }
                    }
                }
            }

            int[] arr = new int[] { 1, 322, 5, -1, 7, 1 };

            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            
        }
    }

    public struct Point
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}

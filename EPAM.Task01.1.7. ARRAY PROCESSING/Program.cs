using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task01._1._7.ARRAY_PROCESSING
{
    class Program
    {
        static int[] array;
        static int n = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            array = new int[AskArrayLength()];
            GererateArray(n);
            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("Минимальное значение массива: {0}", FindMin(array));
            Console.WriteLine("Максимальное значение массива: {0}", FindMax(array));
            Console.WriteLine();
            PrintArray(SortArray(array));
            Console.ReadLine();
        }

        public static int AskArrayLength()
        {
            Console.Write("Введите количество элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100)
            {
                Console.Write("Введите количество элементов массива: ");
                if (n > 100) Console.WriteLine("\nСлишком много элементов. Попробуйте менее 100...");
            }

            return n;
        }

        public static int[] GererateArray(int n) {
            Random randomInt = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = randomInt.Next(n);
            }

            return array;
        }

        public static void PrintArray(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        public static int FindMax(int[] array) {
            int Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max) Max = array[i];
            }

            return Max;
        }
        public static int FindMin(int[] array)
        {
            int Min=array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min) Min = array[i];
            }

            return Min;
        }

        public static int[] SortArray(int[] SortedArray) {
            

            for (int i = 0; i< SortedArray.Length; i++)
            {
                for (int j = i+1; j < SortedArray.Length; j++)
                {
                    if (SortedArray[i] > SortedArray[j]) {
                        var tmp = SortedArray[i];
                        SortedArray[i] = SortedArray[j];
                        SortedArray[j] = tmp;
                    }
                }
            }
            return SortedArray;
        }
    }
}

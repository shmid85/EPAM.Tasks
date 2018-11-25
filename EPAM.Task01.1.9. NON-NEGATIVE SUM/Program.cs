using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._9.NON_NEGATIVE_SUM
{
    class Program
    {
        static int n = 0;
        static int[] array;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AskArrayLength();
            array = new int[n];
            GererateArray(n);
            PrintArray();
            SumOfPositive();
            Console.ReadLine();
        }

        public static int AskArrayLength()
        {
            Console.Write("Введите количество элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100)
            {
                if (n > 100) Console.WriteLine("\nСлишком много элементов. Попробуйте менее 100...");
                Console.Write("Введите количество элементов массива: ");
            }

            return n;
        }

        public static int[] GererateArray(int n)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
                 array[i] = random.Next(-2 * n, 2 * n);
            return array;
        }

        public static void PrintArray()
        {
            Console.WriteLine("......");
            for (int i = 0; i < n; i++)
                 Console.WriteLine(array[i]);
            Console.WriteLine("......");
        }

        public static void SumOfPositive()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (array[i] > 0) sum += array[i];
            Console.WriteLine("Сумма положительных чисел массива равна: {0}", sum);
        }
    }
}

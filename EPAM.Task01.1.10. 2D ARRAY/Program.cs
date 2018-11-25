using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._10._2D_ARRAY
{
    class Program
    {
        static int n = 0;
        static int[,] array;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AskArrayLength();
            array = new int[n,n];
            GererateArray(n);
            PrintArray();
            SumOfElementsOnEvenPositions();
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

        public static int[,] GererateArray(int n)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    array[i,j] = random.Next(2 * n);
            return array;
        }

        public static void PrintArray()
        {
            Console.WriteLine("......");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(array[i, j]);
                Console.WriteLine("");
            }   
            Console.WriteLine("......");
        }

        public static void SumOfElementsOnEvenPositions()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if ((i+j)%2 ==0) sum += array[i,j];
            Console.WriteLine("Сумма элементов массива на четных позициях равна: {0}", sum);
        }
    }
}

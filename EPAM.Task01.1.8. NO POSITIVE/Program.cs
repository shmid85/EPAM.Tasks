using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._8.NO_POSITIVE
{
    class Program
    {
        static int n=0;
        static int[,,] array;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AskArrayLength();
            array = new int[n, n, n];
            GererateArray(n);
            PrintArray();
            KillPositive();
            PrintArray();


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

        public static int[,,] GererateArray(int n)
        {
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        array[i, j, k] = random.Next(-2*n, 2*n);
            return array;
        }

        public static void PrintArray() {
            Console.WriteLine("......");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        Console.WriteLine(array[i, j, k]);
            Console.WriteLine("......");
        }

        public static void KillPositive() {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        if(array[i, j, k] > 0) array[i, j, k] = 0;
        }
    }
}

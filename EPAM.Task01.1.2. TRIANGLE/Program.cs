using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._2.TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите целое положительное чисо N для отрисовки");
            
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Введите целое положительное чисо N");
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(new String('*', i));
            }
            Console.ReadLine();
        }
    }
}

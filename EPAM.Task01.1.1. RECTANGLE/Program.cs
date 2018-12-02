using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._1.RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Вычисление площади прямоугольника");
            
            do
            {
                Console.WriteLine("Введите целое положительное число А");
            } while (!int.TryParse(Console.ReadLine(), out a));


            do {
                Console.WriteLine("Введите целое положительное число B");
            }while (!int.TryParse(Console.ReadLine(), out b));

             if (b <= 0) throw new ArgumentException("Сторона должна быть положительным целым числом", nameof(b));

            Console.WriteLine("Площадь прямоугольника {0}", a*b);
            Console.ReadLine();
        }
    }
}

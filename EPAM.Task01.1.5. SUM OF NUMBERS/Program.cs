using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task01._1._5.SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }  
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сумма чисел до 1000 кратных 3 или 5 равна: {0}", sum);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task01._1._4.X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Введите целое положительное чисо N");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Введите целое положительное чисо N");
            }

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine(new String(' ', n - j) + new String('*', (j*2+1)));
                }
                
            }
            Console.ReadLine();
        }
    }
}

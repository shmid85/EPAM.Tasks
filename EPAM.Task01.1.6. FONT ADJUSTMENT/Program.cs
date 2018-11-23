using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.TAsk01._1._6.FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
          
            int n = 0;
            FontStyle fs = new FontStyle();
                               
            while (n != 666)
            {
                Console.WriteLine("Параметры надписи: {0}", fs);
                Console.WriteLine("Введите");
                Console.WriteLine(" 1: bold");
                Console.WriteLine(" 2: italic");
                Console.WriteLine(" 3: underline");
                int.TryParse(Console.ReadLine(), out n);

                switch (n) {
                    case 1:
                        fs ^= FontStyle.bold;
                        break;
                    case 2:
                        fs ^= FontStyle.italic;
                        break;
                    case 3:
                        fs ^= FontStyle.underline;
                        break;
                }
            }
        }
        
        [Flags]
        enum FontStyle
        {
            None,
            bold,
            italic,
            underline =4
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.Task01._1._12.CHAR_DOUBLER
{
    class Program
    {
        private static string String1;
        private static string String2;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AskStrings();
            DoubleChar();
            Console.ReadLine();
        }

        public static void AskStrings()
        {
            Console.WriteLine("Введите первую строку:");
            String1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            String2 = Console.ReadLine();
        }

        public static void DoubleChar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in String1)
            {
                if (String2.Contains(ch.ToString()))
                {
                    sb.Append(ch, 2);
                }
                else
                    sb.Append(ch);
            }
            Console.WriteLine(sb.ToString());
        }


            /*
            public static void DoubleChar()
            {
                char[] charString1 = String1.ToCharArray();
                char[] charString2 = String2.ToCharArray();
                bool containsChar = false;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < charString1.Length; i++)
                {

                    for (int j = 0; j < charString2.Length; j++)
                    {
                        if (charString1[i] == charString2[j]) {
                            containsChar = true;
                            break;
                        };

                    }

                    if (containsChar)
                    {
                        sb.Append(charString1[i], 2);
                        containsChar = false;
                    }
                    else
                        sb.Append(charString1[i]);
                }
                Console.WriteLine(sb.ToString());

            }
            */        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM.TASK01._1._11.AVERAGE_STRING_LENGTH
{
    class Program
    {
        
        private static string userString;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            AskString();
            CalculateAverageLengthOfWord();
           Console.ReadLine();
        }

        public static  void AskString() {
            Console.WriteLine("Введите строку:");
            userString = Console.ReadLine();
        }

        
        public static void CalculateAverageLengthOfWord() {
            int amoundOfLetters = 0;
            int amoundOfWords = 0;

            char[] userStringCharArray = userString.ToCharArray();
                        
            for (int i = 0; i < userStringCharArray.Length; i++)
            {
                   if ( !Char.IsPunctuation(userStringCharArray[i]) && !Char.IsSeparator(userStringCharArray[i]) )             
                    amoundOfLetters++;
                if (Char.IsPunctuation(userStringCharArray[i]) || Char.IsSeparator(userStringCharArray[i]))
                    amoundOfWords++;

            }

            Console.WriteLine("Количество букв {0}, количество слов {1}", amoundOfLetters, amoundOfWords);
            Console.WriteLine("Средняя длинна слова во введеной вами строке {0}", (float)(amoundOfLetters/amoundOfWords));
        }                
    }
}

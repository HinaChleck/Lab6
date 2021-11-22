using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        /*Ввести с клавиатуры предложение.Предложение представляет собой слова, разделенные пробелом.
         * Знаки препинания не используются. Найти самое длинное слово в строке.*/

        {
            Console.WriteLine("Введите предложение без знаков препинания:\n");
            string s = Console.ReadLine();

            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            for (int i = 0; i < (words.Length-1); i++)
          
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    string t = words[i];                   
                    if (words[i].Length < words[j].Length)
                    {
                        words[i] = words[j];
                        words[j] = t;
                    }      
                }
            }

            Console.WriteLine("\nСамое длинное слово в предложении - \"{0}\". " , words[0]);

            Console.ReadLine();
        }
    }
}

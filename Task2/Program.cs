using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)

        /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
         * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).*/
        {
            string sentence = Console.ReadLine();
            string sToLower = sentence.ToLower();
            string noSpaces = sToLower.Replace(" ","");
            //Console.WriteLine(noSpaces);
            int l = noSpaces.Length;
            //string half1, half2;
            //half1 = noSpaces.Substring(0, l / 2);
            
            /*if (l%2!=0)
            {
                half2 =noSpaces.Substring(l/2+1);
            }
            else
            {
                half2 = noSpaces.Substring(l / 2);
            }
            */
            bool palindrom=true;
                       
            /*for (int i = 0; i < l/2; i++)
            {              
                if (half1[i]!=half2[l/2-1-i]) 
                {
                    palindrom=false;
                    Console.Write("{0}!={1}", half1[i],half2[l/2-1-i]) ;
                    break;
                }
                Console.WriteLine("{0}={1}", half1[i],half2[l/2-1-i]);
            }
            */

            for (int i = 0; i < l / 2; i++)
            {
                if (noSpaces[i] != noSpaces[l - 1 - i])
                {
                    palindrom = false;
                    Console.Write("{0}!={1}", noSpaces[i], noSpaces[l  - 1 - i]);
                    break;
                }
                Console.WriteLine("{0}={1}", noSpaces[i], noSpaces[l  - 1 - i]);
            }


            if (palindrom)
            Console.WriteLine("\nПредложение - палиндром");
            else
            Console.WriteLine("\nПредложение - не палиндром");

           Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на английском строчными буквами");
            string shifr = Console.ReadLine();
            int sdvig = 3;
            StringBuilder sb = new StringBuilder();
            foreach (char c in shifr)
            {
                if (c >= 'a' && c <= 'z')
                {
                    char cezar = (char)(((c - 'a' + sdvig) % 26) + 'a');
                    sb.Append(cezar);
                }               
            }

            Console.WriteLine($"Зашифровано: {sb}");

        }
    }
}
    


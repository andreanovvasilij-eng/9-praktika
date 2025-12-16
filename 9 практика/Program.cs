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
            // ((c - 'a' + sdvig) % 26) —добавляет к индексу сдвиг и берет остаток от деления на 26.
            // Это обеспечивает циклический переход в алфавите.
            // Например, если c = 'z', то c - 'a' + sdvig будет равно 25 + 3 = 28, и 28 % 26 даст 2, что соответствует букве 'c'.
            // ((c - 'a' + sdvig) % 26) + 'a' — переводит индекс обратно в символ, добавляя к нему 'a', чтобы получить зашифрованную букву.
            // h(7 в алфавите)->k(10 в алфавите, 7 + 3 = 10)
            // e(4 в алфавите)->h(7 в алфавите, 4 + 3 = 7)
            // l(11 в алфавите)->o(14 в алфавите, 11 + 3 = 14)
            // l(11 в алфавите)->o(14 в алфавите, 11 + 3 = 14)
            // o(14 в алфавите)->r(17 в алфавите, 14 + 3 = 17)

        }
    }
}
    


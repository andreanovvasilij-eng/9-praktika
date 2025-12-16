using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string LowerWord = word.ToLower();
            char[] charArray = LowerWord.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            if (LowerWord == reversed)
            {
                Console.WriteLine($"Слово {word} - палиндромом");
            }
            else
            {
                Console.WriteLine($"Слово {word} не является палиндромом");            
            }
        }
    }
}

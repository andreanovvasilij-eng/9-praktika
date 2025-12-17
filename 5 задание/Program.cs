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
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().ToLower();
            int left = 0;
            int right = word.Length - 1;
            bool Palindrom = true;
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    Palindrom = false;
                    break;
                }
                left++;
                right--;
            }
            if (Palindrom)
            {
                Console.WriteLine($"Слово {word} полидром");
            }
            else
            {
                Console.WriteLine($"Слово {word} не полидром");
            }
        }
    }
}

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
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);  // Меняет массив на месте
            string reversed = new string(charArray);
            if (word == reversed)
             return;
            Console.WriteLine(reversed);
        }
    }
}

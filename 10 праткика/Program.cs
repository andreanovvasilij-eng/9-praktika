using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_праткика
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Random random = new Random();
         StringBuilder password = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                char lowerLetter = (char)('a' + random.Next(0, 26));
                password.Append(lowerLetter);
            }
            for (int i = 0; i < 3; i++)
            {
                char digit = (char)('0' + random.Next(0, 10));
                password.Append(digit);
            }
            for (int i = 0; i < 2; i++)
            {
                char upLetter = (char)('A' + random.Next(0, 26));
                password.Append(upLetter);
            }

            Console.WriteLine("Пример возможного пароля: " + password);

        }
    }
}

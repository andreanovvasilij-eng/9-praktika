using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "яблоко,банан ,aпельсин,киви, груша";
            string[] fruitArray = fruits.Split(',');
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            
            for (int i = 0; i < fruitArray.Length; i++)
            {
                fruitArray[i] = fruitArray[i].Trim();
            }
            Console.WriteLine();
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            Console.WriteLine();
            Array.Sort(fruitArray);
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            Console.WriteLine();
            string result = string.Join("; ", fruitArray);
            Console.WriteLine($"Ожидаемый результат:" + result);
            
        }
    }
}

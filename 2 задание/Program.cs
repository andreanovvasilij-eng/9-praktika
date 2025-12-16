using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# это современный язык программирования.";
            int len = text.Length;
            string[] words = text.Split(' ');
            int wordCount = words.Length;
            Console.WriteLine(wordCount);         
            int position = text.IndexOf("язык");
            Console.WriteLine(position);
            bool start = text.StartsWith("C#");
            Console.WriteLine("Текст начинается с с#: " + start);

        }
    }
}

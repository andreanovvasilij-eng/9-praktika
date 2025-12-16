using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "анна";
            string NameFormat2 = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            string city = "москва";
            string CITY= city.ToUpper();
            Console.WriteLine(NameFormat2);
            Console.WriteLine (CITY);            
            Console.WriteLine($"Привет, {NameFormat2} из {CITY}!");

        }
    }
}

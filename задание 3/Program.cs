using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "+79161234567";
            string Country = phone.Substring(0, 2);
            string Operator = phone.Substring(2, 3);
            string number123 = phone.Substring(5, 3);
            string number45 = phone.Substring(8, 2);
            string number67 = phone.Substring(10, 2);
            string phoneFormat2 = $"{Country} ({Operator}) {number123}-{number45}-{number67} ";
            Console.WriteLine(phoneFormat2);
        }
    }
}

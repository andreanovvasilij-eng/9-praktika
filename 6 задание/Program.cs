using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Числа");
            sb.Append("1,2,3,4,5,6,7,8,9,10,");
            sb.Append(" ");
            sb.Insert(25, ".");         
            string sb = sb.Substring(sb.Length - 1);
            Console.WriteLine(sb.ToString());

        }
    }
}

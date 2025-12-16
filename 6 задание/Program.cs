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
                StringBuilder sb = new StringBuilder("Числа: ");
                for (int i = 1; i <= 10; i++)
                {
                    sb.Append(i);
                    if (i < 10)
                    {
                        sb.Append(',');
                    }
                }
                sb.Append('.');
                Console.WriteLine(sb.ToString());
        }
    }
}
        
    
    


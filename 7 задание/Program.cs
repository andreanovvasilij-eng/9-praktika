using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    sb.Append($"{i} x {j} = {i * j}");                  
                    sb.AppendLine();
                }
                if (i < 5)
                {
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}



            
    


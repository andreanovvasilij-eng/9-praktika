using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "user.example@gmail.com";
            Console.WriteLine(email);        
            if (email.Contains("@"))
            {
                int index = email.IndexOf("@");
                string user = email.Substring(0, index);
                string gmail = email.Substring(index + 1);
                string star = new string('*', user.Length);
                string email2 = $"{star}@{gmail}";
                Console.WriteLine($"Скрытый email: {email2}");
            }
        }
    }
}

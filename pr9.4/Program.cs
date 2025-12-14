using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "user.example@gmail.com";
            bool sob = email.Contains("@");
            Console.WriteLine(email);
            Console.WriteLine(sob);
            string[] emaill = email.Split('@');
            string username = new string('*', emaill[0].Length);
            string emailll = username + "@" + emaill[1];
            Console.WriteLine(emailll);
        }
    }
}

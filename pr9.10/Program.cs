
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pr9._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                char low = Convert.ToChar(r.Next(97, 123));
                sb.Append(low);
            }
            for (int i = 0; i < 3; i++)
            {
                char zif = Convert.ToChar(r.Next(48, 58));
                sb.Append(zif);
            }
            for (int i = 0; i < 2; i++)
            {
                char high = Convert.ToChar(r.Next(65, 91));
                sb.Append(high);
            }
            string password = sb.ToString();
            Console.WriteLine(password);
            char[] mas = password.ToCharArray();
            for (int i = mas.Length - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);  
                char t = mas[i];
                mas[i] = mas[j];
                mas[j] = t;
            }
            StringBuilder sb1 = new StringBuilder();
            foreach (char c in mas)
            {
                sb1.Append(c);
            }
            Console.WriteLine(sb1.ToString());
        }
    }
}

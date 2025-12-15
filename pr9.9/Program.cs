using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace pr9._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите слово на английском");
            string word = Console.ReadLine();
            string slovo = word.Trim().ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char s in slovo)
            {
                if (s >= 'a' && s <= 'z')
                {
                    char c = Convert.ToChar(s + 3);
                    if (c > 'z')
                    {
                        c = Convert.ToChar(c - 26);
                    }
                    sb.Append(c);
                }
                else
                {
                    sb.Append(s);
                }
            }
            string shifr = sb.ToString();
            Console.WriteLine($"Зашифрованное слово: {shifr}");
        }
    }
}

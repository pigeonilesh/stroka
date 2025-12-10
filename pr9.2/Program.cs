using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# это современный язык программирования.";
            int len = text.Length;
            string[] slova = text.Split(' ');
            int lens = slova.Length;
            Console.WriteLine(text);
            Console.WriteLine(len);
            Console.WriteLine(lens);
        }
    }
}

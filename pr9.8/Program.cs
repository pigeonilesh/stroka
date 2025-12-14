using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "яблоко, банан , апельсин,киви, груша";
            string[] mas = fruits.Split(',');
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i].Trim();
            }
            Array.Sort(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            string s = string.Join("; ", mas);
            Console.WriteLine(s);
        }
    }
}

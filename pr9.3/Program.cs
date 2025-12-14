using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "+79161234567";
            string f1 = phone.Substring(0, 2);
            string f2 = phone.Substring(2, 3);
            string f3 = phone.Substring(5, 3);
            string f4 = phone.Substring(8, 2);
            string f5 = phone.Substring(10, 2);
            Console.WriteLine($"{f1} ({f2}) {f3}-{f4}-{f5}");
        }
    }
}

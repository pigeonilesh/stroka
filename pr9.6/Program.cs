    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1,");
            sb.Append("2,");
            sb.Append("3,");
            sb.Append("4,");
            sb.Append("5,");
            sb.Append("6,");
            sb.Append("7,");
            sb.Append("8,");
            sb.Append("9,");
            sb.Append("10,");
            sb.Remove(sb.Length - 1, 1);
            sb.Insert(0, "Числа: ");
            sb.Insert(sb.Length, ".");
            Console.WriteLine(sb.ToString());
        }
    }
}

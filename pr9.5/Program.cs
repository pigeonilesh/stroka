using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Проверка на полидромность");
            Console.WriteLine($"Введите слово");
            string slovo = Console.ReadLine();
            string word = slovo.Trim().ToLower();
            int i = 0;
            int j = word.Length - 1;
            while (i < j && word[i] == word[j])
            {
                i++;
                j--;
            }
            Console.WriteLine(i >= j ? $"Слово {slovo.Trim()} является палиндромом" : $"Слово {slovo.Trim()} не является палиндромом");
        }
    }
}

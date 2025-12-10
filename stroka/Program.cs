using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace stroka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            char digit = '2';
            char symbol = '$';

            char heart = '\u2665';
            Console.WriteLine(heart);

            char.IsLetter('H');
            char.IsDigit('2');
            char.ToLower('H');
            char.ToUpper('a');

            string name = "Илья";
            string group = "223 СИС";
            string emptyString = " ";
            Console.WriteLine(name + emptyString + group);

            Console.WriteLine($"Студет {name}, обучается в группе {group}");

            int len = group.Length;
            char firstLetter = name[0];

            string sentence = "Кот сидит на трубе";
            int position = sentence.IndexOf("сидит");
            bool contains = sentence.Contains("на");
            bool start = sentence.StartsWith("Кот");
            bool end = sentence.EndsWith("трубе");

            string mixed = "ПрИвет";
            string lower = mixed.ToLower();
            Console.WriteLine(mixed.ToLower());
            Console.WriteLine(lower);

            string withSpace = "     text     ";
            Console.WriteLine(withSpace);
            Console.WriteLine(withSpace.Trim());
            Console.WriteLine(withSpace.TrimStart());
            Console.WriteLine(withSpace.TrimEnd());

            string original = "Я люблю яюлоки";
            string replaced = original.Replace("яблоки", "груши");
            Console.WriteLine(original);
            Console.WriteLine(replaced);

            string kanzTovars = "карандаш,ручка,линейка,тетрадь";
            string[] kanzTovArray = kanzTovars.Split(',');

            string[] words = {"Привет", "223", "группа!"};
            string sentecnce1 = string.Join(" ", words);
            string sentecnce2 = string.Join(", ", words);
            Console.WriteLine(sentecnce1);
            Console.WriteLine(sentecnce2);

            StringBuilder sb = new StringBuilder();
            sb.Append("Привет");
            sb.Append(" ");
            sb.Append("мир!");
            sb.Insert(6, "Дорогой");
            sb.Replace("Дорогой", " любимый");
            string finalString = sb.ToString();
            Console.WriteLine(finalString);
        }
    }
}

using System;
using System.Collections.Generic;

namespace StartUp
{
    public class ListProcessingMethods
    {
        public static void Append(string word, List<string> list)
        {
            list.Add(word);
            Console.WriteLine(string.Join(" ", list));
        }

        public static void Prepend(string word, List<string> list)
        {
            list.Insert(0, word);
            Console.WriteLine(string.Join(" ", list));
        }

        public static void Reverse(List<string> list)
        {
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

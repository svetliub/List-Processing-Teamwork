using System;
using System.Collections.Generic;

namespace StartUp
{
    public class ListProcessingMethods
    {
        public static void Append(string word, List<string> list)
        {
            list.Add(word);
            PrintList(list);
        }

        public static void Prepend(string word, List<string> list)
        {
            list.Insert(0, word);
            PrintList(list);
        }

        public static void Reverse(List<string> list)
        {
            list.Reverse();
            PrintList(list);
        }

        public static void Insert(int index, string word, List<string> list)
        {
            if (index < 0 || index > list.Count - 1)
            {
                Console.WriteLine($"Error: invalid index {index}");
                return;
            }

            list.Insert(index, word);
            PrintList(list);
        }

        private static void PrintList(List<string> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

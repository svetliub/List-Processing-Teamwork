using System;
using System.Collections.Generic;

namespace StartUp
{
    public class ListProcessingMethods
    {
        public static void Append(List<string> list, List<string> commands)
        {
            if (commands.Count != 2)
            {
                ErrorMessage();
                return;
            }

            string word = commands[1];
            list.Add(word);
            PrintList(list);
        }

        public static void Prepend(List<string> list, List<string> commands)
        {
            if (commands.Count != 2)
            {
                ErrorMessage();
                return;
            }

            string word = commands[1];
            list.Insert(0, word);
            PrintList(list);
        }

        public static void Reverse(List<string> list, List<string> commands)
        {
            if (commands.Count != 1)
            {
                ErrorMessage();
                return;
            }
            list.Reverse();
            PrintList(list);
        }

        public static void Insert(List<string> list, List<string> commands)
        {
            if (commands.Count != 3)
            {
                ErrorMessage();
                return;
            }

            if (!int.TryParse(commands[1], out var n))
            {
                ErrorMessage();
                return;
            }

            int index = int.Parse(commands[1]);
            string word = commands[2];

            if (index < 0 || index > list.Count - 1)
            {
                Console.WriteLine($"Error: invalid index {index}");
                return;
            }

            list.Insert(index, word);
            PrintList(list);
        }

        public static void Delete(List<string> list, List<string> commands)
        {
            if (commands.Count != 2)
            {
                ErrorMessage();
                return;
            }

            if (!int.TryParse(commands[1], out var n))
            {
                ErrorMessage();
                return;
            }

            int index = int.Parse(commands[1]);

            if (index < 0 || index > list.Count - 1)
            {
                Console.WriteLine($"Error: invalid index {index}");
                return;
            }
            list.RemoveAt(index);
            PrintList(list);
        }

        private static void PrintList(List<string> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }

        private static void ErrorMessage()
        {
            Console.WriteLine("Error: invalid command parameters");
        }
    }
}

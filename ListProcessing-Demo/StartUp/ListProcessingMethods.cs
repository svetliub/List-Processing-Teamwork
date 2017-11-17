using System;
using System.Collections.Generic;

namespace StartUp
{
    public class ListProcessingMethods
    {
        public static void Append(List<string> list, List<string> commands)
        {
            if (IsValidCommandsLength(commands, 2))
            {
                string word = commands[1];
                list.Add(word);
                PrintList(list);
            }
            else
            {
                ErrorMessage();
            }
        }

        public static void Prepend(List<string> list, List<string> commands)
        {
            if (IsValidCommandsLength(commands, 2))
            {
                string word = commands[1];
                list.Insert(0, word);
                PrintList(list);
            }
            else
            {
                ErrorMessage();
            }
        }

        public static void Reverse(List<string> list, List<string> commands)
        {
            if (IsValidCommandsLength(commands, 1))
            {
                list.Reverse();
                PrintList(list);
            }
            else
            {
                ErrorMessage();
            }
        }

        public static void Insert(List<string> list, List<string> commands)
        {
            if (IsValidCommandsLength(commands, 3))
            {
                int index;
                string word = commands[2];

                if (!int.TryParse(commands[1], out index))
                {
                    ErrorMessage();
                    return;
                }

                if (index < 0 || index > list.Count - 1)
                {
                    Console.WriteLine($"Error: invalid index {index}");
                    return;
                }

                list.Insert(index, word);
                PrintList(list);
            }
            else
            {
                ErrorMessage();
            }
        }

        public static void Delete(List<string> list, List<string> commands)
        {
            if (IsValidCommandsLength(commands, 2))
            {
                int index;

                if (!int.TryParse(commands[1], out index))
                {
                    ErrorMessage();
                    return;
                }

                if (index < 0 || index > list.Count - 1)
                {
                    Console.WriteLine($"Error: invalid index {index}");
                    return;
                }

                list.RemoveAt(index);
                PrintList(list);
            }
            else
            {
                ErrorMessage();
            }
        }

        private static void PrintList(List<string> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }

        private static void ErrorMessage()
        {
            Console.WriteLine("Error: invalid command parameters");
        }

        private static bool IsValidCommandsLength(List<string> commands, int length)
        {
            if (commands.Count != length)
            {
                return false;
            }

            return true;
        }
    }
}

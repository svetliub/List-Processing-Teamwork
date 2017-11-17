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

        public static void RollLeft(List<string> list)
        {
            var swapVar = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[list.Count - 1] = swapVar;

            PrintList(list);
        }

        public static void RollRight(List<string> list)
        {
            var swapVar = list[list.Count - 1];

            for (int i = list.Count - 1; i > 0; i--)
            {
                list[i] = list[i - 1];
            }
            list[0] = swapVar;

            PrintList(list);
        }

        public static void Sort(List<string> list,List<string> inputList)
        {
            if (inputList.Count != 1)
            {
                ErrorMessage();
            }
            else
            {
                list.Sort();

                PrintList(list);
            }
        }

        public static void Count(List<string> list,List<string> inputList)
        {
            if (inputList.Count != 2)
            {
                ErrorMessage();
            }
            else
            {
                int count = 0;
                var stringSearched = inputList[1];

                foreach (var item in list)
                {
                    if (item == stringSearched)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}

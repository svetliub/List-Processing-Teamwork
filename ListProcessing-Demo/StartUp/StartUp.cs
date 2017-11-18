using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class StartUp
    {
        static void Main()
        {
            List<string> stringList = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(" ", stringList));

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                List<string> inputList = input.Split().ToList();
                
                string command = inputList[0];

                Switching(stringList, inputList, command);

                input = Console.ReadLine();
            }

            Console.WriteLine("Finished");
        }

        static void Switching(List<string> stringList,List<string> inputList,string command)
        {
            switch (command)
            {
                case "append":
                    ListProcessingMethods.Append(stringList, inputList);
                    break;
                case "prepend":
                    ListProcessingMethods.Prepend(stringList, inputList);
                    break;
                case "reverse":
                    ListProcessingMethods.Reverse(stringList, inputList);
                    break;
                case "insert":
                    ListProcessingMethods.Insert(stringList, inputList);
                    break;
                case "delete":
                    ListProcessingMethods.Delete(stringList, inputList);
                    break;
                case "roll":
                    RollType(stringList, inputList);
                    break;
                case "sort":
                    ListProcessingMethods.Sort(stringList,inputList);
                    break;
                case "count":
                    ListProcessingMethods.Count(stringList, inputList);
                    break;
                case "end":
                    Console.WriteLine("Error: invalid command parameters");
                    break;
                default:
                    Console.WriteLine("Error: invalid command");
                    break;
            }
        }

        static void RollType(List<string> stringList, List<string> inputList)
        {
            if (inputList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                string rollType = inputList[1];
                if (rollType == "left")
                {
                    ListProcessingMethods.RollLeft(stringList);
                }
                else if (rollType == "right")
                {
                    ListProcessingMethods.RollRight(stringList);
                }
                else
                {
                    Console.WriteLine("Error: invalid command parameters");
                }
            }
        }
    }
}

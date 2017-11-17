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
                        break;
                    case "sort":
                        break;
                    case "count":
                        break;
                    default:
                        Console.WriteLine("Error: invalid command");
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Finished");
        }
    }
}

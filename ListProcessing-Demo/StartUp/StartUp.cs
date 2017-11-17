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
                string word = string.Empty;

                switch (command)
                {
                    case "append":
                        word = inputList[1];
                        ListProcessingMethods.Append(word, stringList);
                        break;
                    case "prepend":
                        word = inputList[1];
                        ListProcessingMethods.Prepend(word, stringList);
                        break;
                    case "reverse":
                        break;
                    case "insert":
                        break;
                    case "delete":
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

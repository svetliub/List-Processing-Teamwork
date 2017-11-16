using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class ListProcessingMethods
    {
        public static void Append(string word, List<string> list)
        {
            list.Add(word);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

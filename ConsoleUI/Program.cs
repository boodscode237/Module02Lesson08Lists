using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intialize a list
            List<string> firstNames = new List<string>();

            firstNames.Add("John");
            firstNames.Add("Doe");
            firstNames.Add("Louis");
            firstNames.Add("Johanne");

            Console.WriteLine($"The second element is {firstNames[1]}");
            firstNames.Remove("John");
            Console.WriteLine($"The second element is {firstNames[1]}");
            firstNames[1] = firstNames[1].ToUpper();
            Console.WriteLine($"The second element is {firstNames[1]}");
            Console.ReadLine();
        }
    }
}

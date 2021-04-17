using System;
using System.Text.RegularExpressions;

namespace Day7
{
    class Program
    {
    public static string Vowelremover(string input)
        {
            return Regex.Replace(input, "[aeiou]", "");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Vowelremover("goodbye"));

            Console.ReadKey();
        }
    }
}

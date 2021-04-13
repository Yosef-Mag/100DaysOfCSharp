using System;
using System.Linq;
namespace Day3
{
    class Program
    {
        public static string alternateCase(string s)
        {
            return string.Concat(s.Select(e => char.IsUpper(e) ? char.ToLower(e) : char.ToUpper(e)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(alternateCase("Hello World"));

            Console.ReadKey();
        }
    }
}

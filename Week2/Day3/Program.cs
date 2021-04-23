using System;
using System.Linq;

namespace Day3
{
    class Program
    {
        public static string Solution(string str) 
            {
                return new string(str.ToArray().Reverse().ToArray());
            }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("Yosef"));
            Console.ReadKey();
        }
    }
}

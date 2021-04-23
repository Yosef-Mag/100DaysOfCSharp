using System;
using System.Linq;

namespace Day5
{
    class Program
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aabbcde"));
            Console.ReadKey();
        }
    }
}

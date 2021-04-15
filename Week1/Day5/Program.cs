using System;
using System.Linq;
namespace Day5
{
    class Program
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("Yosef Moammed is learning C#"));

            Console.ReadKey();
        }
    }
}

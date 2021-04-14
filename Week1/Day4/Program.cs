using System;

namespace Day4
{
    class Program
    { 
        public static string GetMiddle(string s)
        {
           return string.IsNullOrEmpty(s)
            ? s
            : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);     
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("test"));
 
 
             Console.ReadKey();
        }
    }
}

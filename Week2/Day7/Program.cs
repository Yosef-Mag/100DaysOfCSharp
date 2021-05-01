using System;

namespace Day7
{
    class Program
    {
         
        public static int GetSum(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(-1, 2));
            Console.ReadKey();
        }
    }
}

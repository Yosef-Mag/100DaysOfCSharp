using System;

namespace Day6
{
    class Program
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}));
            Console.ReadKey();
        }
    }
}

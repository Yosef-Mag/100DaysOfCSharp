using System;

namespace Day2
{
    class Program
    {
    public static int Solution(int value)
        {
            var sum = 0;
            for(int i = 3; i < value; i++)
            {
            if(i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
   }        
    static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));

            Console.ReadKey();
        }
    }
}

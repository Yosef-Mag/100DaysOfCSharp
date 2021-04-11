using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
          int number;
            Console.Write("Enter the number :");
                number = Convert.ToInt16(Console.ReadLine());

                if ( number % 2 == 0)
                    Console.Write("Even");
                else 
                    Console.Write("Odd");

            Console.ReadKey();
        }
    }
}
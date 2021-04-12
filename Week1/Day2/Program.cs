using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            newOne :

            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int result;

            Console.WriteLine("Choose operation (+,-,*,/) : ");
            string operation = Console.ReadLine();
          
            switch(operation)
            {
                case "+" :
                    result = num1 + num2;
                    Console.WriteLine("Number1 + Number2 = " + result);
                    break;
                case "-" :
                    result = num1 - num2;
                    Console.WriteLine("Number1 - Number2 = " + result);
                    break;
                case "*" :
                    result = num1 * num2;
                    Console.WriteLine("Number1 * Number2 = " + result);
                    break;
                case "/" :
                    result = num1 / num2;
                    Console.WriteLine("Number1 / Number2 = " + result);
                    break;
                default:
                    Console.Write("Input error");
                    break;
            }

            goto newOne;

            Console.ReadKey();
        }
    }
}
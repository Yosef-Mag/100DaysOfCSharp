using System;
using System.Linq;

namespace Day6
{
    class Program
    {
    public static String Accum(string s) 
    {
        return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
    }
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("RqaEzty"));

            Console.ReadKey();
        }
    }
}

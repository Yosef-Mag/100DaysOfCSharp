using System;

namespace Week2
{
    class Program
    {
        public static int HexToDec(string hexString)
        {
            return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1);
        }
        static void Main(string[] args)
        {
             Console.WriteLine(HexToDec("a"));

             Console.ReadKey();
        }
    }
}

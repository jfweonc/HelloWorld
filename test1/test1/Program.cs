using System;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(checkEqual(1, 1));
            Console.WriteLine(checkEqual(1, 2));

        }
        static string checkEqual (int num1, int num2)
        {
            if (num1 == num2)
            {
                return "equal"; 
            } else
            {
                return "not equal"; 
            }
        }

    }
}

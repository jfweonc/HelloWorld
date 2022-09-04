using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        static int add(int num1, int num2) { return num1 + num2; }
        static int subtract(int num1, int num2) { return num1 - num2; }
        static int multiply(int num1, int num2) { return num1 * num2; }
        static int divide(int num1, int num2) { return num1 / num2; }
        static int modulus(int num1, int num2) { return num1 % num2; }

        Console.WriteLine(modulus(17, 4)); 

        static int AreaOfCircle （double r){
            return Math.PI * r * r; 
    }
}

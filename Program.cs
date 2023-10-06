using System;

namespace Calculator
{
    internal class Program
    {
        public static int Result;
        public static void Add(int A, int B)
        {
            Result = A + B;
        }

        public static void Subtract(int A, int B)
        {
            Result = A - B;
        }

        public static void Multiply(int A, int B)
        {
            Result = A * B;
        }

        public static void Divide(int A, int B)
        {
            Result = A / B;
        }

        public static void Main(string[] args)
        {
            Add(5, 15);
            Console.WriteLine("Answer is: " + Result);

            Subtract(90, 25);
            Console.WriteLine("Answer is: " + Result);

            Multiply(6, 3);
            Console.WriteLine("Answer is: " + Result);

            Divide(30,5);
            Console.WriteLine("Answer is: " + Result);
            

        }
    }
}
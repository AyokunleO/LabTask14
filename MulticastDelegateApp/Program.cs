using System;

namespace MulticastDelegateApp
{
    public delegate void CalculateDel (int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first input: ");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second input: ");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            CalculateDel calculate = Addition;
            calculate += Multiplication;

            calculate(inputNum1, inputNum2);
        }

        static void Addition(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}

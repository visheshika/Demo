using System;

namespace TechStudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int total;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            total = num2 + num1;
            Console.WriteLine("Total is : " + total);
            Console.ReadKey();
        }
    }
}
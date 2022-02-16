using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Input the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("\nLargest number is:" + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("\nLargest number is:" + num2);
            }
            else
            {
                Console.WriteLine("\nLargest number is:" + num3);
            }
        }
    }
}
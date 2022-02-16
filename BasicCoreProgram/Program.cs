using System;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the Number ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("is Even number", number);
            }
            else
            {
                Console.WriteLine("is Odd number", number);
            }
        }
    }
}
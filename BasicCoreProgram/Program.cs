using System;


namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2, num2 = 3, num;
            Console.WriteLine("Current numbers are : " );
            Console.Write("First Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            num = num1;
            num1 = num2;
            num2 = num;
            Console.WriteLine("\nSwapping numbers are : ");
            Console.Write("First Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
           

            

        }
    }
}
using System;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("This is a leap year" + year);
            else
                Console.WriteLine("This is not a leap year" + year);
        }
    }
}

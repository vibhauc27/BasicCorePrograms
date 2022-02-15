using System;

namespace BasicCoreProgram
{
    public class PowerOfTwo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= value; i++)
            {
                Console.WriteLine("2^{0} " + " " + "= {1}", i, Math.Pow(2, i));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Class1
    {
        public void Calculate()
        {
            int n,i;
            int factorial = 1;
            Console.WriteLine("Enter the number to calculate the factor");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                Console.WriteLine(" factorial:" + factorial);
            }
            Console.WriteLine("Factorial Number:" + factorial);
        }
    }
}

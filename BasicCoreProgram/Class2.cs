using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Class2
    {
        public void Compute()
        {
            int quotient;
            int remainder;
            Console.WriteLine("Enter The Divindend ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Divisor ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("The Quotient is:" + quotient);
            Console.WriteLine("The Remainder is: " + remainder);
        }
    }
}


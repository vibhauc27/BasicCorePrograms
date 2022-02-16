using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Class1
    {
        public void vowelndConso()
        {
            Console.WriteLine("Enter an Alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("Entered alphabet is vowel");
            }
            else
                Console.WriteLine("Entered alphabet is consonant");
        }
    }
}

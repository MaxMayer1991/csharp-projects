using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class ForVsForeach
    {
        static void main(string[] args)
        {
          

            string[] names = { "Alex", "Eddie", "David", "Michael" };

            /* Can't do this:
            foreach (var name in names)
            {
                // Can't do this:
                if (name == "David") name = "Sammy";
            }
            */

            Console.WriteLine("Reversed array:");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\nRenewed array:");
            for (int i = 0; i<names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);

            /*
                Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
                When the current value is divisible by 3, print the term Fizz next to the number.
                When the current value is divisible by 5, print the term Buzz next to the number.
                When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
             */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");
                else if (i % 3 == 0) Console.WriteLine($"{i} - Fizz");
                else Console.WriteLine(i);
            }
        }

    }
}

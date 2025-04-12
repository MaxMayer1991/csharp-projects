using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class doVsWhile
    {
        static void main(string[] args)
        {
            string? readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (validEntry == false);

            // capture user input in a string variable named readResult

            
            string value;
            int numericValue;
            bool validNumber = false;


            while (true)
            {
                Console.Write("Enter a number between 5 and 10: ");
                value = Console.ReadLine();
                validNumber = int.TryParse(value, out numericValue);
                if (validNumber)
                {
                    numericValue = Convert.ToInt32(value);
                    if(numericValue > 5 && numericValue < 10) {
                        Console.WriteLine($"You entered a valid number ({numericValue}).");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid number. Please enter a number between 5 and 10.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number.");
                    continue;
                }
            }
            
        }
    }
}

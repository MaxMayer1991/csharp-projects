using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Starter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];
            do
            {
                //Console.WriteLine($"You selected menu option {menuSelection}.");
                //Console.WriteLine("Press the Enter key to continue");

                // pause code execution
                //readResult = Console.ReadLine();
                switch (menuSelection)
                {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; i++)
                        {

                        }
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (menuSelection != "exit");
        }
    }
}

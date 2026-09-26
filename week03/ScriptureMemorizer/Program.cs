// EXCEEDING REQUIREMENTS:
// 1. Implemented a scripture library containing multiple verses/ranges and randomly selects one when the program starts.
// 2. Optimized HideRandomWords to only select from words that are not already hidden, ensuring efficient progression to full coverage.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures for random presentation
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Ether", 12, 27),
                "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me."
            )
        };

        // Select a random scripture from the library
        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words each time Enter is pressed
            scripture.HideRandomWords(3);
        }
    }
}
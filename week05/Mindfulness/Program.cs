// EXCEEDING REQUIREMENTS DESCRIPTION:
// 1. Guaranteed Unique Prompt/Question Selection: Implemented secondary tracking lists (_unusedPrompts / _unusedQuestions)
//    in ReflectingActivity and ListingActivity so that no prompt or question repeats during a session until all items
//    have been presented at least once.
// 2. Session Activity Tracking Log: Added an activity counter in Program.cs that records how many times each 
//    mindfulness exercise was completed during the application run and displays the total summary.

using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"\n[Session Stats: Breathing ({breathingCount}) | Reflecting ({reflectingCount}) | Listing ({listingCount})]");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    reflectingCount++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;
                case "4":
                    quit = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    Console.WriteLine($"Total activities completed: {breathingCount + reflectingCount + listingCount}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
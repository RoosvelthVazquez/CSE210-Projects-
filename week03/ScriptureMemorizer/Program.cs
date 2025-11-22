// EXCIDING REQUIREMENTS 
// I have added more scriptures from the bible and The Book of Mormon, 
// and I've also a small list that shows these scriptures to the user.


using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),

            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "I will go and do the things which the Lord hath commanded"
            )
        };

        Console.WriteLine("Select a scripture to memorize:\n");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}");
        }

        Console.Write("\nChoose: ");
        int choice = int.Parse(Console.ReadLine());
        Scripture selected = scriptures[choice - 1];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selected.GetDisplayText());
            Console.WriteLine("\nPlease enter to continue or type \"quit\" to finish.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            selected.HideRandomWords(3);

            if (selected.isCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selected.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program finished.");
                break;
            }
        }

    }
}
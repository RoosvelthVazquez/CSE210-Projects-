// Showing Creativity and Exceeding Requirements
// I have added a second question after option 1 that asks for your mood
// the answer at that questions is stored into the same file and then showed 
// after the date em before the prompt


using System;
using System.Data;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PrompGenerator prompGenerator = new PrompGenerator();

        int option = 0;
        while (option != 5)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                string prompt = prompGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string userText = Console.ReadLine();

                Console.Write("How do you feel today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._prompText = prompt;
                newEntry._entryText = userText;
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._mood = mood;  


                journal.AddEntry(newEntry);
                Console.WriteLine();
            }

            else if (option == 2)
            {
                journal.DisplayAll();
                Console.WriteLine();
            }

            else if (option == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
            
            else if (option ==4)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
        }

    }
}
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Member variables
    private List<string> _prompts;

    // Constructor
    public ListingActivity()
        : base("Listing", 
               "This activity will help you reflect on good things in your life by listing as many items as you can.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        Console.Clear();

        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];

        Console.WriteLine("List items related to this prompt:\n");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou may begin in...");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(duration);
        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }
}

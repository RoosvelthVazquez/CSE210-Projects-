using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity()
        : base("Reflection",
               "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different from other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        Console.Clear();

        // Prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press ENTER.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions:\n");

        Random rnd = new Random();
        List<string> selectedQuestions = new List<string>();

        while (selectedQuestions.Count < 2)
        {
            string q = _questions[rnd.Next(_questions.Count)];
            if (!selectedQuestions.Contains(q))
            {
                selectedQuestions.Add(q);
            }
        }

        foreach (string question in selectedQuestions)
        {
            Console.Write($"> {question} ");
            ShowLoadingBar(15, 4); 
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        return _questions[rnd.Next(_questions.Count)];
    }
}


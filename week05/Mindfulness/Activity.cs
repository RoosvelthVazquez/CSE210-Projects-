using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    // Member variables
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for  this session? ");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);

        Console.WriteLine($"\nYou completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "/", "-", "\\", "|" };

        for (int i = 0; i < seconds * 5; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowLoadingBar(int length, int seconds)
{
    int totalSteps = length;
    int delay = (seconds * 1000) / totalSteps;

    Console.Write("[");
    for (int i = 0; i < totalSteps; i++)
    {
        Console.Write("#");
        Thread.Sleep(delay);
    }
    Console.WriteLine("]");
}

}

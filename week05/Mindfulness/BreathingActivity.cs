using System;

public class BreathingActivity : Activity
{
    // Member variables
    public BreathingActivity() 
        : base("Breathing", 
               "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
        
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Follow the breathing prompts:\n");

        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}

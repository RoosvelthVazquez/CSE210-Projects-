using System;

class Program
{
    static void Main(string[] args)
    {
        
        // The program asks for a full name
        Console.Write("What is your first name? ");
        string name1 = Console.ReadLine();
        Console.Write("What is yor second name? ");
        string name2 = Console.ReadLine();
        Console.WriteLine($"Your name is {name2}, {name1} {name2}.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string ValueFromUser = Console.ReadLine();
        int x = int.Parse(ValueFromUser);


        Console.Write("What is your guess? ");
        string number = Console.ReadLine();
        int y = int.Parse(number);

        if (x == y)
        {
            Console.WriteLine("You guessed it!");
        }

        else if (x > y)
        {
            Console.Write("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }
    }
}
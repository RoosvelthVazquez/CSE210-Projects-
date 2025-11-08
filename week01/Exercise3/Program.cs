using System;

class Program
{
    static void Main(string[] args)
    {
        // random Generator
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);

        while (true)
        {
            Console.Write("What is your guess? ");
            string number = Console.ReadLine();
            int y = int.Parse(number);

            if (x == y)
            {
                Console.WriteLine("You guessed it!");
                break;
                
            }

            else if (x > y)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}
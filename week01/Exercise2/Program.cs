using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade as a number ");
        string ValueFromUser = Console.ReadLine();

        int a = int.Parse(ValueFromUser);
        string letter = "";

        if (a >= 90)
        {
            letter= "A";
        }
        else if (a >= 80)
        {
            letter= "B";;
        }
        else if (a >= 70)
        {
            letter= "C";;
        }
        else if (a >= 60)
        {
            letter= "C";
        }
        else
        {
            letter= "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        // second if statement 
        if (a >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("Sorry! You don't passed");
        }
    }
}
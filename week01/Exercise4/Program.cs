using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int counter = -1;

        while (counter != 0)
        {
            Console.Write("Enter a number: ");
            string NumberFromUser = Console.ReadLine();
            int number = int.Parse(NumberFromUser);

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");

        float avarage = ((float)sum) / numbers.Count;
        Console.WriteLine($"The avarage is {avarage}.");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
        }
        Console.WriteLine($"The max is: {max}.");
    }
}
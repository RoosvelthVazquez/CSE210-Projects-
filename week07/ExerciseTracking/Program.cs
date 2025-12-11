using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FITNESS ACTIVITY TRACKER");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2023, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2023, 11, 4), 45, 25.0));
        activities.Add(new Swimming(new DateTime(2023, 11, 5), 60, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        Console.WriteLine("ESTADISTICS:");
        
        double totalDistance = 0;
        double totalMinutes = 0;
        
        foreach (Activity activity in activities)
        {
            totalDistance += activity.GetDistance();
            totalMinutes += activity.durationMinutes;
        }
        
        Console.WriteLine($"Total activities: {activities.Count}");
        Console.WriteLine($"Total distance: {totalDistance:F1} km");
        Console.WriteLine($"Total time: {totalMinutes} minutes");
        
        double averageSpeed = (totalDistance / totalMinutes) * 60;
        Console.WriteLine($"Average speed: {averageSpeed:F1} kph");


    }
}
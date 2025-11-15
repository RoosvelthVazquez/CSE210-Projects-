using System;

class Program
{
    static void Main(string[] args)
    {
        //Class 1
        Job job1 = new Job();
        job1._jobTiyle = "Software Development";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTiyle = "Web developer";
        job2._company = "Google";
        job2._startYear = 2015;
        job2._endYear = 2025;

        // Class 2
        Resume rsm1 = new Resume();
        rsm1._name = "Roosvelth";

        rsm1._jobs.Add(job1);
        rsm1._jobs.Add(job2);

        rsm1.Display();

    }
}
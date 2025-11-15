using System;

public class Job
{
    // Member variables
    public string _company;
    public string _jobTiyle;
    public int _startYear;
    public int _endYear;

    // Method (member function)
    public void Display()
    {
        Console.WriteLine($"{_jobTiyle} ({_company}) {_startYear}-{_endYear}");
    }

}
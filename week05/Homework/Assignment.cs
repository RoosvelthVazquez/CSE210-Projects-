using System;
public class Assignment
{
    // member variables
    private string _studentName;
    private string _topic;

    // constructor 
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method getter
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}
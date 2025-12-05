public class WritingAssignment : Assignment
{
    // Member Variables
    private string _title;

    // Costructor
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }

    // Method
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}
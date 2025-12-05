public class MathAssignment : Assignment
{
    // Member Varibales
    private string _textbookSection;
    private string _problems;

    // Costructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}
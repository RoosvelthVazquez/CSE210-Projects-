public class Entry
{
    // Member variables
    public string _date;
    public string _prompText;
    public string _entryText;
    public string _mood;

    // Method (member function)
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Mood: {_mood} - Prompt: {_prompText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}
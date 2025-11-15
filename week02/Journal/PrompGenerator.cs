
public class PrompGenerator
{
    // Member variables
    public List<string> _prompts;

    public PrompGenerator()
    {
        _prompts = new List<string>()
        {
            "What is something I learned today?",
            "What is one thing I want to improve tomorrow?",
            "What made me smile today?",
            "What is something I am grateful for today?",
            "What is something I want to remember about today?"
        };
    }

    // Method (member function)
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
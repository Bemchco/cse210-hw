public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made you smile today?",
            "Describe a challenge you faced this week.",
            "What is something you learned recently?",
            "Write about a person who inspires you.",
            "What are your goals for the next month?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
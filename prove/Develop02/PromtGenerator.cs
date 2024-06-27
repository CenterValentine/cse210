using System;

public class PromptGenerator()
{
    public List<string> prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddPrompt(string input)
    {
        prompts.Add(input);
    }

    public void ForcePrompt(string input)
    {
        prompts.Add(input);
    }

    public string GetRandomPrompt()
    {
        Random random_number = new Random();
        int index = random_number.Next(prompts.Count);
        return prompts[index];
    }

}
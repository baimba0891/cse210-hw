using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who made a difference in your day today?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What made you smile today?",
        "What challenge did you overcome today?",
        "What goal did you work on today?",
        "What is something you want to remember about today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}

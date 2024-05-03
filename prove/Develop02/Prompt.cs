using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        // Initialize prompts
        _prompts = new List<string>
        {
            "What is your most memorable moment from last week?",
            "Describe a goal you want to achieve this month.",
            "Write about a person who inspires you.",
            "Tell the scripture that you read today.",
            "Say something about today."
        };
    }

    public string GeneratePrompt()
    {
        // Generate a random prompt
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}
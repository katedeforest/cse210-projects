using System;
using System.IO;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "What is one small thing that made today better?", "How do I feel right now, really?", "What has been taking up the most space in my mind lately?", "What am I avoiding, and why?", "What felt calm or grounding today?", "What is one thing I am proud of from this week?", "What do I need more of right now?", "What drained my energy today?", "If today had a lesson, what was it?", "What would “enough” look like for me right now?" };

    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int selector = random.Next(_prompts.Count);

        string prompt = _prompts[selector];

        return prompt;
    }
}
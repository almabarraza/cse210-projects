using System;
using System.Collections.Generic;

public class PromptGenerator
{

    public List<string> _prompts;
    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
       {
        "If I had the opportunity to change something about my day, what would it be? ",   
        "Could I feel the Lord's love in something today? ",
        "Could I serve anyone today? ",
        "What has been the hardest part of my day, and how I could overcome it? ",
        "What has been the strongest emotion that I have felt for most of my day? "
        };

        // random instance is created
        Random random = new Random();

         int random_Prompt = random.Next(_prompts.Count);
         string _prompt = _prompts[random_Prompt];

    return _prompt;
    }



}


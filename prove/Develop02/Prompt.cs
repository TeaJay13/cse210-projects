using System;
using System.Collections.Generic;

namespace Develop02
{
    ///<summary>
    /// the resonsablity of an Prompt is to select a prompt to display in main
    ///<summary>
    public class Prompt
    {
        public Random random = new Random();
        public List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };

        public string SelectPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
        
        


    } 


}
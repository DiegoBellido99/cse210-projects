using System;
using System.Collections.Generic;

public class PromptGenerator 
{

    public List <string> _entries;



public PromptGenerator ()
    {
     _entries= new List<string>
     {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        
     };
    }
    public string GetRandonPrompt ()
    {
     if (_entries.Count > 0)
     {
         Random random = new Random();
         int randomIndex = random.Next(0, _entries.Count);

         return _entries[randomIndex];
     }
     else
     {
        Console.WriteLine("There arent questions");
        return string.Empty;
     }
    }   
}
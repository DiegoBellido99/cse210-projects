using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name ,string description,int duration ) : base(name,description,duration)
    {
        _prompts = new List <string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };       
    }
    public void Run()
    {

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",10);
        reflectingActivity.DisplayStartingMessage();

        Console.WriteLine("");
        Console.Write("How long time in seconds, would you like for your session ? : ");
        _duration = int.Parse(Console.ReadLine());  
        Console.Clear();
        Console.WriteLine("Get Ready ...");
        ShowSpinner(800);

        Console.WriteLine("Consider the following prompt :");
        reflectingActivity.DisplayRamdomPrompt();

        Console.WriteLine("When you have something in mind ,press enter to continue ");
        string input = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience ");
        Console.Write("You may begin in ...");
        ShowCountDown(1000);
        Console.Clear();

        if(string.IsNullOrEmpty(input))
        {
            DateTime dateTime = DateTime.Now;
            DateTime future = dateTime.AddSeconds(_duration);
            while(DateTime.Now < future)
            {
                reflectingActivity.DisplayRamdomQuestions();
            }
        }
        else
        {
            Console.WriteLine("Please press enter");
        }
     
        reflectingActivity.DisplayEndingMessage(_duration,"Reflecting Activity");
    }

    public string GetRamdomPrompt()
    {
      if (_prompts.Count > 0)
     {
         Random random = new Random();
         int randomIndex = random.Next(0, _prompts.Count);

         return _prompts[randomIndex];
     }
     else
     {
        Console.WriteLine("There arent questions");
        return string.Empty;
     }  
    }

    public string GetRamdomQuestions()
    {
        if (_questions.Count > 0)
     {
         Random random = new Random();
         int randomIndex = random.Next(0, _questions.Count);

         return _questions[randomIndex];
     }
     else
     {
        Console.WriteLine("There arent questions");
        return string.Empty;
     }
    }

    public void DisplayRamdomPrompt()
    {
       ReflectingActivity reflectingActivity = new ReflectingActivity("name","description",10);
       string prompt = reflectingActivity.GetRamdomPrompt();
       Console.WriteLine($"--{prompt}---");
    }

    public void DisplayRamdomQuestions()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity("name","description",10);
        string question = reflectingActivity.GetRamdomQuestions();
        Console.Write($"> {question}");
        reflectingActivity.ShowSpinner(800);
        Console.SetCursorPosition(0, Console.CursorTop + 1);


    }
}
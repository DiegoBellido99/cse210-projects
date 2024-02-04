public class ListingActivity: Activity
{
    protected int _count;
    private List<string> _prompts;


    public ListingActivity(int count , string name, string description, int duration) : base(name,description,duration)
    {
        _count = count;
        _prompts= new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }

    public void Run ()

    {
        
        ListingActivity listingActivity = new ListingActivity(10,"Listing Activity","This activity will help you reflect on the good things in your \n life by having you list as many things as you can in a certain area.",10);
        listingActivity.DisplayStartingMessage();
        Console.WriteLine("");
        Console.Write("How long time in seconds, would you like for your session ? : ");
        int timeForSession = int.Parse(Console.ReadLine());  
        Console.Clear();
        Console.WriteLine("Get Ready ...");
        ShowSpinner(800);

        Console.WriteLine("List as many responses you can to the following prompt : ");

        string question= GetRandomPrompt();
        Console.WriteLine($"---{question}---");

        Console.Write("You may begin in ...");
        ShowCountDown(1000);
        Console.WriteLine();

        DateTime present = DateTime.Now;
        DateTime _duration = present.AddSeconds(timeForSession);
        
        List<string> thinks = new List<string>();

        while(DateTime.Now < _duration)
        {
            listingActivity.GetListFromUser(thinks);
        }
        _count= thinks.Count;

        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine();

        listingActivity.DisplayEndingMessage(timeForSession,"ListingActivity");

    }
    
    public string GetRandomPrompt()
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

    public void GetListFromUser(List<string> lista)
    {
        Console.Write(">");
        string think = Console.ReadLine();
        lista.Add(think);
    }
    
}
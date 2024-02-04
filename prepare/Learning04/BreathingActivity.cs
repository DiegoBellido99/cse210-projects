public class BreathingActivity:Activity
{
    
   public BreathingActivity(string name ,string description,int duration) : base(name,description,duration)
   {

      
   }
   public void Run()
   {

    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity","This activity will help you to relax by walking your through breathing \n in and out slowly.Clear your mind and focus on your breathing.",10); 
    breathingActivity.DisplayStartingMessage();

    Console.Write("How long time in seconds, would you like for your session ? : ");
    _duration = int.Parse(Console.ReadLine());

    Console.Clear();

    BreathingActivity breathingActivity1 = new BreathingActivity("Breathing Activity","This activity will help you to relax by walking your through breathing \n in and out slowly.Clear your mind and focus on your breathing.",10); 

    Console.WriteLine("Get ready");
    breathingActivity1.ShowSpinner(1000);

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    
    while (DateTime.Now < endTime)
    {
        Console.Write("Breathe in ...");
        breathingActivity1.ShowCountDown(1000) ;
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.Write("Now breathe out ...");
        breathingActivity1.ShowCountDown(1000) ;
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }   
 
    breathingActivity1.DisplayEndingMessage(_duration,"Breathing Activity");
   }
   
}
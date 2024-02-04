using System.IO.Compression;

public class Activity 
{
    private string _name;
    private string _description;
    protected int _duration;

    

    public Activity(string name ,string description , int duration )
    {
       _name = name ;
       _description = description;
       _duration = duration;
    }

    public void   DisplayStartingMessage()
    {
       Console.WriteLine($"Welcome to the {_name}");
       Console.WriteLine();
       Console.WriteLine($"{_description}");
    }

    public void  DisplayEndingMessage(int timeForSession,string name)
    {
    Console.WriteLine("Well done !");
    ShowSpinner(1000); 
    Console.WriteLine();       
    Console.WriteLine($"You have completed another {timeForSession} seconds of {name}");
    ShowSpinner(800);
    Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
      char[]  cruz = {'|','/','-','\\','|','/','-','\\'};

      foreach(char i in cruz)
      {
        Console.Write(i);
        Thread.Sleep(seconds);
        Console.Write("\b \b");
      }     

    }

    public void ShowCountDown( int seconds )
    {
       for(int i = 5 ;  i > 0; i --)
       {
        Console.Write(i);
        Thread.Sleep(seconds);
        Console.Write("\b \b");
       }
    }

    
}
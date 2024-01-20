public class Entry 
{
    public  DateTime Date;
    public string PromptText;
    public string EntryText;

    public Entry( DateTime fecha  ,string Prompt, string Text)
    {
        Date = fecha;
        PromptText = Prompt;
        EntryText = Text;
    }
  

    public void Display ()
    {
       Console.WriteLine($"Date: {Date.ToShortDateString()} ,Prompt :{PromptText},{EntryText}/");
    }

}
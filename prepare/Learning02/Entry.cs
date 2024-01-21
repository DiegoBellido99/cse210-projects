public class Entry 
{
    public  DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry( DateTime fecha  ,string Prompt, string Text)
    {
        _date = fecha;
        _promptText = Prompt;
        _entryText = Text;
    }
  

    public void Display ()
    {
       Console.WriteLine($"Date: {_date.ToShortDateString()} ,Prompt :{_promptText},{_entryText}");
    }

}
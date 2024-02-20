public class Lecture:Event 
{
    private string _speaker;
    private string _capacity;

    public Lecture(string typeEvent,string tittle, string description, string date , string time, Address address,string speaker,string capacity) :base(typeEvent, tittle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override  void GetFullDetails()
    {
        Console.WriteLine($"{StringDetails()}\nThe speaker will be {_speaker}. We have limited capacity :{_capacity}");
    }


}
public class OutdoorsGathering : Event
{
    private string _weather;

    public OutdoorsGathering(string typeEvent, string tittle, string description, string date , string time, Address address , string weather)  :base(typeEvent ,tittle, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"{StringDetails()}.\nThe weather forecast that day will be {_weather}");
    }

}

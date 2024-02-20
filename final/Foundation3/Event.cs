using System.Net.Sockets;

public class Event
{
    private string _typeEvent;
    private string _tittle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
 
    public Event(string typeEvent ,string tittle, string description, string date , string time, Address address)
    {
        _typeEvent = typeEvent;
        _tittle = tittle;
        _description= description;
        _date = date;
        _time = time;
        _address = address;   
    }

    public void StandardDetails()
    {
      Console.WriteLine($"{_typeEvent}-Tittle :{_tittle}-{_description}- Date : {_date}- Time: {_time}- Address :{_address.GetString()}.");
    }

    public string StringDetails()
    {
        return $"You are invited to our {_typeEvent} Tittle: {_tittle}- Description :{_description}- Date :{_date}- Time :{_time}- Address :{_address.GetString()}.";
    }

    public void ShortDescription()
    {
        Console.WriteLine($"{_typeEvent} - Tittle: {_tittle}- Date: {_date}.");
    }

    public virtual void GetFullDetails(){}
    
}
public class Reception:Event
{
    private string _email;

    public Reception( string typeEvent, string tittle, string description, string date , string time, Address address,string email):base(typeEvent, tittle, description, date , time, address)
    {
        _email = email;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"{StringDetails()}\nIf you plan to attend please register in the following email: {_email}");
    }
}
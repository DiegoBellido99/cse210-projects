using System.Diagnostics.Contracts;

public  abstract class Activity
{
    protected string _type;
    protected string _date;
    protected double _lengthInMinutes;

    public Activity (string type, string date , double lengthInMinutes )
    {
        _type = type;
        _date = date;
        _lengthInMinutes = lengthInMinutes;
        
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double  GetSpeed()
    {
        return 0.0;
    }
    public virtual  double GetPace()
    {
        return 0.0;
    }
    public  void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_lengthInMinutes} min )- Distance: {GetDistance()} km , Speed: {GetSpeed()} km per hour, Pace: {GetPace()} min per Km");
    }




}
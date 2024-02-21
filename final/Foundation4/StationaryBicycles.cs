public class StationaryBicycles: Activity
{
    private double _speed;

    public StationaryBicycles(string type,  string date , double lengthInMinutes, double speed) : base( type, date, lengthInMinutes)
    {
       _speed = speed ;
    }

    public  override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0/ _speed;
    }
}
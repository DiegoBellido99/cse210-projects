public class RunningClass : Activity
{
    private double _distance;

    public RunningClass( string type, string  date, int lengthInMinutes, double distance)
        : base(type,date, lengthInMinutes)
    {
       _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance /_lengthInMinutes *  60;
    }

    public override double GetPace()
    {
        return  _lengthInMinutes / _distance;
    }
}
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string type,string date , double lengthInMinutes, int laps) :base(type, date , lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance() /1000;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / (_lengthInMinutes / 60.0);
        return speed;
    }




}
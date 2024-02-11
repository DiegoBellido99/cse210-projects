using System.Runtime;

public class CheckListGoal : Goal
{
     protected int _amountCompleted;
     protected int _target;
     protected int _bonus ;

     public CheckListGoal( string shortname ,string description , int  point , int target , int bonus,int amountCompleted): base( shortname, description ,point)
     {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
     }
      public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
    }
    

    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted+1;
        if (_amountCompleted == _target)
        {
            _points = _points + _bonus;
        }
        
    }

    public override bool Iscomplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string details = $"{_shortName} ({_description})--Currently completed :{_amountCompleted}/{_target}";
        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"CheckList Goal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return representation;
    }
}
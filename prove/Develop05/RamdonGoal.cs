using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class RamdonGoal : Goal
{
    protected bool _isComplete ;

    public RamdonGoal(string shortname ,string description,int points): base( shortname , description , points)
    {
        _isComplete = false;

    }

    public override void RecordEvent()
    {
        _isComplete = true ;      
    }

    public override string GetStringRepresentation()
    {
        string representation = $"Ramdon Goal: Goal for : today, {_description}, {_points},{_isComplete}";
        return representation;
    }
       


    public override bool Iscomplete()
    {
        return _isComplete;
              
    }
}
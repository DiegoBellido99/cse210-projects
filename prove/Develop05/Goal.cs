using System.Diagnostics.CodeAnalysis;

public abstract class  Goal
{
    protected string _shortName;
    protected string _description;
    protected int  _points;

    public Goal(string shortname , string description , int points)
    {
       _shortName = shortname;
       _description = description;
       _points = points;
    }
    

    public string GetShortName()
    {
        return _shortName;
    }
    public int GetPoints()
    {
        return _points;
    }
    

    public abstract void RecordEvent();

    public abstract bool Iscomplete();

    public virtual string GetDetailsString()
    {
       string details = $"{_shortName} ({_description})";
       return details ;
    }

    public abstract string GetStringRepresentation();
    
}
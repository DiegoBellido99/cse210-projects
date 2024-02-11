using System.Reflection.PortableExecutable;

public class EternalGoal : Goal 

{
    public EternalGoal(string shortname ,string description , int point) : base( shortname, description ,point)
    {

    }


    public override void RecordEvent()
    {
       
    }

    public override bool Iscomplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"Eternal Goal :{_shortName},{_description},{_points}";
        return representation;
    }
}
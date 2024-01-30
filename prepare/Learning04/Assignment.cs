public class Assignments 
{
    private string _studentName = "";
    private string _topic = "";

    public Assignments(string student , string topic)
    {
        _studentName = student;
        _topic = topic ;

    }

    public string GetStudent()
    {
        return _studentName;
    }
    
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic; 
    }
}
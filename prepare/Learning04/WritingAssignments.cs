public class WritingAssignments : Assignments
{
    private string _title;

    public WritingAssignments(string title , string student, string topic): base(student,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title;
    }
}
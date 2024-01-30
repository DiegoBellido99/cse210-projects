public class MathAssignments : Assignments
{
   private string _textBookSection;
   private string _problems;

   public MathAssignments(string textBookSection , string problems ,string student , string topic): base(student,topic) 
   {
       _textBookSection = textBookSection;
       _problems = problems;
   }

   public string GetTextBookSection()
   {
    return _textBookSection;
   }

   public string GetProblems()
   {
    return _problems;
   }

   public string GetHomeWorkList()
   {
    return $"Section { _textBookSection} Problems {_problems} ";
   }


}
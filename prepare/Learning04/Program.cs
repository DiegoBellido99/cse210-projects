using System;

class Program
{
    static void Main(string[] args)
    {
        
      Assignments assignments = new Assignments("Ariana" , " English");
      Console.WriteLine(assignments.GetSummary());

      MathAssignments mathAssignments = new MathAssignments("7.3" ,"8-19","Diego Bellido","Programing");

      Console.WriteLine(mathAssignments.GetSummary());
      Console.WriteLine(mathAssignments.GetHomeWorkList());

      WritingAssignments writingAssignments = new WritingAssignments("100 años de soledad","Raffo Hernandez","Literature");
      Console.WriteLine(writingAssignments.GetSummary());
      Console.WriteLine(writingAssignments.GetWritingInformation());
              
    }
}
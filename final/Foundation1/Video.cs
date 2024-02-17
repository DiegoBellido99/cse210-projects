using System.Globalization;

public class Video
{
    public string _author;
    public string _tittle;   
    public int _lengthInSeconds;
    public List<Comment> comments;

    public Video (string author ,string tittle , int length )
    {
        _author = author;
        _tittle = tittle;
        _lengthInSeconds = length;
        comments = new List<Comment>();
    }
     public int GetNumberOfComments()
     {
       int number = comments.Count;
       return number ;
     }

     public void AddComment(string user , string opinion)
     {
       
       Comment comment = new Comment(user,opinion);
       
       comments.Add(comment);

     }

     public void DisplayVideoInfo()
     {
        Console.WriteLine($"Tittle : {_tittle} , Author : {_author}, duration in seconds : {_lengthInSeconds}, Number of comments : {GetNumberOfComments()} ");

        foreach(Comment listComment in comments)
        {
            Console.WriteLine(listComment.Display());
        }
     }
}
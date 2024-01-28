public class References 
{
   private string _book;
   private int _chapter;
   private int _verse;
   private int _endVerse;


   public References( string book , int chapter, int verse )
   {
       _book = book;
       _chapter = chapter;
       _verse = verse;
   }

   public References( string book , int chapter, int startVerse , int endVerse)
   {
       _book = book;
       _chapter = chapter;
       _verse = startVerse;
       _endVerse = endVerse;
   }

   public string DisplayText()
   {
    return $"{_book} {_chapter} : {_verse}-{_endVerse}  ";
   }

}
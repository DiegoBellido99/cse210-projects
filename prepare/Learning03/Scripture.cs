public class Scripture
{
    private References _references;

    private List<Word> _words;


public Scripture ()

{
    _references= new References("Nephi",3,7);

    _words=CreateWordListFromText(" And it came to pass that I, Nephi, said unto my father:\n I will go and do the things which the Lord hath commanded, for I know that the Lord \ngiveth no commandments unto the children of men, \nsave he shall prepare a way for them that they may accomplish\n the thing which he commandeth them. ");
}

private List<Word> CreateWordListFromText(string text)
{
    List<Word> wordList = new List<Word>();

    
    string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    
    foreach (string wordText in words)
    {
        Word word = new Word(wordText);
        wordList.Add(word);
    }

    return wordList;
}
    

    public void HideRamdonsWords( int numberToHide )
    {

    Random random = new Random();

    List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());

    if (visibleWords.Count < numberToHide)
    {
        Console.WriteLine("There are not words to hide");
        return;
    }

    for (int i = 0; i <= numberToHide; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }
  
    }

    public string GetDisplayText()

    {        
        string DisplayText = $"{_references.DisplayText()}";
        foreach (Word word in _words )
        {
            DisplayText += word.GetDisplayText() + " ";

        }
        return DisplayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void addScripture(  string scripture)
    {  
        
       _words = CreateWordListFromText(scripture);
       
    }

}

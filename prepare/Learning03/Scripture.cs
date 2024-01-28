public class Scripture
{
    private References _references;

    private List<Word> _words;


public Scripture ()

{
    _references= new References("Juan",10,5,5);

    _words=CreateWordListFromText(" Estas son varias palabras que el progrmama va a borrar ,yo decidire cuales seran ");
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

    public void addScripture(string scripture)
    {
       _words = CreateWordListFromText(scripture);
       
    }

}

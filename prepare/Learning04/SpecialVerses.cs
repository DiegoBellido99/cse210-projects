public class SpecialVerse:Activity
//As "Exceeding Requirements" I have added option number 4, which is an activity that shows//
//verses from the Bible to help overcome anger or sadness//

{
   private List<string> _anger;
   private List<string> _worryOrSad;

   public SpecialVerse(string name ,string description, int duration) : base(name,description,duration)
   {
    _worryOrSad= new List<string>
    {
        "Deuteronomy 31:8 The Lord himself goes before you and will be with you; \n he will never leave you nor forsake you. Do not be afraid; do not be discouraged",
        "Philippians 4:13 I can do all things through Christ who strengthens me",
        "John 16:33 I have told you these things, so that in me you may have peace.\n In this world you will have trouble. But take heart! I have overcome the world.",
        "Matthew 11:28 Come to me, all who labor and are heavy laden, and I will give you rest"
    };

    _anger = new List<string>
    {
       "Proverbs 14:17, 29 A quick-tempered person acts foolishly, and one who schemes is hated … \nA patient person shows great understanding, but a quick-tempered one promotes foolishness.",
       "James 1:19-20 My dear brothers and sisters, understand this: Everyone should be quick to listen, \nslow to speak, and slow to anger, for human anger does not accomplish God's righteousness",
       "Ephesians 4:26-27 Be angry and do not sin. Don't let the sun go down on your anger,\n and don't give the devil an opportunity.",
       " Ephesians 4:31-32 Let all bitterness, anger and wrath, shouting and slander be removed from you, \nalong with all malice. And be kind and compassionate to one another, forgiving one another, just as God also forgave you in Christ.",
       "John 13:35 By this everyone will know that you are my disciples, if you love one another."
   };
   }

   public void Run()
   {
    SpecialVerse specialVerse = new SpecialVerse("Special Verse","This activity will help you relieve your feelings of anger and worry \n by showing you Bible verses, especially focused on these feelings.This activity lasts 20 seconds",30);
    specialVerse.DisplayStartingMessage();
    Console.WriteLine();

    Console.WriteLine("How Do you feel ? : ");
    Console.WriteLine("1.Angry");
    Console.WriteLine("2.Sad or Worry");
    Console.Write("Answer : ");
    int feeling = int.Parse(Console.ReadLine());
    
    Console.Clear();
    Console.WriteLine("Get Ready ...");
    ShowSpinner(800);    

    DateTime dateTime = DateTime.Now;
    DateTime future = dateTime.AddSeconds(30);

    if (feeling == 1)
    {
        while(DateTime.Now < future)
        {
            specialVerse.DisplayVerseAboutAnger();
        }

    }
    else if (feeling == 2)
    {
        while(DateTime.Now < future)
        {
            specialVerse.DisplayVerserAboutSad();
        }       
    }
    else
    {
        Console.WriteLine("Sorry that is not a valid choise");
    }

    specialVerse.DisplayEndingMessage(_duration,"Special Verse");


   }

   public string GetRamdomAngerVerse()
   {
      if (_anger.Count > 0)
     {
         Random random = new Random();
         int randomIndex = random.Next(0, _anger.Count);

         return _anger[randomIndex];
     }
     else
     {
        Console.WriteLine("There arent questions");
        return string.Empty;
     }    
   }

   public string GetRamdomWorryVerse()
   {
      if (_worryOrSad.Count > 0)
     {
         Random random = new Random();
         int randomIndex = random.Next(0, _worryOrSad.Count);

         return _worryOrSad[randomIndex];
     }
     else
     {
        Console.WriteLine("There arent questions");
        return string.Empty;
     }    
   }

    public void DisplayVerseAboutAnger()
    {
        SpecialVerse specialVerse= new ("name","description",10);
        string verse = specialVerse.GetRamdomAngerVerse();
        Console.Write($"> {verse}");
        specialVerse.ShowSpinner(1500);
        Console.WriteLine();
    }

    public void DisplayVerserAboutSad()
    {
        SpecialVerse specialVerse = new SpecialVerse("name","description",10);
        string verse = specialVerse.GetRamdomWorryVerse();
        Console.WriteLine($">{verse}");
        specialVerse.ShowSpinner(1500);
        Console.WriteLine();
    }


}
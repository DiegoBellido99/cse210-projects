using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        

        Address address1= new Address("husares de junin 311","Lima","Lima","Peru");
        Lecture lecture = new Lecture("Lecture","How tho be your own boss","You will learn how to be rich and successful","October 14","16:30",address1,"Diego Bellido","3,500");


        Address address2= new Address("San Bartolo 456","Selva alegre","Arequipa","Peru");
        Reception reception = new Reception("Reception","3 rd conference about Flutter","Why to use Flutter?","january 26","14:00",address2,"universtyUPC@gmail.com");

        Address address3 = new Address("Costa verde","San Miguel","Lima","Peru");
        OutdoorsGathering outdoorsGathering = new OutdoorsGathering("OutdoorsGathering","Happy New Year","Recieve the new year with us","December 31","15:00",address3,"sunny");
        
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorsGathering);

        foreach(Event event1 in events)
        {
            event1.StandardDetails();
            Console.WriteLine();
            event1.GetFullDetails();
            Console.WriteLine();
            event1.ShortDescription();
            Console.WriteLine();
            Console.WriteLine();
        }

    }
} 
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       int option = 1;

       while (option != 5)
       {
            Console.WriteLine("Menu Options :");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflecting activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Special Verse activity");
            Console.WriteLine("5.Quit ");
    
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            
            if (option == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("name","description",10); 
                breathingActivity.Run();  
                Console.Clear(); 
            }
            
            else if (option == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity("name","description",10);
                reflectingActivity.Run();
            }

            else if(option == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity(1,"name","description",30);
                listingActivity.Run();               
            }

            else if (option == 4)
            {
                Console.Clear();
                SpecialVerse specialVerse= new SpecialVerse("name","description",30);
                specialVerse.Run();
            }
        }

    }
}
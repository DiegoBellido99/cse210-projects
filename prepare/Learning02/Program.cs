using System;
using System.Collections.Generic;
using System.IO; 

//Apart from the requirements that are requested, for my part //
//I have added the option to delete lines from the files where the//
//answers that the user is entering are being saved. The option first//
//asks in which file we want to delete information//



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");        
        int option = 1 ;
        Journal journal = new Journal();

        while (option != 6)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Delete");
            Console.WriteLine("6.Quit");


            Console.Write("What do you want to do ?");
            string UserInput = Console.ReadLine();
            option= int.Parse(UserInput);

            if (option == 1)
            {
                journal.AddEntry();               
            }
            else if (option ==2)
            {
                journal.DisplayAll();
            }
            
            else if (option == 4)
            {
                journal.SaveToField();
            }
            else if (option == 3)
            {
                Console.WriteLine("Enter the file name to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFroamFile(fileName);
            }
            else if (option == 5)
            {
                Console.WriteLine("Which file do you want to delete the last line from?");
                string fileName = Console.ReadLine();
                journal.DeleteLine(fileName);
            }
        }
        
    }
}
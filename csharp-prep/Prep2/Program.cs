using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade to be evaluated please : ");
        string userInput = Console.ReadLine();
        
        int grade = int.Parse(userInput);
        string letter="" ;

        if ( grade >= 90)
        {
            letter= "A";
        }

        else if (grade >=80)
        {
            letter= "B";
        }
        
        else if ( grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is : {letter}");

        if ( grade >= 70 )
        {
            Console.Write("Congratulations you passed ");
        }
        else 
        {
            Console.Write("Sorry you dont pass , good luck the next time");
        }

    }

}
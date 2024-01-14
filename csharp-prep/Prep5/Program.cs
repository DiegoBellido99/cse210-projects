using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string fullName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square= SquareNumber(favoriteNumber);
        DisplayResult(fullName,square);
        

        static void DisplayResult (string name , int number)
        {            
            Console.WriteLine($"{name} , the square of your number is {number}");
        }
       
        static int SquareNumber(int value)
        {
           int total = value * value; 
           return total ;
        }
       
        static int PromptUserNumber()
        {
            Console.Write ("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your full name: ");
            string name = Console.ReadLine();
            return name;       
        }

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!!! ");
            
        }        

    }
}
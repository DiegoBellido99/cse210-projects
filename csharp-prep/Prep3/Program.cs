using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the secret number ?");
        int number = int.Parse(Console.ReadLine());
        
        int guess = 0;
        while ( guess != number)
        {
            Console.Write("What do you guess : ");
            guess= int.Parse(Console.ReadLine());

            if (guess < number)
            {
              Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
              Console.WriteLine("Lower");
            }
            else
            {
              Console.WriteLine("You guessed it !!");
            }
        }
    }
}
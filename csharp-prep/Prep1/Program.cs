using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your name ? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? :");
        string last = Console.ReadLine();

        Console.Write($"Your name is  {name}, {name} {last}");
    }
}
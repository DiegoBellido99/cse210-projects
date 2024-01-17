using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
       
       Console.WriteLine("  Enter a list of numbers, type 0 when finished. ");
       
       int content =-1;
       while (content != 0 )
       {
        Console.Write("Enter a number : ");
        string input = Console.ReadLine();
        content= int.Parse(input);
       
        if (content != 0)
        {
            numbers.Add(content);
        }
        }

         int  futureValue = 0 ;

         foreach(int value in numbers)
         {
            futureValue+= value;
         }
         Console.WriteLine($"The total is : {futureValue}");

         float average = ((float)futureValue)/numbers.Count;
         Console.WriteLine($"The average is {average}");

         int max = numbers[0] ;

         foreach (int values in numbers)
         {
            if ( max < values)
            {
                max=values;
            }
         }
         Console.WriteLine($"The maximun value is {max}");

         int min = numbers[0];

         foreach( int values in numbers)
         {
            if ( values > 0 && values < min)
            {
                min = values;
            }
         }
         Console.WriteLine($"the smallest positive value is {min}");

         numbers.Reverse();

         static void PrintList (List<int> list)
         {
            foreach (var number in list)
            {
             Console.WriteLine(number);
            }
         }
         Console.WriteLine("  The sorted list is: ");
         PrintList(numbers);
        

        
    }
}
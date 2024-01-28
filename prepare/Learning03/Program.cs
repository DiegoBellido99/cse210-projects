//The extra extra function I added was that the user has the option//
// to enter the writing they want to memorize.//

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture();

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Please enter to continue, type 'quit' to finish or 'change' to add a new verse to memorize ");
            string input = Console.ReadLine();

            

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRamdonsWords(0);
            }
            else if (input == "quit")
            {
                return;
            }

            else if (input == "change")
            {
                Console.WriteLine("Add a new scripture");
                scripture.addScripture(Console.ReadLine());

            }
        } while (!scripture.IsCompletelyHidden());

        Console.WriteLine("Program completed");
    }
}
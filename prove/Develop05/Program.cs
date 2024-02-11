using System;

//As "Exceeding Requirements" I added the option to create a random goal, this option//
// will give a random goal and will give 50 extra points. Create the "RandomGoal" class//
//to be able to add it to the list and to the text file by its correct name.//


class Program
{
    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
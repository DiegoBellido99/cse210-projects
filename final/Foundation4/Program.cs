using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new RunningClass("Running","20/02/2023",30,4.8);
        Activity stationaryBicycles = new StationaryBicycles("StationaryBicycles","20/02/2022",30,15.00);
        Activity swimming = new Swimming("Swimming","20/02/2022",15,10);

    

        Activity [] activities= {runningActivity,stationaryBicycles,swimming};

        foreach ( Activity activity in activities)
        {
            Console.WriteLine();
            activity.GetSummary();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Once you have the classes in place, write a program that creates
        //  at least one activity of each type. Put each of these activities
        //  in the same list. Then iterate through this list and call the 
        // GetSummary method on each item and display the results.

        Running running1 = new Running("03 Nov 2022", 30, 3);
        StationaryBike cycling1 = new StationaryBike("04 Nov 2022", 30, 12);
        Swimming swimming = new Swimming("05 Nov 2022", 30, 6);

        Activity[] activities = { running1, cycling1, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}
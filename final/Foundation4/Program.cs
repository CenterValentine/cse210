using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running running1 = new Running("03 Nov 1913", 30, 3);
        StationaryBike cycling1 = new StationaryBike("03 Nov 1940", 30, 10);
        Swimming swimming = new Swimming("03 Nov 2024", 30, 30);

        Activity[] activities = {
            running1,
         cycling1
          ,swimming
          };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8),
            new CyclingActivity(new DateTime(2022, 11, 3), 30, 9.7),
            new SwimmingActivity(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

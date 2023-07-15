using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2023, 7, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2023, 7, 4), 30, 9.7));
        activities.Add(new Swimming(new DateTime(2023, 7, 5), 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("");
        }
    }
}
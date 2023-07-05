using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>(){
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("27 Mar 2023", 45, 19),
            new Swimming("13 Jun 2023", 15, 5)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
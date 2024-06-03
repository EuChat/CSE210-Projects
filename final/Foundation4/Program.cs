using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity>activities=new List<Activity>
        {
            new Running("03 Nov 2024", 30, 3.0),
            new Cycling("03 Nov 2024", 30, 18.0, 50.5),
            new Swimming("03 Nov 2024",30, 20)
        };
        foreach ( var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
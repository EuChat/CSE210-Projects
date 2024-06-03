using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

        List<Event> events= new List<Event>
        {
            new Lecture("Learning C#","A simple Approach","01/06/2024","1000hrs",new Address("543 Main St"," Springfield","IL","USA"),"Jane Doe" ,100),
            new Reception("Networking Event","An event for proffessionals to network","10/06/2024","06:00PM",new Address("345 Elm St"," Toronto","ON","Canada"), "RSVP@networking.com"),
            new OutdoorGathering("Pinic in the Garden","A  family-friendly picnic","15/06/2024","12:00PM",new Address("453 Oak St"," Vancouver","BC","Canada"),"Sunny with a  slight drizzle")

        };
        foreach (Event ev in events)
        {
            Console.WriteLine( ev.GetStandardDetails());
            Console.WriteLine( "");
            Console.WriteLine( ev.GetFullDetails());
            Console.WriteLine( "");
            Console.WriteLine( ev.GetShortDescription());

            Console.WriteLine( "\n-------------------\n");
        }

        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("543 Main St"," Springfield","IL","USA");
        Address address2= new Address("345 Elm St"," Toronto","ON","Canada");
        Address address3= new Address("453 Oak St"," Vancouver","BC","Canada");

        List<Event> events= new List<Event>
        {
            new Lecture("Learning C#","A simple Approach","01/06/2024","1000hrs",address1,"Jane Doe" 100),
            new Reception("Networking Event","An event for proffessionals to network","10/06/2024","06:00PM",address2"rsvp@networking.com"),
            new OutdoorGathering("Pinic in the Garden","A  family-friendly picnic","15/06/2024","12:00PM",address3,"Sunny with a  slight drizzle")

        };
        foreach (var ev in events)
        {
            Console.WriteLine( ev.GetStandardDetails());
            Console.WriteLine( ev.GetFullDetails());
            Console.WriteLine( ev.GetShortDetails());

            Console.WriteLine( "\n-------------------\n");
        }

        
    }
}
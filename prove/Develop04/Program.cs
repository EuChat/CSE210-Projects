//No prompt and question is going to be used twice until all are exhausted.

using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool loop = true;
        while(loop)
        {
            Console.Clear();
            Menu();
            string answer = Console.ReadLine();
            int decider = int.Parse(answer);
            if (decider == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                breathing.Run();
            }
            else if (decider == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflecting.Run();
            }
            else if (decider == 3)
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0);
                listing.Run();
            }
            else if (decider == 4)
            {
                loop = false;
            }
            else
            {
                System.Console.WriteLine("Invalid input!");
            }
        }
        static void Menu()
        {
            Console.WriteLine($"Menu Options:\n\t1. Start Breathing Activity\n\t2. Start reflecting activity\n\t3. Srart Listing Activity\n\t4. Quit\nSelect a choice from the menu.");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        int mark = int.Parse(grade);

        char letter;
        char sign;

        if (mark>= 90)
        {
            letter = 'A';
        }
        else if (mark >= 80 )
        {
            letter = 'B';
        }
        else if (mark >= 70 )
        {
            letter = 'C';
        }
        else if (mark >= 60 )
        {
            letter = 'D';
        }
        else 
        {
            letter = 'F';
        }
        int decider =  mark%10;
        if (decider >= 7 && letter != 'A' && letter != 'F')
        {
            sign = '+';
        }
        else if (decider < 3 && letter != 'F')
        {
            sign = '-';
        }
        else
        {
            sign = ' ';
        }
        Console.WriteLine($"You got a {letter}{sign}");

        if (mark>=70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Work harder next time.");
        }
    }
}
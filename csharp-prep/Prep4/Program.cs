using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables

        bool loop = true;
        int largestNumber = 0;
        int smallestPosInt = 1000000000;
        int sum = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, enter '0' When finished.");

        //input and process

        while (loop)
        {
            Console.Write("Enter a number: ");
            string word = Console.ReadLine();
            int number = int.Parse(word);
            sum += number;
            if (number> largestNumber)
            {
                largestNumber = number;
            }
            if (number < smallestPosInt && number> 0)
            {
                smallestPosInt = number;
            }
            if (number != 0)
            {
                numbers.Add(number);
            }
            else 
            {
                loop = false;
            }
        }

        //Output

        Console.WriteLine($"The sum is {sum}");
        decimal average = sum/numbers.Count;
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"THe smallest positive number is {smallestPosInt}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach(int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}
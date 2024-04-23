using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Random magicNumber = new Random();
        int answer = magicNumber.Next(1, 100);
        int guessCount = 0;
        int possible = 0;
        bool loop = true;
        do
        {
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                possible = int.Parse(guess);
                guessCount ++;
                
                
                if (possible < answer)
                {
                    Console.WriteLine("Higher\n");
                }
                else if (possible > answer)
                {
                    Console.WriteLine("Lower\n");
                }
                else 
                {
                    Console.WriteLine($"You guessed it!\n It took you {guessCount} guesses.\n");
                    Console.Write("Would you like to play again? (lower case) ");
                    string cont = Console.ReadLine();
                    if (cont == "yes" )
                    {
                        loop = true;
                    }
                    else
                    {
                        loop = false;
                    }
                }
            }
            while (answer != possible);
        }
        while(loop);
    }
}
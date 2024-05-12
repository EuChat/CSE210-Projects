using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Reference> references =
        [
            new Reference("John",        3, 16, "For God so loved the world..." ),
            new Reference("Psalm",      23, 1,  "The Lord is my shepherd, I shall not want." ),
            new Reference("Proverbs",   3,  5,6,  "Trust in the Lord with all your heart..." ),
            new Reference("Isaiah",     40, 31, "But those who hope in the Lord will renew their strength." ),
            new Reference("Matthew",    11, 28, "Come to me, all you who are weary and burdened, and I will give you rest." ),
            new Reference("Philippians",4,  13, "I can do all things through Christ who strengthens me." ),
        ];
        
        
        Random random = new Random();
        int index1 = random.Next(0, references.Count);
        
        Scripture scripture = new Scripture(references[index1]);
        string loop = "";
        while (loop.Replace(" ", "") == "")
        {
            
            Console.Clear();
            
            scripture.GetDisplayText();
            loop = Console.ReadLine();
            scripture.HideRandomWords();
            Console.Clear();

            scripture.GetDisplayText();

            if (scripture.IsCompletelyHidden())
            {
                loop = "quit";
            }
        }
            
        
    }
}
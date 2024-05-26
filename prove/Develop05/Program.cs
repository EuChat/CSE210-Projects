using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        bool loop = true;
        Console.Clear();
        Base criteria = new Base();
        GoalManager manager =    new GoalManager();
        manager.Start();
        while (loop)
        {
            Menu();
        }
        
        void Menu()
        {
            Console.WriteLine($"You have {manager.GetScore()} points\n\nMenu Options:\n  1. Create New Goal  \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Event \n  6. Quit\nSelect a choice from the menu:");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3.Checklist Goal\nWhich goal would you like to create?  ");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    criteria.Questions();
                    SimpleGoal simpleGoal = new SimpleGoal (criteria.GetName(),criteria.GetDescription(), criteria.GetPoints(), false);
                    manager.CreateGoal (simpleGoal);
                }
                else if (answer == 2)
                {
                    criteria.Questions();
                    EternalGoal eternalGoal =   new EternalGoal(criteria.GetName(),criteria.GetDescription(), criteria.GetPoints());
                    manager.CreateGoal(eternalGoal);
                }
                else if (answer == 3)
                {
                    criteria.Questions();
                    criteria.Target();
                    ChecklistGoal checklistGoal=new ChecklistGoal(criteria.GetName(),criteria.GetDescription(), criteria.GetPoints(), criteria.GetTarget(), criteria.GetBonus());
                    manager.CreateGoal(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid Answer!");
                }
                
            }

            else if (answer == 2)
            {
                manager.ListGoalDetails();
                Thread.Sleep(3000);
            }

            else if (answer == 3)
            {
                manager.SaveGoals();
            }

            else if (answer == 4)
            {
                manager.LoadGoals(true, false);
            }

            else if (answer == 5)
            {
                
                manager.RecordEvents();
            }

            else if (answer == 6)
            {
                loop = false;
            }

            else
            {
                Console.WriteLine("Invalid Answer!");
            }

        }

        
    }
}
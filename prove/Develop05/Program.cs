using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        

        bool running = true; 

        while (running)
        {
            Console.Write($"You have {journal.Get_Score()} points\n");
            Console.WriteLine();
            Console.Write("Menu Options: \n");
            Console.Write(" 1. Create New Goal\n");
            Console.Write(" 2. List Goals\n");
            Console.Write(" 3. Save Goals\n");
            Console.Write(" 4. Load Goals\n");
            Console.Write(" 5. Record Event\n");
            Console.Write(" 6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {Console.WriteLine("Select goal type:\n");
                    Console.WriteLine("1. Simple Goal\n");
                    Console.WriteLine("2. Eternal Goal\n");
                    Console.WriteLine("3. Checklist Goal\n");
                    Console.Write("Choice: \n");
                    string choice = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Value: ");
                    int val = int.Parse(Console.ReadLine());

                    if (choice == "1")
                        journal.AddGoal(new Simple(name, desc, val));

                    else if (choice == "2")
                        journal.AddGoal(new Eternal(name, desc, val));

                    else if (choice == "3")
                    {
                        Console.Write("Target Count: ");
                        int required = int.Parse(Console.ReadLine());
                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());
                        journal.AddGoal(new Checklist(name, desc, val, bonus, required, 0));
                    }

                    Console.WriteLine("Goal created!\n");
                    
                    break;}
                case "2":
                    Console.Write("Goals: \n");
                    for (int i = 0; i < journal.Count(); i++)
                    {
                        Goal g2 = journal.GetGoal(i);
                        Console.WriteLine($"{i+1}. {g2.GetType().Name} - Complete: {g2.IsComplete()}");
                    }
                    break;
                case "3":
                    Console.Write("Filename: ");
                    journal.Save(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Filename: ");
                    journal.Load(Console.ReadLine());
                    
                    break;
                case "5":
                    Console.WriteLine("Goals: ");
                    {for (int i = 0; i < journal.Count(); i++)
                        {
                            Goal g = journal.GetGoal(i);
                            Console.WriteLine($"{i+1}. {g.GetType().Name}|Complete: {g.IsComplete()}");
                        }

                        Console.Write("Select a goal to record: ");
                        int index = int.Parse(Console.ReadLine()) - 1;

                        if (index >= 0 && index < journal.Count())
                        {
                            Goal g = journal.GetGoal(index);
                            int earned = g.Do_Goal();
                            journal.AddScore(earned);
                            Console.Write($"Points earned: {earned}\n");
                        }
                    break;}
                    case "6":
                        Environment.Exit(0);
                        break;
                    default: 
                        break;
                    
            }
        }
    }
}
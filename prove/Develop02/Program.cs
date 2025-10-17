using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.Write("What is the name of your journal? ");
        journal._Name = Console.ReadLine();
        
        bool running = true;

        while (running)
        {
            Console.Write("Welcome to the Journal Program!\n");
            Console.Write("Please select one of the following choices: \n");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.Write("What would you like to do? ");

            string selection = Console.ReadLine();
            int Selection = int.Parse(selection);

            Console.Write("");
            
            switch (Selection)
            {
                case 1 :
                    journal.NewEntry();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3 :
                    Console.Write("What is the filename? ");
                    string LoadFile = Console.ReadLine();
                    journal.Load(LoadFile);
                    break;
                case 4:
                    Console.Write("What is the filename? ");
                    string SaveFile = Console.ReadLine();
                    journal.Save(SaveFile);
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.Write("Invalid input. Try again.");
                    break;
            }
        }
        
    }
}
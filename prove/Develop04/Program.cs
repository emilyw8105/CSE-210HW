using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu: \n");
            Console.WriteLine(" 1. Start breathing activity\n");
            Console.WriteLine(" 2. Start reflecting activity\n");
            Console.WriteLine(" 3. Start listing activity\n");
            Console.WriteLine(" 4. Quit\n");
            Console.Write("Select a choice from the menu: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1": 
                    new Breathing("Welcome to the Breathing Activity: \n\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus your breathing.", 0).Breather();
                    break;
                case "2":
                    new Reflection("Welcome to the Reflecting Activity: \n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0).Reflect();
                    break;
                case "3":
                    new Listing("Welcome to the Listing Activity:\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ", 0).List();
                    break;
                case "4":
                    running = false;
                    return;
                default:
                    break;

            }
        }
    }
}
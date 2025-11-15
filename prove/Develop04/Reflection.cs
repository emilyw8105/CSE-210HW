using System;
using System.Collections.Generic;

public class Reflection : Activities
{
    private List<string> _prompt;
    private List<string> _reflectQuestion;

public void Reflect()
{
    Start();
    Console.WriteLine("Consider the following prompt: \n\n");
    
    Console.WriteLine($"---{RandomPrompt()}---\n\n");
    
    Console.WriteLine("When you have something in mind, press enter to continue. \n");
    Console.ReadLine();

    Console.WriteLine("Now ponder each of the next questions as they relate to this experience. \n");
    Console.Write("You may begin in: ");
    Timer(5);
    DateTime endTime = DateTime.Now.AddSeconds(GetTime());
    while (DateTime.Now < endTime)
    {
        Console.WriteLine($"\n> {RandomQuestion()}");
        Animator(5);
    }

    End("Reflection");
}
    private Random random = new Random();
    private string RandomPrompt()
    {
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Prompt: \n");
        Console.WriteLine(RandomPrompt());
    }

    private string RandomQuestion()
    {
        int index = random.Next(_reflectQuestion.Count);
        return _reflectQuestion[index];
    }

    public void displayQuestion()
    {
        Console.WriteLine("Reflection question: \n");
        Console.WriteLine(RandomQuestion());
    }

    public Reflection(string introMessage, int time) : base(introMessage, time)
    {
        _prompt = new List<string>
        {
            "Think of a time where you were surprised today", 
            "Think of a time where you struggled with something", 
            "Think of a time where you felt the spirit today", 
            "Think of a time where you served someone today"
        };

        _reflectQuestion = new List<string>
        {
            "How did this experience help you? ",
            "What would you do differently now? ",
            "What is your favorite thing about this experience? ",
            "How can this experience help others? ",
            "How did you feel after this experience? ",
            "Have you ever done anything like this before? "
        };


    }
}
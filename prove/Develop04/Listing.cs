using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activities
{
    private List<string> _inputs;
    private List<string> _prompt;

    private Random random = new Random();
    private string RandomPrompt()
    {
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

    public void List()
    {
        Start();
        
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine(RandomPrompt());
        Console.WriteLine("You may begin in:");
        Timer(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetTime());
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    _inputs.Add(input);
            }

        }

        Console.WriteLine($"\nYou listed {_inputs.Count} items!");
        End("listing");
    }
    
    public Listing(string introMessage, int time): base(introMessage, time)
    {
        _prompt = new List<string>
        {
            "Who are some people who are important to you? ",
            "Who did you talk to this week? ",
            "What gospel tools have you used this week? ",
            "What foods did you eat this week? ",
            "What did you do to serve others this week? "
        };
        _inputs = new List<string>();
        
    }
}

using System;
using System.Threading;

public class Activities
{
    private string _introMessage;
    private int _time;
    
    public void Start()
    {
        Console.Clear();
        Console.WriteLine(_introMessage);
        Console.Write("\nHow long, in seconds, would you like for your session? \n");
        string selection = Console.ReadLine();
        _time = int.Parse(selection);
        Console.WriteLine("\nGet ready... ");
        Animator(3);
    }

    public void Animator(int sec)
    {
        string[] spinner = {"^", ">", "v", "<"};
        DateTime endTime = DateTime.Now.AddSeconds(sec);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }

    public void Timer(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }

    public void End(string ActivityName)
    {
        Console.WriteLine("Well done!! \n");
        Animator(2);
        Console.WriteLine($"You have completed another {_time} seconds of the {ActivityName} activity. \n");
        Animator(3);
    }

    public Activities(string introMessage, int time)
    {
        _introMessage = introMessage;
        _time = time;
    }

    public int GetTime() => _time;
}

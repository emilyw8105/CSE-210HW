using System;

public class Breathing : Activities
{
    public void Breather()
    {
        Start();
        int allTime = GetTime();
        DateTime endTime = DateTime.Now.AddSeconds(allTime);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... \n");
            Timer(4);
            Console.WriteLine("Breathe out... \n");
            Timer(6);
            
            
        }
        End("breathing");
    }

    public Breathing(string introMessage, int time) : base(introMessage, time)
    {
        
    }
}
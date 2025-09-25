using System;

class Program
{
    static void Main(string[] args)
    {
        
        int Guess_Number = 0;

        //Console.Write("What is the magic number? ");
        //Magic_Number = int.Parse(Console.ReadLine());
        Random Rando_Magic_Number = new Random();
        int Magic_Number = Rando_Magic_Number.Next(1 , 100);

        while (Guess_Number != Magic_Number)
        {


            Console.Write("What is your guess? ");
            Guess_Number = int.Parse(Console.ReadLine());

            if (Guess_Number > Magic_Number)
            {
                Console.Write("Lower \n");
            }
            if (Guess_Number < Magic_Number)
            {
                Console.Write("Higher \n");
            }
            if (Guess_Number == Magic_Number)
            {
                Console.Write("You guessed it!");
            }
        }
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        int Guess_Number = 0;

        //First step for prep 3: ask user for magic number
        //Console.Write("What is the magic number? ");
        //Magic_Number = int.Parse(Console.ReadLine());
        Random Rando_Magic_Number = new Random();
        int Magic_Number = Rando_Magic_Number.Next(1 , 100);

        //Loop for user to guess magic number
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
            else
            {
                Console.Write("invalid input");
            }
        }
    }
}
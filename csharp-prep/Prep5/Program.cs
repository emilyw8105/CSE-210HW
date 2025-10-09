using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = input_name();
        int num = input_num();

        int squared_num = square_num(num);

        int birth_year;
        user_birth_year(out birth_year);


        display_results(name, squared_num, birth_year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string input_name()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int input_num()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static void user_birth_year(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int square_num(int number)
    {
        int square = number * number;
        return square;
    }

    static void display_results(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}

    

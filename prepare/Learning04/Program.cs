using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Samuel Bennet", "Multiplication");
        A1.assignment_summary();

        Console.WriteLine();

        Math A2 = new Math("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        A2.assignment_summary();
        A2.display();

        Console.WriteLine();

        Writing A3 = new Writing("The Causes of WWII", "Mary Waters", "European History");
        A3.assignment_summary();
        A3.Get_Writing();

        Console.WriteLine();
        
    }
}
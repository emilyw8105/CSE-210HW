using System;
using System.Runtime.CompilerServices;



Console.WriteLine("Input your grade (0-100): ");
string _x = Console.ReadLine();

int x = int.Parse(_x);
string letter = "";

if (x >= 90 && x <= 100)
{
    letter = "A";
}
else if (x >= 80 && x < 90)
{
    letter = "B";
}
else if (x >= 70 && x < 80)
{
    letter = "C";
}
else if (x >= 60 && x < 70)
{
    letter = "D";
}
else if (x >= 0 && x < 60)
{
    letter = "F";
}
else
{
    Console.Write("Invalid number. Please try again.");
}

Console.Write($"Your grade is: {letter}");

if (x >= 70 && x < 100)
{
    Console.Write("\nCongratulations you passed the course!");
}
else if (x >= 0 && x < 70)
{
    Console.Write("\nYou did not pass this course.");
}
else
{
    Console.Write(" ");
}
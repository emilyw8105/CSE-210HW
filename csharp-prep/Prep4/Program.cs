using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> num_list = new List<int>();

        int num_input = -1;


        while (num_input != 0)
        {
            Console.Write("Enter a list of numbers. Enter 0 when you are finished. ");
           
            string user_num = Console.ReadLine();
            num_input = int.Parse(user_num);

            if (num_input != 0)
            {
                num_list.Add(num_input);
            }

        }

        int sum = num_list.Sum();
        Console.Write($"Sum: {sum}\n");

        int values = num_list.Count; 
        int average = sum / values;
        Console.Write($"Average: {average}\n");

        int max = num_list[0];
        foreach (int number in num_list)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine($"Max: {max}\n");
    }
}
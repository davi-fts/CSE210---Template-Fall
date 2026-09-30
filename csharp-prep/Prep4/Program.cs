using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number_input = -10;
        while (number_input != 0) 
        {
            Console.Write("Enter number: ");
            string user_input  = Console.ReadLine();
            number_input = int.Parse(user_input);

            if (number_input != 0)
            {
                numbers.Add(number_input);
            }

        }

            int sum = 0;
            foreach (int number in numbers)

        {
            sum += number;
        }

        Console.WriteLine($"Sum: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {avg}");

        int max = numbers[0];

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Max: {max}");

    }

}
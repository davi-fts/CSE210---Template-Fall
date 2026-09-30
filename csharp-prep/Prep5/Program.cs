using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMessage();

        string name = AskUserName();
        int number = AskUserNumber();

        int square_num = SquareNumber(number);

        int year_of_birth;
        ask_birth_year(out year_of_birth);

        DisplayResult(name, square_num, year_of_birth);
    }

    static void DisplayWelcomeMessage()

{
    Console.WriteLine("Welcome to the Program!");
}


static string AskUserName()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskUserNumber()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void ask_birth_year(out int birthday)

    {
        Console.Write($"Year born: ");
        birthday = int.Parse(Console.ReadLine());

    }

static int SquareNumber(int number)
    {
        int square_num = number * number;
        return square_num;
    }

    static void DisplayResult(string name, int square_num, int year_of_birth)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will tun {2026-year_of_birth} years old in 2026");
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

{
    Console.Write("What is the magic number? ");
    string magic_input = Console.ReadLine();
    int magic_number = int.Parse(magic_input);


   int guess =  -10;

    while (guess != magic_number)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (magic_number > guess)
                {
                    Console.WriteLine("Higher");
                }
    else if (magic_number < guess)
                {
                    Console.WriteLine("Lower");
                }

    else
                {
                    Console.WriteLine("You got it right!");
                }

    

            }
        }
    }
}


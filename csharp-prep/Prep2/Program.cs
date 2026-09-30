using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        int UserGrade = int.Parse(Console.ReadLine());


    
        if (UserGrade >= 90)

        {
            Console.WriteLine("A");
        }

        else if (UserGrade >= 80)

        {
            Console.WriteLine("B");
        }

        else if (UserGrade >= 70)

        {
            Console.WriteLine("C");
        }
        else if (UserGrade >= 60)

        {
            Console.WriteLine("D");
        }
        else 

        {
            Console.WriteLine("F");
        }
    }
}


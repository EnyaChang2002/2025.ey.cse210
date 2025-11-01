using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int x = int.Parse(percentage);
        string letter = "";

        if (x >= 90)
        {
            Console.WriteLine("Congrats!");
            letter = "A";
        }
        else if (x >= 80)
        {
            Console.WriteLine("Congrats!");
            letter = "B";
        }
        else if (x >= 70)
        {
            Console.WriteLine("Congrats!");
            letter = "C";
        }
        else if (x >= 60)
        {
            Console.WriteLine("You can do better!");
            letter = "D";
        }
        else if (x < 60)
        {
            Console.WriteLine("You can do better!");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

    }
}
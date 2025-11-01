using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        string contin = "";
        string guessNumber = "";

        do
        {
            Console.WriteLine("Guess the number! ");
            guessNumber = Console.ReadLine();
            int number2 = int.Parse(guessNumber);

            if (number2 > number)
            {
                contin = "no";
                Console.WriteLine("Lower.");
            }
            else if (number2 < number)
            {
                contin = "no";
                Console.WriteLine("Higher.");
            }
            else
            {
                contin = "yes";
                Console.WriteLine("Correct!");
            }
        }
        while (contin != "yes");
        

    }
}
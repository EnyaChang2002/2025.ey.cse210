using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string UsersName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int FavNum()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string holdNum = Console.ReadLine();
            int fav = int.Parse(holdNum);
            return fav;
        }

        static void FinalMessage(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is: {square}");
        }

        DisplayMessage();
        string userName = UsersName();
        int favNum = FavNum();
        int square = favNum * favNum;
        FinalMessage(userName, square);

    }
}
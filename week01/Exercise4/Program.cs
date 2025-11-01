using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> number = new List<int>();
        string holdNum = "1";
        int sum = 0;

        while (holdNum != "0")
        {
            Console.WriteLine("Enter a number: ");
            holdNum = Console.ReadLine();
            int newNumber = int.Parse(holdNum);
            number.Add(newNumber);
        }

        foreach (int num in number)
        {
            sum = sum + num;
        }

        int largest = 0;

        foreach (int num in number)
        {
            if (largest < num)
            {
                largest = num;
            }
            else
            {
            }
        }

        float ave = ((float)sum) / number.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}
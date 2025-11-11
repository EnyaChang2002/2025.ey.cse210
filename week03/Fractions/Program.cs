using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _newF = new Fraction();
        _newF.SetTop(1);
        Console.WriteLine(_newF.GetFractionString());
        Console.WriteLine(_newF.GetDecimalValue());

        _newF.SetTop(5);
        Console.WriteLine(_newF.GetFractionString());
        Console.WriteLine(_newF.GetDecimalValue());

        _newF.SetTop(3);
        _newF.SetBottom(4);
        Console.WriteLine(_newF.GetFractionString());
        Console.WriteLine(_newF.GetDecimalValue());

        _newF.SetTop(1);
        _newF.SetBottom(3);
        Console.WriteLine(_newF.GetFractionString());
        Console.WriteLine(_newF.GetDecimalValue());
    }
}
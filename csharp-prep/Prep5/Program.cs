using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMessage();
        string first = GetUserFirstName();
        string last = GetUserLastName();
        int number = GetUserNumber();
        int squareNum = SquareNumber(number);
        DisplayResult(first, last, number, squareNum);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello and welcome to the program!");
    }

    static string GetUserFirstName()
    {
        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();
        return first;
    }

    static string GetUserLastName()
    {
        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();
        return last;
    }

    static int GetUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNum = number * number;
        return squaredNum;
    }

    static void DisplayResult(string first, string last, int number, int squaredNum)
    {
        Console.WriteLine($"Your name is {first} {last}, your favorite number is {number}, and the number squared is {squaredNum}.");
    }
}

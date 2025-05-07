using System;

class Program
{
    static void Main(String[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        double squared = SquareNumber(favoriteNumber);
        DisplayResult(userName, squared);
    }   

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    } 

    static string PromptUserName()
    {
        Console.Write("Enter your username: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static double SquareNumber(int number)
    {
        return Math.Pow(number, 2);
    }

    static void DisplayResult(string name, double square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}

using System;
using System.Net.NetworkInformation;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!!!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        Console.WriteLine($"Hello {username}, your favorite number is {number} and its square is {squaredNumber}.");
    }
}
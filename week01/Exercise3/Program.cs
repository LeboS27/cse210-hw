using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {   
        string response = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int tries = 0;

        do
        {
            Console.Write("Guess the number between 1 & 100: ");
            int guess = int.Parse(Console.ReadLine());
            tries++;


            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Please enter a number within range of 1 - 100.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Guess higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess lower!");
            }
            else if (guess == number)
            {
                Console.WriteLine("Uyingozi, you've won!");
                Console.WriteLine($"You did it in {tries} tries ");
                Console.Write("Do you want to play again? y or n: ");
                tries = 0;
                response = Console.ReadLine().ToLower();
                if (response == "yes" || response == "y")
                {
                    number = randomGenerator.Next(1, 100);
                    continue;
                }
                else
                {
                    Console.WriteLine("Game over, coward! ");
                    response = "no";
                }
            }
        } while (response == "yes" || response == "y");
    }
}
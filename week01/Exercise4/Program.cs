using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int average;
        int lowest_positive = 1000000;
        int largest_num = 0;
        Console.WriteLine("Enter numbers, type 0 when finished: ");
        while (true)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            else
            {
                numbers.Add(input);
                sum += input;
                if (input < lowest_positive && input > 0)
                {
                    lowest_positive = input;
                }
                else if (input > largest_num)
                {
                    largest_num = input;
                }
            }
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The highest of the numbers is: {largest_num}");
        Console.WriteLine($"The lowest of the numbers is: {lowest_positive}");


    }
}
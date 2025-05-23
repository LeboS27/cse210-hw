using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the mark you got from the exam: ");
        int mark = int.Parse(Console.ReadLine());
        if (mark >= 90)
        {
            Console.WriteLine("A");
        }
        else if (mark >= 80)
        {
            Console.WriteLine("B");
        }
        else if (mark >= 70)
        {
            Console.WriteLine("C");
        }
        else if (mark >= 60)
        {
            Console.WriteLine("D");
        }
        else if (mark < 60)
        {
            Console.WriteLine("F");
        }
        else
        {
            Console.WriteLine("Invalid Mark");
        }
    }
}
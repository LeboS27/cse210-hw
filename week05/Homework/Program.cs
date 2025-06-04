using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");#
        WritingAssignment assignment1 = new WritingAssignment("Lebohang Sebata", "Electrical Machines", "The Fundamentals of Circuits");
        //assignment1.GetSummary();
        Console.WriteLine(assignment1.GetWritingInformation());
    }
}
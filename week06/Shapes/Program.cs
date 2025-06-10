using System;

class Program
{
    static void Main(string[] args)
    {
        Shape Circle = new Circle(6, "Blue");
        Shape Rectangle = new Rectangle(3, 6, "Green");
        Shape Square = new Square(8, "Purple");

        //Console.WriteLine($"Circle Area: {Circle.GetArea()} Color: {Circle.GetColor()}");
        //Console.WriteLine($"Rectangle Area: {Rectangle.GetArea()} Color: {Rectangle.GetColor()}");
        //Console.WriteLine($"Square Area: {Square.GetArea()} Color: {Square.GetColor()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(Circle);
        shapes.Add(Rectangle);
        shapes.Add(Square);

        foreach (Shape shapex in shapes)
        {
            Console.WriteLine($"Shape Area: {shapex.GetArea()}");
        }

    }
}
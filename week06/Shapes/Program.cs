using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        Console.WriteLine("\nIterating through shape list:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("purple", 4));
        shapes.Add(new Rectangle("red", 5, 6));
        shapes.Add(new Circle("yellow", 10));

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}
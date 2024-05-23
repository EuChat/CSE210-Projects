using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(new  Square("blue", 7));
        shapes.Add(new  Rectangle("red", 7, 14));
        shapes.Add(new  Circle("green", 7));

        foreach (Shapes shape in shapes)
        {
            System.Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");
        }
    }
}
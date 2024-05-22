using System;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new Square("blue", 4);

        // Console.WriteLine(square.GetColor());

        // //New color
        // square.SetColor("red");
        // Console.WriteLine(square.GetColor());

        // //Get square area
        // Console.WriteLine(square.GetArea());

    //    Rectangle rectangle = new Rectangle("white", 6, 4);
    //    Console.WriteLine(rectangle.GetColor());

    //    rectangle.SetColor("black");
    //    Console.WriteLine(rectangle.GetColor());

    //    Console.WriteLine(rectangle.GetArea());

    // Circle circle = new Circle("green", 8);
    // Console.Write(circle.GetColor());

    // circle.SetColor("orange");
    // Console.WriteLine(circle.GetColor());

    // Console.WriteLine(circle.GetArea());

    List<Shape> shapes = new List<Shape>();

    Square shape1 = new Square("blue", 4);
    shapes.Add(shape1);

    Rectangle shape2 = new Rectangle("white", 6, 4);
    shapes.Add(shape2);

    Circle shape3 = new Circle("green", 8);
    shapes.Add(shape3);

    foreach(Shape shape in shapes)
    {
        string color = shape.GetColor();
        double area = shape.GetArea();

        Console.WriteLine($"The {color} shape has an area of {area}.");
    }
    }
}
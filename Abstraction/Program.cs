using System;

// Abstract class representing a shape
public abstract class Shape
{
    // Abstract method for drawing
    public abstract void Draw();
}

// Concrete class representing a circle
public class Circle : Shape
{
    // Implementation of the Draw method for a circle
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Concrete class representing a square
public class Square : Shape
{
    // Implementation of the Draw method for a square
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of concrete classes
        Shape myCircle = new Circle();
        Shape mySquare = new Square();

        // Using the Draw method without knowing the specific implementation
        Console.WriteLine("Drawing shapes:");
        DrawShape(myCircle);
        DrawShape(mySquare);
    }

    // Method to draw a shape, accepting any class derived from Shape
    static void DrawShape(Shape shape)
    {
        shape.Draw();
    }
}


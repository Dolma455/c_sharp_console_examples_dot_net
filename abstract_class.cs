using System;
abstract class Shape
{
    //Abstract method
    public abstract double CalculateArea();

    //Concrete method
    public void DisplayArea()
    {
        double area = CalculateArea();
        Console.WriteLine($"Area: {area}");
    }
}

//Derived class: Circle
class Circle : Shape
{
    //Properties
    public double Radius { get; set; }

    //Implementation of abstract method
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

//Derived class: Rectangle
class Rectangle : Shape
{
    //properties
    public double Length { get; set; }
    public double Width { get; set; }
    //Implementation of abstract method
    public override double CalculateArea()
    {
        return Length * Width;
    }
}


class Program
{
    static void Main()
    {
        //Creating instance of circle
        Circle c = new Circle();
        c.Radius = 10;
        c.DisplayArea();

        Rectangle r = new Rectangle();
        r.Length = 4;
        r.Width = 5;
        r.DisplayArea();

    }
}


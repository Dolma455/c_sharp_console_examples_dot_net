
using System;
namespace structures {
 public struct Point {
    public int X;
    public int Y;

    //Custom constructor to initialize the fields
    public Point(int x, int y) {
        X=x;
        Y=y;
    }
    //Method to display the coordinates

    public void Display() {
        Console.WriteLine($"X: {X}, Y: {Y }");
    }
 }

 class Program {
    static void Main() {
        Point myPoint=new Point(10,20);
        myPoint.Display();
    }
 }
}
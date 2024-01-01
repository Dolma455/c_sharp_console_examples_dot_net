using System;
public interface Drawable {
    void draw();
}

public class Rectangle: Drawable {
    public void draw() {
        Console.WriteLine("Drawing rectangle..");
    }
}

public class Circle: Drawable {
    public void draw() {
        Console.WriteLine("Drawign Rectangle");
    }
}

public class Program {
    public static void Main() {
        Drawable d;
    d = new Rectangle();
    d.draw();

    }
    


}
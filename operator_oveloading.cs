class Vector {
    private double v1;
    private double v2;

    public Vector(double x, double y)
    {
        X=x;
        Y=Y;
    }

    public double X {
        get;
        set;
    }
    public double Y {
        get;
        set;
    }   

    //Overload + opeartor to add two vectors
    public static Vector operator +(Vector v1, Vector v2) {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }
    //Overload - operatorr to subtract one vector from another
    public static Vector operator - (Vector v1, Vector v2) {
        return new Vector(v1.X -v2.X, v1.Y-v2.Y);
    }

    //overload * operator to multiply a vector by a scalar
    public static Vector operator *(Vector v, double scalar) {
        return new Vector(v.X*scalar,v.Y*scalar);
    }

    public override string ToString()
    {
        return $"({X},{Y})";
    }


}

class Program {
    public static void Main() {
        Console.WriteLine("Enter components for vector v1:");
        Console.WriteLine("X:");
        double x1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Y:");    
        double y1=Convert.ToDouble(Console.ReadLine());
        Vector v1=new Vector(x1,y1);
       //Input for v2
       Console.WriteLine("Enter components for vector v2:");
       Console.WriteLine("X:");
         double x2=Convert.ToDouble(Console.ReadLine());    
        Console.WriteLine("Y:");
        double y2=Convert.ToDouble(Console.ReadLine());
         Vector v2=new Vector(x2,y2);
        Console.WriteLine($"\n Vector v1: {v1}");
        Console.WriteLine($"\n Vector v2: {v2}");
        
    }
}
namespace DynamicBinding {
    class Shape {
        public virtual void Draw() {
            Console.WriteLine("Drawing a generic shape");
        }
    }
    class Circle : Shape {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Rectangle: Shape {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Program {

        static void DrawShape(Shape shape)  {
            shape.Draw();
        
        }
            static void Main(string[] args)
            {
                Shape shape1=new Circle();
                Shape shape2=new Rectangle();
                DrawShape(shape1);
                DrawShape(shape2);
                
            }

        
    }
}
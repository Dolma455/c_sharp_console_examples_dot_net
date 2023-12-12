using System;
namespace OperatorOverloading {
    class Complex{
        private int x;
        private int y;

        public Complex()
        {
        }

        public Complex(int i, int j) {
            this.x=i;
            this.y=j;
        }
        public void ShowXY() {
            Console.WriteLine("{0} {1}",x, y);
        }
        //Ocerloading an unaory '-' operator

        public static Complex operator - (Complex c) {
            Complex temp=new Complex();
            temp.x=-c.x;
            temp.y=-c.y;
            return temp;
        }
    }

    class Program {
        static void Main() {
            Complex c1=new Complex(10,20);
            Complex c2=new Complex();
            c2.ShowXY();

        }
    }
}
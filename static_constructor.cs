using System;
class Cons {
    public Cons() {
         Console.WriteLine("I am inside constructor");
    }
    static Cons() {
        Console.WriteLine("I am inside static constructor");
    }
}

class Program {
    static void Main() {
        Cons obj=new Cons();
        Console.ReadKey();
    }

}
using System;
class Virtual {
    public virtual void message() {
        Console.WriteLine("This is test");

    }
    class Program {
        static void Main() {
            Virtual obj=new Virtual();
            obj.message();
            Console.ReadKey();

        }
    }
}
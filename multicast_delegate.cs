using System;
public delegate void MyDelegate(string message);
class Program {
    //Define methods that match the delegate
    public static void SayHello(string message) {
        Console.WriteLine("Hello,"+message);

    }
    public static void SayGoodBye(string message) {
        Console.WriteLine("Goodbye,"+message);
    }
    static void Main() {
        //Create instances of the delegate
        MyDelegate hello=SayHello;
        MyDelegate goodbye=SayGoodBye;
        //Combine a delegate into a multicast delegate
        MyDelegate multicast
        =hello+goodbye;
        multicast("Wiorld");
    }
}

using System;
class Program {
    static void Main() {
        Action<string> printAction=(x)=> Console.WriteLine(x);
        printAction("Hello,World");
    }
}
using System;
class Program 
 {
    static void Main() {
            Func<int, int> addFunc = (x) => x + 1;
            int result=addFunc(1);
            Console.WriteLine(result);

    }

 }
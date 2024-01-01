// using System;

// // Declare a delegate
// public delegate int MyDelegate(int x, int y);

// class Program
// {
//     // Define a method that matches the delegate type
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static void Main()
//     {
//         // Create an instance of the delegate
//         MyDelegate del = Add;

//         // Invoke the delegate
//         int result = del(10, 20);

//         Console.WriteLine(result);  // Outputs: 30
//     }
// }
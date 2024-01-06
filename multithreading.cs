// using System;
// using System.Threading;

// class Program {
//     static void Main() {
//         Thread thread1=new Thread(()=>PrintMessage("Hello from thread 1"));
//         thread1.Start();

//         Thread thread2=new Thread(()=>PrintMessage("Hello from thread2"));
//     }

//     static void PrintMessage(string message) {
//         for (int i=0;i<=5;i++) {
//                 Console.WriteLine(message);
//                 Thread.Sleep(1000);
//         }
//     }
// }
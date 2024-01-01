// using System;
// using System.Runtime.InteropServices;
// class Program {
//     static void Main() {
//         //Creating new queue of integers
//         Queue<int> myQueue=new Queue<int>();
//         Queue<String> strQueue=new Queue<String>();
//         //Enqueueing elements
//         myQueue.Enqueue(1);
//         myQueue.Enqueue(2);
//         myQueue.Enqueue(3);
//         Console.WriteLine("myqueue contains elemts as"+myQueue);
//         int firstElement=myQueue.Dequeue();
//         Console.WriteLine("First element is" +firstElement);

//         //Peek at the front element withouth removing it
//         int peekedElement=myQueue.Peek();
//         Console.WriteLine("Peeked element is"+peekedElement);
//         Console.WriteLine("Remaining elements are");
//         foreach(int element in myQueue
//         ) {
//             Console.WriteLine(element);
//         }
//         myQueue.Clear();
//         foreach(int element in myQueue
//         ) {
//             Console.WriteLine("No element");
//             Console.WriteLine(element);
//         }

//         strQueue.Enqueue("Hello");
//         strQueue.Enqueue("World");
//         Console.WriteLine("strings are" );
//         foreach(string strelement in strQueue) {
//             Console.WriteLine(strelement);
//         }
//         string e=strQueue.Dequeue();
//         Console.WriteLine("Strings are"+ e);



//     }
// }
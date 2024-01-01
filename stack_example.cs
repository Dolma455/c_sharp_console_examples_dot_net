// using System;
// class Program {
//     static void Main() {
//         //creating a new stack of integer
//         Stack<int> myStack=new Stack<int>();
//         Stack<string> strStack=new Stack<string>();
//         //Push add elements to the stack
//         myStack.Push(10);
//         myStack.Push(20);
//         myStack.Push(30);

//         //Popping elemets
//         int poppedElement=myStack.Pop();
//         Console.WriteLine("Popped element is" +poppedElement);

//         //Peek at the top element
//         int peekedElement=myStack.Peek();
//         Console.WriteLine("Peeked element is" +peekedElement);
//         Console.WriteLine("Remaining elements are");
//         foreach(int element in myStack) {
//             Console.WriteLine(element);
//         }

//         strStack.Push("Hello");
//         strStack.Push("World");
//         strStack.Push("Hi");
    
//     }
// }
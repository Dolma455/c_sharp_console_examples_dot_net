// //Delegate for a simpe calculator
// //Delegate knows how to call a method   

// using System;
// using System.Security.Cryptography.X509Certificates;
// //step 1: declaring the delegate
// delegate int CalculatorDelegate(int x, int y);

// class Calculator {
//     //step 2:Defining methods matching the delegate signature
//     public static int Add(int x, int y) {
//         return x+y;
//     }

//     public static int Subtract(int x, int y) {
//         return x-y;
//     }

//     public static int Multiply(int x, int y) {
//         return x*y;
//     }
//     public static int Divide(int x, int y) {
//         if(y!=0) 
//             return x/y;
//         else 
//             throw new ArgumentException("Cannot divide by zero");
        
//     }

    
// }

// class Program {
//     static void Main() {
//         //step 3: Creating inteances of the delegtae
//         CalculatorDelegate add =Calculator.Add;
//         CalculatorDelegate subtract=Calculator.Subtract;
//         CalculatorDelegate multiply=Calculator.Multiply;
//         CalculatorDelegate divide=Calculator.Divide;


//         //step 4: Using the delegtates to perform calculations
//         int result1=PerformCalculation(10,20,add);
//         Console.WriteLine($"Addition Result:{result1}");

//         int result2=PerformCalculation(10,20,subtract);
//         Console.WriteLine($"Subtraction Result:{result2}");

//         int result3=PerformCalculation(10,20,multiply);
//         Console.WriteLine($"Multiplication Result:{result3}");

//         try
//         {
//             int result4=PerformCalculation(10,0,divide);
//             Console.WriteLine($"Division Result: {result4}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
           
//         }

   
//     }
//     //step 5: Method that takes a delegate as a parameter and performs a calculation
//      static int PerformCalculation(int x, int y, CalculatorDelegate calDelegate) {
//         return calDelegate(x,y);
//             }
// }
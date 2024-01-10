// using System;
// using System.Globalization;
// using System.Linq;
// using System.Runtime.CompilerServices;

// class Program {

//     static void Main() {
//         int[] numbers=[5,10,8,9,6,4];
//     IEnumerable<int> numQuery1=from num in numbers
//     where num%2==0
//     orderby num
//     select num;
    

//     IEnumerable<int> numQuery2=numbers.Where(num=>num%2==0).OrderBy(n=>n);
//     foreach (int item in numQuery1)
//     {
//         Console.WriteLine(item+"");
        
//     }

//     Console.WriteLine(System.Environment.NewLine);
//     foreach (int item in numQuery2)
//     {
//         Console.WriteLine(item+"");
//     }
   

//     }
    

    
// }
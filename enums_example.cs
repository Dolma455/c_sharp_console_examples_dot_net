// using System;
// using System.Reflection;
// using Enums;
// namespace Enums {

//         //Define an enum named 'Days'
//         enum Days {
//             Sunday,
//             Monday,
//             Tuesday,
//             Wednesday,

//             Thursday,
//             Friday,
//             Saturday
//         }
//     }
// class Program {
//     static void Main() {
//         //Using days enum
//         Days today = Days.Wednesday;

//         //Display the value of today
//         Console.WriteLine("Today is:" +today);
//         Console.WriteLine(" The value of wednesday in Days is:" +(int)Days.Wednesday);

//         //Ckheck if today is week day or weekend

//         if(IsWeekDay(today)) {
//             Console.WriteLine("Today is week day");
//         }
//         else {
//             Console.WriteLine("Today is weekend");
//         }
        
//     }

//     static bool IsWeekDay(Days day) {
//         return day != Days.Saturday && day != Days.Sunday;
//     }
// }
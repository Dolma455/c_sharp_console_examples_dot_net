// using System;
// namespace Delegate1 {
//     delegate int NumberChanger(int n);
//     class TestDekegate {
//         static int num=10;
//         //define a method
//         public static int AddNum(int p) {
//             num +=p;
//             return num;
//         }
//         public static int MultNum(int q) {
//             num *=q;
//             return num;
//         }
//         public static int getNum() {
//             return num;
//         }
//         static void Main(string[] args) {
//             //create delegate instances
//             NumberChanger nc1=new NumberChanger(AddNum);
//             NumberChanger nc3=AddNum;
//             NumberChanger nc2=new NumberChanger(MultNum);
//             NumberChanger nc4=MultNum;
//             Console.WriteLine("Value of Num: {0}",getNum());
//             nc2(5);
//             Console.WriteLine("Value of Num:{0}",getNum());
//             nc3(2);
//             Console.WriteLine("value of num by object nc3 is:{0}",getNum());
//         }
//     }
// }
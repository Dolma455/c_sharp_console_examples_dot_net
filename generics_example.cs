// using System ;
// using System.Collections.Generic ;
// class Program 
//   {
//     static void Main() {
//         //Creating a generic list of Type T
//         List<int> integerList=new List<int>();
//         List<string> stringList=new List<string>();
//         List<double> doublesList=new List<double>();
//     //Adding elements to the list
//     integerList.Add(4);
//     integerList.Add(1);
//     integerList.Add(3);

//     stringList.Add("one");
//     stringList.Add("two");
//     stringList.Add("three");

//     doublesList.Add(1.1);
//     doublesList.Add(2.2);
//     doublesList.Add(3.3);


    

//     //Displaying the lists
//     Console.WriteLine("Integer List:");
//     DisplayList(integerList);

//     //Removing elements from the list
//     Console.WriteLine("Sorted List:");
//     integerList.Sort();
//     DisplayList(integerList);
//     Console.WriteLine("Remove an item");
//     integerList.Remove(1);
//     DisplayList(integerList);
//     Console.WriteLine("Remove at index");
//     integerList.RemoveAt(0);
//     DisplayList(integerList);

//     Console.WriteLine("String List:");
//     DisplayList(stringList);

//     Console.WriteLine("Double List:");
//     DisplayList(doublesList);
    

//     //Helper method to display the list 
//     static void DisplayList<T>(List<T> list) {
//         foreach (T item in list) {
//             Console.WriteLine(item);
//         }
//     }
//     }
//   }
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Create a new dictionary of strings, with string keys.
//         Dictionary<string, string> capitals = new Dictionary<string, string>();

//         // Add some elements to the dictionary.
//         capitals.Add("France", "Paris");
//         capitals.Add("Italy", "Rome");
//         capitals.Add("Japan", "Tokyo");
//         capitals.Add("USA", "Washington D.C.");

//         // Try to get the values of the keys.
//         string capitalOfItaly;
//         if (capitals.TryGetValue("Italy", out capitalOfItaly))
//         {
//             Console.WriteLine($"The capital of Italy is {capitalOfItaly}.");
//         }
//         else
//         {
//             Console.WriteLine("The capital of Italy is not in the dictionary.");
//         }

//         // Print the total number of keys in the dictionary.
//         Console.WriteLine($"The dictionary contains {capitals.Count} keys.");

//         // Remove a key/value pair from the dictionary.
//         capitals.Remove("Japan");

//         // Print the new total number of keys in the dictionary.
//         Console.WriteLine($"The dictionary contains {capitals.Count} keys after removing one.");
//     }
// }
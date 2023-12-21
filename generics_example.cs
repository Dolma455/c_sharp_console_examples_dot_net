// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Create a dictionary with dynamic types for both keys and values
//         Dictionary<dynamic, dynamic> dictionary = new Dictionary<dynamic, dynamic>();

//         // Add a string key and an integer value
//         dictionary.Add("One", 1);

//         // Add an integer key and a string value
//         dictionary.Add(2, "Two");

//         // Access values using keys
//         Console.WriteLine(dictionary["One"]); // Outputs: 1
//         Console.WriteLine(dictionary[2]); // Outputs: Two

//         // Add a new key-value pair with a 'Person' object as the key and a 'Car' object as the value
//         Person person = new Person("John", "Doe");
//         Car car = new Car("Toyota", "Corolla", 2020);
//         dictionary.Add(person, car);

//         // Access the 'Car' object using the 'Person' object as the key
//         Car johnsCar = dictionary[person];
//         Console.WriteLine(johnsCar.Description());
//     }
// }

// public class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }

//     public Person(string firstName, string lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }
// }

// public class Car
// {
//     public string Make { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }

//     public Car(string make, string model, int year)
//     {
//         Make = make;
//         Model = model;
//         Year = year;
//     }

//     public string Description()
//     {
//         return $"{Year} {Make} {Model}";
//     }
// }
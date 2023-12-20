// using System;
// public class Animal {
//     public string color="white";

// }
// public class Dog : Animal {
//     string color="black";
//     public void PrintColor() {
//         Console.WriteLine(base.color);
//         Console.WriteLine(color);
//     }
// }
// public class Program {
//     public static void Main() {
//         Dog d=new Dog();
//         d.PrintColor();
//     }
// }

// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating....");
//     }
// }
// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking....");
//     }
//     public void Eat()
//     {
//         //Using base to call the Eat method from the base class (Animal)
//         base.Eat();
//         Console.WriteLine("Dog is Eating...");
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         Dog d = new Dog();
//         d.Eat();
//         d.Bark();
//     }
// }
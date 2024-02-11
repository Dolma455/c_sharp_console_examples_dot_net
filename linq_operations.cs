using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Filtering with Where
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

       
    }
}
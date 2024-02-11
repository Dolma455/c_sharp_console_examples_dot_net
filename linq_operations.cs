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

        // Transforming with Select
        List<string> words = new List<string> { "hello", "world", "LINQ", "is", "awesome" };
        var uppercasedWords = words.Select(w => w.ToUpper());
        Console.WriteLine("Uppercased words: " + string.Join(", ", uppercasedWords));

        // Sorting with OrderBy and OrderByDescending
        numbers = new List<int> { 5, 7, 2, 4, 3, 1 };
        var sortedNumbers = numbers.OrderBy(n => n);
        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));
        var sortedNumbersDesc = numbers.OrderByDescending(n => n);
        Console.WriteLine("Sorted numbers (desc): " + string.Join(", ", sortedNumbersDesc));

         // Aggregating with Count, Sum, Max, Min, and Average
        numbers = new List<int> { 1, 2, 3, 4, 5 };
        int count = numbers.Count();
        int sum = numbers.Sum();
        int max = numbers.Max();
        int min = numbers.Min();
        double average = numbers.Average();
        Console.WriteLine($"Count: {count}, Sum: {sum}, Max: {max}, Min: {min}, Average: {average}");

       
    }
}
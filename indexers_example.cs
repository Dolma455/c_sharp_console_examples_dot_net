using System;

public class SampleCollection
{
    private int[] arr = new int[100];

    // Indexer declaration
    public int this[int i]
    {
        get
        {
            // The arr object is a private array used for data storage.
            return arr[i];
        }
        set
        {
            arr[i] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        SampleCollection collection = new SampleCollection();

        // Use the indexer to set values
        collection[0] = 1;
        collection[1] = 2;

        // Use the indexer to get values
        int firstValue = collection[0];  // firstValue will be 1
        int secondValue = collection[1]; // secondValue will be 2

        Console.WriteLine($"First Value: {firstValue}, Second Value: {secondValue}");
    }
}
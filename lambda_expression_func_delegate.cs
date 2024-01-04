class Program
{
    static void Main()
    {
        //Lambda expression with function delegate
        Func<int, int, int> add = (a, b) => a + b;

        //Call the lambda exxpression
        int result = add(10, 20);
        Console.WriteLine("Result:" + result);
    }
}
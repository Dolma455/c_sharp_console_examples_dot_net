class Program {
    static void Main() {
        try
        {
            int result=10/int.Parse("0");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error:" + e.Message);
            
            
        }
        finally {
            Console.WriteLine("Finally block executed");
        }
    }
}
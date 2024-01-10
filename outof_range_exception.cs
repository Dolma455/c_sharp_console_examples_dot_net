class Program {
    static void Main() {

        try
        {
             try
        {
            int[] arr=new int[5];
        int value=arr[10];
            
        }
        catch (IndexOutOfRangeException e) 
        {
            
            Console.WriteLine("Index out of range" + e.Message);
        }
        
        }
        catch (System.Exception)
        {
            
            Console.WriteLine("Exception occured");
        }

       
    }
}
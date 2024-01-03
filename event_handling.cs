using System;
class Counter
{
    private int value;
    //Declare the delegate
    public delegate void ValueChangedHandler(int newValue);

    //declare the event using the delegate
    public event ValueChangedHandler ValueChanged;

    public int Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
            ValueChanged?.Invoke(this.value);
        }
    }

}

class Program
{
    static void Main()
    {
        Counter counter = new Counter();

        //Subscribe toi the value changed event
        counter.ValueChanged += Counter_ValueChanged;
        counter.Value = 10;
        counter.Value = 20;

    }

    static void Counter_ValueChanged(int newValue)
    {
        Console.WriteLine("The value changed to" + newValue);
    }
}
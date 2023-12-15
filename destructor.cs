class Des {
    public Des(string message) {
        Console.WriteLine(message);
    }

    public void test() {
        Console.WriteLine("This is test");
    }
    //destructor
    ~Des() {
        Console.WriteLine("I am inside destructor");
        Console.ReadKey();
    }
}

class Construct {
    static void Main() {
        string msg="This is a constructor";
        Des obj=new Des(msg);
        obj.test();
    }
}
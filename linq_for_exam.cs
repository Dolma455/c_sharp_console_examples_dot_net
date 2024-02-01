//Language Integrated Query
using System.Security.Cryptography;

class Program {
    public static void Main() {
        List<string> list=new List<string>(){"hello","world"};

        var r=list.Where((a)=>a.Contains("Hello"));
        foreach(var i in r) {
            Console.WriteLine(i);
        }   
    }
}

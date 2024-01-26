class Linq {
    public static void Main() {
        List<string> list=new List<string>(){
            "a","b","c","d","e"
        };
        var r=from alphabet in list
                where alphabet=="a"
                select alphabet;

        foreach(var item in r) {
            Console.WriteLine(item);
        }
    }
}
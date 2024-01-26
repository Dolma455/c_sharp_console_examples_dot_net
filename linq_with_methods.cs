class LinQMethod {
    public static void Main() {
        List<string> list=new List<string>() {
            "hello Dolma",
            "Hi Dolma",
            "How are you?",
            "Where are you?"
        };

        var r=list.Where((d)=>d.Contains("Dolma"));
        foreach(var item in r) {
            Console.WriteLine(item);
        }
    }
}
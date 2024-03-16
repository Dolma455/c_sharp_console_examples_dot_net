using System;
using System.Linq;
class LinqTest {
    public static void Main() {
        List<string> names=new List<string>() {
            "Ram","Hari","Sita"
        };
        List<string> address=new List<string>() {
            "Kathmandu","Lalitpur","Bhaktapur"
        };

        //Using join
        var result=names.Join(address,
        str1=>str1,
        str2=>str2,
        (str1,str2)=>str1);

        //Using concat
        var result1=names.Concat(address);

        //Using Union
        var result2=names.Union(address);

        foreach (var a in result2)
        {
            Console.WriteLine(a);
        }
        
    }
    }

// class Student {
//     public int id {get;set;}
//     public string name {get;set;}
//     public string address {get;set;}
//     public Student(int id, string name, string address) {
//         this.id=id;
//         this.name=name;
//         this.address=address;
//     }

// }

// public class LinqTest {
//     public static void Main() {
//         List<Student> student=new List<Student>() {
//             new Student(1,"Hari","Kathmandu"),
//             new Student(2,"Shyam","Lalitpur"),
//             new Student(3,"Sita","Bhaktapur"),
//             new Student(4,"Nabin","Kathmandu"),
//         };
//         int maxId=student.Max(s=>s.id);
//         Console.WriteLine("Maximum id is: "+maxId);
//         int count=student.Count();
//         Console.WriteLine("Total number of students: "+count);

//        var result=student.Where(s=>s.address.Equals("Kathmandu")).OrderBy(s=>s.name);
//        Console.WriteLine("id\t name\t address");
//        foreach (var a in result)
//        {
//            Console.WriteLine(a.id + "\t" + a.name + "\t" + a.address);
//        }

//        var result1=student.OrderBy(s=>s.name);
//        foreach(var res in result1) {
//         Console.WriteLine(res.id + "\t" + res.name + "\t" + res.address);
//        }

//        //Use of group By
//        var result2=student.GroupBy(s=>s.address);
//        foreach(var res in result2) {
//         Console.WriteLine(res.Key);
//         foreach(var r in res) {
//             Console.WriteLine(r.id + "\t" + r.name + "\t" + r.address);
//         }
//        }
//     }
// }

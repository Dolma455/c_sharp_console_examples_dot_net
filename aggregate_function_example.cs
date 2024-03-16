class Student {
    public int id {get;set;}
    public string name {get;set;}
    public string address {get;set;}
    public Student(int id, string name, string address) {
        this.id=id;
        this.name=name;
        this.address=address;
    }

}

public class LinqTest {
    public static void Main() {
        List<Student> student=new List<Student>() {
            new Student(1,"Hari","Kathmandu"),
            new Student(2,"Shyam","Lalitpur"),
            new Student(3,"Sita","Bhaktapur"),
        };
        int maxId=student.Max(s=>s.id);
        Console.WriteLine("Maximum id is: "+maxId);
        int count=student.Count();
        Console.WriteLine("Total number of students: "+count);
        }
    }

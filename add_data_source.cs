public class Student
{
public string First {
    get;
    set;
}
public string Last {
    get;
    set;
}
public int ID {
    get;
    set;
}

public List<int> scores;

}

public class Program {
   
    static List<Student> students=[

    new Student {First="Sita",Last="Patel",ID=11,scores=new List<int>{45,56,78,99}},
    new Student {First="Rita",Last="Giri",ID=12, scores=new List<int>{45,67,87,65}},
    new Student {First="Ram",Last="Giri",ID=13,scores=new List<int>{67,89,67,54}},
    new Student {First="Hari",Last="Giri",ID=14,scores=new List<int>{67,89,67,54}},
    new Student {First="Shyam",Last="Giri",ID=15,scores=new List<int>{67,89,67,54}},
    new Student {First="Ganesh",Last="Giri",ID=16,scores=new List<int>{67,89,67,54}},

];
 static void Main() {


IEnumerable<Student> studentQuery=from student in students
where student.scores[0]>90 orderby student.Last ascending
select student;


foreach (Student student in students) {
    Console.WriteLine("{0},{1}",student.First ,student.Last);
}

    }
}







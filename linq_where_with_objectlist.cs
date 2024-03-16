using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int id
    {
        get;
        set;
    }
    public string name
    {
        get; set;
    }
    public string address
    {
        get;
        set;
    }

    public Student(int id, string name, string address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
}

public class TestLinq
{
    public static void Main()
    {
        List<Student> students = new List<Student>() {
            new Student(1,"Hari","Kathmandu"),
            new Student(2,"Shyam","Lalitpur"),
            new Student(3,"Sita","Bhaktapur"),
        };

        var result = from s in students
                     where s.address == "Kathmandu" && s.name == "Hari"
                     select s;

        Console.WriteLine("id\t name\t address");

        foreach (var a in result)
        {
            Console.WriteLine(a.id + "\t" + a.name + "\t" + a.address);

        }
    }

}